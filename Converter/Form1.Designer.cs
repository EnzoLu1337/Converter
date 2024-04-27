namespace Converter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FinalCurseLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.currencyBox = new System.Windows.Forms.TextBox();
            this.CursLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lengthComboTo = new System.Windows.Forms.ComboBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totaLengtLabel = new System.Windows.Forms.Label();
            this.lengthComboFrom = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WeightComboTo = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalWeightLabel = new System.Windows.Forms.Label();
            this.WeightComboFrom = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.areaComboTo = new System.Windows.Forms.ComboBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalAreaLabel = new System.Windows.Forms.Label();
            this.areaComboFrom = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataComboTo = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.totalDataLabel = new System.Windows.Forms.Label();
            this.dataComboFrom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 128);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FinalCurseLabel);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.currencyBox);
            this.tabPage1.Controls.Add(this.CursLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.currencyCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Валюта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FinalCurseLabel
            // 
            this.FinalCurseLabel.AutoSize = true;
            this.FinalCurseLabel.Location = new System.Drawing.Point(271, 35);
            this.FinalCurseLabel.Name = "FinalCurseLabel";
            this.FinalCurseLabel.Size = new System.Drawing.Size(43, 13);
            this.FinalCurseLabel.TabIndex = 6;
            this.FinalCurseLabel.Text = "Итого: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Пара";
            // 
            // currencyBox
            // 
            this.currencyBox.Location = new System.Drawing.Point(148, 33);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(100, 20);
            this.currencyBox.TabIndex = 4;
            this.currencyBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.currencyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // CursLabel
            // 
            this.CursLabel.AutoSize = true;
            this.CursLabel.Location = new System.Drawing.Point(12, 56);
            this.CursLabel.Name = "CursLabel";
            this.CursLabel.Size = new System.Drawing.Size(37, 13);
            this.CursLabel.TabIndex = 3;
            this.CursLabel.Text = "Курс: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение";
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Location = new System.Drawing.Point(12, 32);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 21);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.SelectedIndexChanged += new System.EventHandler(this.currencyCombo_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lengthComboTo);
            this.tabPage2.Controls.Add(this.lengthTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.totaLengtLabel);
            this.tabPage2.Controls.Add(this.lengthComboFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Длина";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lengthComboTo
            // 
            this.lengthComboTo.FormattingEnabled = true;
            this.lengthComboTo.Items.AddRange(new object[] {
            "Километры",
            "Метры",
            "Дециметры",
            "Сантиметры",
            "Мили",
            "Ярды",
            "Футы",
            "Дюймы"});
            this.lengthComboTo.Location = new System.Drawing.Point(265, 33);
            this.lengthComboTo.Name = "lengthComboTo";
            this.lengthComboTo.Size = new System.Drawing.Size(121, 21);
            this.lengthComboTo.TabIndex = 10;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(148, 33);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 9;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.lengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Значение";
            // 
            // totaLengtLabel
            // 
            this.totaLengtLabel.AutoSize = true;
            this.totaLengtLabel.Location = new System.Drawing.Point(306, 16);
            this.totaLengtLabel.Name = "totaLengtLabel";
            this.totaLengtLabel.Size = new System.Drawing.Size(43, 13);
            this.totaLengtLabel.TabIndex = 8;
            this.totaLengtLabel.Text = "Итого: ";
            // 
            // lengthComboFrom
            // 
            this.lengthComboFrom.FormattingEnabled = true;
            this.lengthComboFrom.Items.AddRange(new object[] {
            "Километры",
            "Метры",
            "Дециметры",
            "Сантиметры",
            "Мили",
            "Ярды",
            "Футы",
            "Дюймы"});
            this.lengthComboFrom.Location = new System.Drawing.Point(12, 32);
            this.lengthComboFrom.Name = "lengthComboFrom";
            this.lengthComboFrom.Size = new System.Drawing.Size(121, 21);
            this.lengthComboFrom.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WeightComboTo);
            this.tabPage3.Controls.Add(this.weightTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.totalWeightLabel);
            this.tabPage3.Controls.Add(this.WeightComboFrom);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Масса";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WeightComboTo
            // 
            this.WeightComboTo.FormattingEnabled = true;
            this.WeightComboTo.Items.AddRange(new object[] {
            "Тонны",
            "Килограммы",
            "Граммы",
            "Центнеры",
            "Фунты",
            "Унции"});
            this.WeightComboTo.Location = new System.Drawing.Point(265, 33);
            this.WeightComboTo.Name = "WeightComboTo";
            this.WeightComboTo.Size = new System.Drawing.Size(121, 21);
            this.WeightComboTo.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(148, 33);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Значение";
            // 
            // totalWeightLabel
            // 
            this.totalWeightLabel.AutoSize = true;
            this.totalWeightLabel.Location = new System.Drawing.Point(306, 16);
            this.totalWeightLabel.Name = "totalWeightLabel";
            this.totalWeightLabel.Size = new System.Drawing.Size(43, 13);
            this.totalWeightLabel.TabIndex = 8;
            this.totalWeightLabel.Text = "Итого: ";
            // 
            // WeightComboFrom
            // 
            this.WeightComboFrom.FormattingEnabled = true;
            this.WeightComboFrom.Items.AddRange(new object[] {
            "Тонны",
            "Килограммы",
            "Граммы",
            "Центнеры",
            "Фунты",
            "Унции"});
            this.WeightComboFrom.Location = new System.Drawing.Point(12, 32);
            this.WeightComboFrom.Name = "WeightComboFrom";
            this.WeightComboFrom.Size = new System.Drawing.Size(121, 21);
            this.WeightComboFrom.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.areaComboTo);
            this.tabPage4.Controls.Add(this.areaTextBox);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.totalAreaLabel);
            this.tabPage4.Controls.Add(this.areaComboFrom);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(737, 283);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Площадь";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // areaComboTo
            // 
            this.areaComboTo.FormattingEnabled = true;
            this.areaComboTo.Items.AddRange(new object[] {
            "Кв. километры",
            "Кв. метры",
            "Кв. дециметры",
            "Кв. сантиметры",
            "Гектары"});
            this.areaComboTo.Location = new System.Drawing.Point(265, 33);
            this.areaComboTo.Name = "areaComboTo";
            this.areaComboTo.Size = new System.Drawing.Size(121, 21);
            this.areaComboTo.TabIndex = 10;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(148, 33);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 9;
            this.areaTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.areaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Значение";
            // 
            // totalAreaLabel
            // 
            this.totalAreaLabel.AutoSize = true;
            this.totalAreaLabel.Location = new System.Drawing.Point(306, 16);
            this.totalAreaLabel.Name = "totalAreaLabel";
            this.totalAreaLabel.Size = new System.Drawing.Size(43, 13);
            this.totalAreaLabel.TabIndex = 8;
            this.totalAreaLabel.Text = "Итого: ";
            // 
            // areaComboFrom
            // 
            this.areaComboFrom.FormattingEnabled = true;
            this.areaComboFrom.Items.AddRange(new object[] {
            "Кв. километры",
            "Кв. метры",
            "Кв. дециметры",
            "Кв. сантиметры",
            "Гектары"});
            this.areaComboFrom.Location = new System.Drawing.Point(12, 32);
            this.areaComboFrom.Name = "areaComboFrom";
            this.areaComboFrom.Size = new System.Drawing.Size(121, 21);
            this.areaComboFrom.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataComboTo);
            this.tabPage5.Controls.Add(this.dataTextBox);
            this.tabPage5.Controls.Add(this.totalDataLabel);
            this.tabPage5.Controls.Add(this.dataComboFrom);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(737, 283);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Данные";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataComboTo
            // 
            this.dataComboTo.FormattingEnabled = true;
            this.dataComboTo.Items.AddRange(new object[] {
            "Байт",
            "Килобайт",
            "Мегабайт",
            "Гигабайт",
            "Терабайт",
            "Петабайт"});
            this.dataComboTo.Location = new System.Drawing.Point(265, 33);
            this.dataComboTo.Name = "dataComboTo";
            this.dataComboTo.Size = new System.Drawing.Size(121, 21);
            this.dataComboTo.TabIndex = 10;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(148, 33);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 9;
            this.dataTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.dataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // totalDataLabel
            // 
            this.totalDataLabel.AutoSize = true;
            this.totalDataLabel.Location = new System.Drawing.Point(306, 16);
            this.totalDataLabel.Name = "totalDataLabel";
            this.totalDataLabel.Size = new System.Drawing.Size(43, 13);
            this.totalDataLabel.TabIndex = 8;
            this.totalDataLabel.Text = "Итого: ";
            // 
            // dataComboFrom
            // 
            this.dataComboFrom.FormattingEnabled = true;
            this.dataComboFrom.Items.AddRange(new object[] {
            "Байт",
            "Килобайт",
            "Мегабайт",
            "Гигабайт",
            "Терабайт",
            "Петабайт"});
            this.dataComboFrom.Location = new System.Drawing.Point(12, 32);
            this.dataComboFrom.Name = "dataComboFrom";
            this.dataComboFrom.Size = new System.Drawing.Size(121, 21);
            this.dataComboFrom.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Значение";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.comboBox7);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.comboBox6);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(401, 102);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Система счисления";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Двоичная",
            "Восьмеричная",
            "Десятичная",
            "Шестнадцатеричная"});
            this.comboBox7.Location = new System.Drawing.Point(265, 33);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(148, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Итого: ";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Двоичная",
            "Восьмеричная",
            "Десятичная",
            "Шестнадцатеричная"});
            this.comboBox6.Location = new System.Drawing.Point(12, 32);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Значение";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 126);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Конвертор Величин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.TextBox currencyBox;
        private System.Windows.Forms.Label CursLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totaLengtLabel;
        private System.Windows.Forms.ComboBox lengthComboFrom;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalWeightLabel;
        private System.Windows.Forms.ComboBox WeightComboFrom;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalAreaLabel;
        private System.Windows.Forms.ComboBox areaComboFrom;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label totalDataLabel;
        private System.Windows.Forms.ComboBox dataComboFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox lengthComboTo;
        private System.Windows.Forms.ComboBox WeightComboTo;
        private System.Windows.Forms.ComboBox areaComboTo;
        private System.Windows.Forms.ComboBox dataComboTo;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label FinalCurseLabel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

