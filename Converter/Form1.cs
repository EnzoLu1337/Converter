using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Converter
{
    public partial class Form1 : Form
    {

        const string url = "https://currate.ru/api/";
        const string apiKey = "4e2ffd1d6177270f8d59fe3ca54f00d5";

        private Dictionary<string, double> conversionFactors = new Dictionary<string, double>()
        {
            {"Километры", 1},
            {"Метры", 1000},
            {"Дециметры", 10000},
            {"Сантиметры", 100000},
            {"Мили", 0.621371},
            {"Ярды", 1093.61},
            {"Футы", 3280.84},
            {"Дюймы", 39370.1},
            {"Тонны", 0.001},
            {"Килограммы", 1},
            {"Граммы", 1000},
            {"Центнеры", 0.01},
            {"Фунты", 2.2046},
            {"Унции", 35.2739},
            {"Кв. километры", 0.000001},
            {"Кв. метры", 1},
            {"Кв. дециметры", 100},
            {"Кв. сантиметры", 10000},
            {"Гектары", 0.0001},
            {"Байт", 1125899906842624},
            {"Килобайт", 1099511627776},
            {"Мегабайт", 1073741824},
            {"Гигабайт", 1048576},
            {"Терабайт", 1024},
            {"Петабайт", 1}
        };

        private Dictionary<string, string> symbolValues = new Dictionary<string, string>()
        {
            {"Километры", "km"},
            {"Метры", "m"},
            {"Дециметры", "dm"},
            {"Сантиметры", "cm"},
            {"Мили", "mi"},
            {"Ярды", "yd"},
            {"Футы", "ft"},
            {"Дюймы", "in"},
            {"Тонны", "t"},
            {"Килограммы", "kg"},
            {"Граммы", "g"},
            {"Центнеры", "q"},
            {"Фунты", "lb"},
            {"Унции", "oz"},
            {"Кв. километры", "km²"},
            {"Кв. метры", "m²"},
            {"Кв. дециметры", "dm²"},
            {"Кв. сантиметры", "cm²"},
            {"Гектары", "ha"},
            {"Байт", "Б"},
            {"Килобайт", "КБ"},
            {"Мегабайт", "МБ"},
            {"Гигабайт", "ГБ"},
            {"Терабайт", "ТБ"},
            {"Петабайт", "ПБ"}
        };

        struct CurrencyPairs
        {
            public string Pair;
            public double Course;
        }
        CurrencyPairs[] pairsArray = { };

        public Form1()
        {
            InitializeComponent();
            currencyCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            lengthComboFrom.SelectedItem = "Километры";
            lengthComboFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            lengthComboTo.SelectedItem = "Метры";
            lengthComboTo.DropDownStyle = ComboBoxStyle.DropDownList;

            WeightComboFrom.SelectedItem = "Килограммы";
            WeightComboFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            WeightComboTo.SelectedItem = "Тонны";
            WeightComboTo.DropDownStyle = ComboBoxStyle.DropDownList;

            areaComboFrom.SelectedItem = "Кв. метры";
            areaComboFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            areaComboTo.SelectedItem = "Гектары";
            areaComboTo.DropDownStyle = ComboBoxStyle.DropDownList;

            dataComboFrom.SelectedItem = "Мегабайт";
            dataComboFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            dataComboTo.SelectedItem = "Гигабайт";
            dataComboTo.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string currencyResponse = await Get($"{url}?get=currency_list&key={apiKey}");
            if (!string.IsNullOrEmpty(currencyResponse))
            {
                //MessageBox.Show($"currencyResponse: {currencyResponse}");

                string[] currencyList = GetCurrencyList(currencyResponse);

                //MessageBox.Show($"currencyList: {currencyList.Length}");

                // Формируем строку с перечислением всех валютных пар из currencyList
                string pairs = string.Join(",", currencyList);

                // Получаем курсы для всех валютных пар
                string ratesResponse = await Get($"{url}?get=rates&pairs={pairs}&key={apiKey}");
                //MessageBox.Show($"ratesResponse: {ratesResponse}");

                if (!string.IsNullOrEmpty(ratesResponse))
                {
                    // Парсим ответ JSON
                    JObject jsonObject = JObject.Parse(ratesResponse);
                    JObject dataObject = (JObject)jsonObject["data"];

                    // Создаем список для хранения объектов CurrencyPairs
                    List<CurrencyPairs> pairsList = new List<CurrencyPairs>();

                    // Заполняем список объектами CurrencyPairs
                    foreach (var pair in dataObject)
                    {
                        CurrencyPairs currencyPair = new CurrencyPairs();
                        currencyPair.Pair = pair.Key;
                        if (double.TryParse(pair.Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out currencyPair.Course))
                        {
                            pairsList.Add(currencyPair);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка парсинга курса для валютной пары {pair.Key}: {pair.Value}");
                        }
                    }

                    pairsArray = pairsList.ToArray();
                    //MessageBox.Show($"Количество валютных пар в массиве: {pairsArray.Length}");
                    foreach (var pair in pairsArray)
                    {
                        currencyCombo.Items.Add(pair.Pair);
                    }
                }
                else
                {
                    Console.WriteLine("Пустой ответ при загрузке курсов.");
                }
            }
            else
            {
                Console.WriteLine("Пустой ответ при получении списка валютных пар.");
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        static async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {e.Message}");
                    return string.Empty;
                }
            }
        }

        static string[] GetCurrencyList(string jsonResponse)
        {
            JObject jsonObject = JObject.Parse(jsonResponse);
            JArray dataArray = (JArray)jsonObject["data"];
            return dataArray.ToObject<string[]>();
        }

        private void currencyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCurrencyPair = currencyCombo.SelectedItem.ToString();
            CurrencyPairs selectedPair = pairsArray.FirstOrDefault(pair => pair.Pair == selectedCurrencyPair);

            if (!string.IsNullOrEmpty(selectedPair.Pair))
            {
                double rate = selectedPair.Course;
                CursLabel.Text = $"Курс {selectedCurrencyPair}: {rate:F2}";
            }
            else
            {
                CursLabel.Text = "Курс не найден";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string selectedCurrencyPair = currencyCombo.SelectedItem.ToString();
            CurrencyPairs selectedPair = pairsArray.FirstOrDefault(pair => pair.Pair == selectedCurrencyPair);
            if (double.TryParse(currencyBox.Text, out double value))
            {
                double count = double.Parse(currencyBox.Text);
                if (selectedCurrencyPair != null)
                {
                    if (selectedPair.Pair != null)
                    {
                        if (double.TryParse(selectedPair.Course.ToString(), out double course))
                        {
                            double total = count * course;
                            FinalCurseLabel.Text = $"Итого: {total:F2}";
                        }
                        else
                        {
                            FinalCurseLabel.Text = "Ошибка при парсинге курса";
                        }
                    }
                    else
                    {
                        FinalCurseLabel.Text = "Курс не найден";
                    }
                }
                else
                {
                    FinalCurseLabel.Text = "Валютная пара не выбрана";
                }
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение.");
            }
        }

        private void ConvertValues(System.Windows.Forms.ComboBox fromUnitComboBox, System.Windows.Forms.ComboBox toUnitComboBox, System.Windows.Forms.TextBox valueTextBox, Label resultLabel)
        {
            string fromUnit = fromUnitComboBox.SelectedItem.ToString();
            string toUnit = toUnitComboBox.SelectedItem.ToString();

            if (double.TryParse(valueTextBox.Text, out double value))
            {
                double convertedValue = value * conversionFactors[toUnit] / conversionFactors[fromUnit];
                resultLabel.Text = $"Итого: {convertedValue:F3} {symbolValues[toUnit]}";
            }
            else
            {
                MessageBox.Show("Введите корректное числовое значение.");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ConvertValues(lengthComboFrom, lengthComboTo, lengthTextBox, totaLengtLabel);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ConvertValues(WeightComboFrom, WeightComboTo, weightTextBox, totalWeightLabel);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ConvertValues(areaComboFrom, areaComboTo, areaTextBox, totalAreaLabel);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ConvertValues(dataComboFrom, dataComboTo, dataTextBox, totalDataLabel);
        }
    }
}