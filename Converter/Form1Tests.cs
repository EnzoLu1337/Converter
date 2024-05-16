using NUnit.Framework;
using System;
using System.Windows.Forms;
using NUnit.Framework.Legacy;

namespace Converter
{
    [TestFixture]
    public class Form1Tests
    {
        private Form1 form;

        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

        [Test]
        public void ConvertValues_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            form.lengthComboFrom = new ComboBox();
            form.lengthComboTo = new ComboBox();
            form.lengthTextBox = new TextBox();
            form.totaLengtLabel = new Label();

            form.lengthComboFrom.Items.Add("Километры");
            form.lengthComboTo.Items.Add("Метры");
            form.lengthComboFrom.SelectedItem = "Километры";
            form.lengthComboTo.SelectedItem = "Метры";
            form.lengthTextBox.Text = "1";

            // Act
            form.ConvertValues(form.lengthComboFrom, form.lengthComboTo, form.lengthTextBox, form.totaLengtLabel);

            // Assert
            ClassicAssert.AreEqual("Итого: 1000,000 m", form.totaLengtLabel.Text);
        }

        [Test]
        public void ConvertNumber_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            form.comboBox6 = new ComboBox();
            form.comboBox7 = new ComboBox();
            form.textBox6 = new TextBox();
            form.label11 = new Label();

            form.comboBox6.Items.Add("Двоичная");
            form.comboBox7.Items.Add("Десятичная");
            form.comboBox6.SelectedItem = "Двоичная";
            form.comboBox7.SelectedItem = "Десятичная";
            form.textBox6.Text = "1010";

            // Act
            form.ConvertNumber(form.comboBox6, form.comboBox7, form.textBox6, form.label11);

            // Assert
            ClassicAssert.AreEqual("Итого: 10₁₀", form.label11.Text);
        }

        [Test]
        public void textBox_KeyPress_ValidDecimalInput_AllowsDigit()
        {
            // Arrange
            var textBox = new TextBox();
            var e = new KeyPressEventArgs('1');

            // Act
            form.textBox_KeyPress(textBox, e);

            // Assert
            ClassicAssert.IsFalse(e.Handled);
        }

        [Test]
        public void textBox_KeyPress_InvalidDecimalInput_BlocksNonDigit()
        {
            // Arrange
            var textBox = new TextBox();
            var e = new KeyPressEventArgs('a');

            // Act
            form.textBox_KeyPress(textBox, e);

            // Assert
            ClassicAssert.IsTrue(e.Handled);
        }

        [Test]
        public void currencyCombo_SelectedIndexChanged_ValidCurrencyPair_SetsCorrectRate()
        {
            // Arrange
            form.pairsArray = new[]
            {
                new Form1.CurrencyPairs { Pair = "USD/RUB", Course = 75.5 }
            };
            form.currencyCombo = new ComboBox();
            form.CursLabel = new Label();

            form.currencyCombo.Items.Add("USD/RUB");
            form.currencyCombo.SelectedItem = "USD/RUB";

            // Act
            form.currencyCombo_SelectedIndexChanged(this, EventArgs.Empty);

            // Assert
            ClassicAssert.AreEqual("Курс USD/RUB: 75,50", form.CursLabel.Text);
        }

        [Test]
        public void textBox1_TextChanged_ValidCurrencyInput_CalculatesCorrectTotal()
        {
            // Arrange
            form.pairsArray = new[]
            {
                new Form1.CurrencyPairs { Pair = "USD/RUB", Course = 75.5 }
            };
            form.currencyCombo = new ComboBox();
            form.currencyBox = new TextBox();
            form.FinalCurseLabel = new Label();

            form.currencyCombo.Items.Add("USD/RUB");
            form.currencyCombo.SelectedItem = "USD/RUB";
            form.currencyBox.Text = "2";

            // Act
            form.textBox1_TextChanged(this, EventArgs.Empty);

            // Assert
            ClassicAssert.AreEqual("Итого: 151,00", form.FinalCurseLabel.Text);
        }
    }
}
