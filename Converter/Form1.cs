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

namespace Converter
{
    public partial class Form1 : Form
    {

        string url = "https://currate.ru/api/";
        string apiKey = "4e2ffd1d6177270f8d59fe3ca54f00d5";

        CurrencyPairs[] pairsArray = { };
        struct CurrencyPairs
        {
            public string Pair;
            public double Course;
        }

        public Form1()
        {
            InitializeComponent();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
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
                CursLabel.Text = $"Курс {selectedCurrencyPair}: {rate}";
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

            double count = double.Parse(textBox1.Text);
            if (selectedCurrencyPair != null)
            {
                if (selectedPair.Pair != null)
                {
                    if (double.TryParse(selectedPair.Course.ToString(), out double course))
                    {
                        double total = count * course;
                        FinalCurseLabel.Text = $"Итого: {total}";
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
    }
}
