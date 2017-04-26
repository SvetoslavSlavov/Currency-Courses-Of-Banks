using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank_System_Svetoslav_Slavov_1501681032
{
    public partial class Form_Bank_Converter : Form
    {
        public Form_Bank_Converter()
        {
            InitializeComponent();
            comboBox_Banks.SelectedIndex = 0;
            comboBox_From.SelectedIndex = 0;
            comboBox_To.SelectedIndex = 1;
        }
        private void Banks_Value(string BankName)
        {
            try
            {
                using (StreamReader read = new StreamReader("Currencies\\" + BankName))
                {
                    while (!read.EndOfStream)
                    {
                        string line = read.ReadLine();
                        comboBox_From.Items.Add(line);
                        comboBox_To.Items.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Няма данни за банката!", "Добави данни", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Добавете данни за банка!","Няма открити данни",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
            private void Calculate(string BankName, string Value_to_BGN)
            {
            try
            {
                double from;
                double to;

                //тук зареждам себестойността на валутите от избраната банка в списъка currency
                List<double> currency = new List<double>();
                using (StreamReader read = new StreamReader(BankName))
                {
                    using (StreamReader read1 = new StreamReader("Bank_Value\\" + Value_to_BGN))
                    {
                        while (!read1.EndOfStream)
                        {
                            currency.Add(double.Parse(read1.ReadLine()));
                        }
                    }
                }
                from = currency[comboBox_From.SelectedIndex];
                to = currency[comboBox_To.SelectedIndex];

                textBox_to.Text = (to / from * (double.Parse(textBox_from.Text))).ToString("0.0000");

            }
            catch (FormatException)
            {
                textBox_from.Text = "";
                textBox_to.Text = "";
            }
        }
        private void Select(string Bank, string Bank_Value)
        {
            if (comboBox_Banks.Text == Bank)
            {
                switch (comboBox_From.Text)
                {
                    case "Британска лира(GBP)":
                        if (comboBox_To.Text == "Британска лира(GBP)")
                        {
                            MessageBox.Show("Въведете радлични валути", "Валути");
                        }
                        if (comboBox_To.Text == "Евро(EUR)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Руска рубла(RUB)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Щатски долар(USD)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Японска йена(JPY)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        break;
                    case "Евро(EUR)":
                        if (comboBox_To.Text == "Евро(EUR)")
                        {
                            MessageBox.Show("Въведете радлични валути", "Валути");
                        }
                        if (comboBox_To.Text == "Британска лира(GBP)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Руска рубла(RUB)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Щатски долар(USD)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Японска йена(JPY)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        break;
                    case "Руска рубла(RUB)":
                        if (comboBox_To.Text == "Руска рубла(RUB)")
                        {
                            MessageBox.Show("Въведете радлични валути", "Валути");
                        }
                        if (comboBox_To.Text == "Британска лира(GBP)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Евро(EUR)")
                        {
                            Calculate(Bank, Bank_Value);
                        }

                        if (comboBox_To.Text == "Щатски долар(USD)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Японска йена(JPY)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        break;
                    case "Щатски долар(USD)":
                        if (comboBox_To.Text == "Щатски долар(USD)")
                        {
                            MessageBox.Show("Въведете радлични валути", "Валути");
                        }
                        if (comboBox_To.Text == "Британска лира(GBP)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Евро(EUR)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Руска рубла(RUB)")
                        {
                            Calculate(Bank, Bank_Value);
                        }

                        if (comboBox_To.Text == "Японска йена(JPY)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        break;
                    case "Японска йена(JPY)":
                        if (comboBox_To.Text == "Японска йена(JPY)")
                        {
                            MessageBox.Show("Въведете радлични валути", "Валути");
                        }
                        if (comboBox_To.Text == "Британска лира(GBP)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Евро(EUR)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Руска рубла(RUB)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        if (comboBox_To.Text == "Щатски долар(USD)")
                        {
                            Calculate(Bank, Bank_Value);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        private void comboBox_Banks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Banks.Text == "Alpha Bank")
            {
                Banks_Value("Value_Names_Alpha_Bank");
            }
            if (comboBox_Banks.Text == "SGE")
            {
                Banks_Value("Value_Names_SGE");
            }
            if (comboBox_Banks.Text == "Alianc")
            {
                Banks_Value("Value_Names_Alianc");
            }
            if (comboBox_Banks.Text == "DSK")
            {
                Banks_Value("Value_Names_DSK");
            }
        }

        private void textBox_from_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_Banks.Text == "Alpha Bank")
            {
                Select("Alpha Bank", "Value_Alpha_Bank");
            }
            if (comboBox_Banks.Text == "SGE")
            {
                Select("SGE", "Value_SGE");
            }
            if (comboBox_Banks.Text == "Alianc")
            {
                Select("Alianc", "Value_Alianc");
            }
            if (comboBox_Banks.Text == "DSK")
            {
                Select("DSK", "Value_DSK");
            }
        }
        //за да не могат да се въвеждат знаци и символи освен една точка за дробен разделител и backspace за изтриване
        private void textBox_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 46 && (e.KeyChar != '.') && e.KeyChar != 8)
            {

                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_choose_Click(object sender, EventArgs e)
        {

        }
    }
}
