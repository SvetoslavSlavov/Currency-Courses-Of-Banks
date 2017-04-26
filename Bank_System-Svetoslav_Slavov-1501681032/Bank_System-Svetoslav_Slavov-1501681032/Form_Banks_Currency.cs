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
    public partial class Form_Banks_Currency : Form
    {
        public Form_Banks_Currency()
        {
            InitializeComponent();
        }
        //Добавяне на валута към банките
        private void Banks(string Name)
        {
            if (textBox_value.Text != "")
            {
                FileStream stream = new FileStream(Name, FileMode.Append);
                using (StreamWriter write = new StreamWriter(stream))
                {
                    write.WriteLine(textBox_value.Text + " " + comboBox_select_value.Text + " = 1лв");
                }
            }
            else
            {
                MessageBox.Show("Добавете валута", "Валута!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Четене от ListBox-а
        private void Show(string Name)
        {
            FileStream stream = new FileStream(Name, FileMode.OpenOrCreate);
            using (StreamReader read = new StreamReader(stream))
            {

                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    listBox_Currency.Items.Add(line/*+Environment.NewLine*/);


                }
            }
        }
        //Запазване на валутата от textBox_value
        private void Save_the_value_to_bgn(string BankName)
        {
            Directory.CreateDirectory("Bank_Value");
            FileStream stream = new FileStream("Bank_Value\\" + BankName, FileMode.Append);
            using (StreamWriter write = new StreamWriter(stream))
            {
                write.WriteLine(textBox_value.Text);

            }
        }
        //Забазване на използваните валутирли въвеждане в listBox-а от comboBox_select_value
        private void NamesOfTheValues(string Name)
        {
            Directory.CreateDirectory("Currencies");
            FileStream stream = new FileStream("Currencies\\" + Name, FileMode.Append);
            using (StreamWriter write = new StreamWriter(stream))
            {
                write.WriteLine(comboBox_select_value.Text);

            }
        }
        //за button_Delete изтриване от listBox-а и изписване в файла
        private void Delete(string Name)
        {
            FileStream stream = new FileStream(Name, FileMode.Create);
            using (StreamWriter write = new StreamWriter(stream))
            {
                for (int i = 0; i < listBox_Currency.Items.Count - 1; i++)
                {
                    write.WriteLine(listBox_Currency.Items);
                }
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox_Currency.Items.Remove(listBox_Currency.SelectedItem);
                Delete("Alpha Bank");

            }
            if (radioButton2.Checked)
            {
                listBox_Currency.Items.Remove(listBox_Currency.SelectedItem);
                Delete("SGE");

            }
            if (radioButton3.Checked)
            {
                listBox_Currency.Items.Remove(listBox_Currency.SelectedItem);
                Delete("Alianc");

            }
            if (radioButton4.Checked)
            {
                listBox_Currency.Items.Remove(listBox_Currency.SelectedItem);
                Delete("DSK");
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_select_value.SelectedIndex != -1)
            {
                if (radioButton1.Checked)
                {
                    Banks("Alpha Bank");
                    Save_the_value_to_bgn("Value_Alpha_Bank");
                    NamesOfTheValues("Value_Names_Alpha_Bank");
                    listBox_Currency.Items.Clear();
                    radioButton1_CheckedChanged(null, null);

                }
                if (radioButton2.Checked)
                {

                    Banks("SGE");
                    Save_the_value_to_bgn("Value_SGE");
                    NamesOfTheValues("Value_Names_SGE");
                    listBox_Currency.Items.Clear();
                    radioButton2_CheckedChanged(null, null);
                }
                if (radioButton3.Checked)
                {

                    Banks("Alianc");
                    Save_the_value_to_bgn("Value_Alianc");
                    NamesOfTheValues("Value_Names_Alianc");
                    listBox_Currency.Items.Clear();
                    radioButton3_CheckedChanged(null, null);
                }
                if (radioButton4.Checked)
                {

                    Banks("DSK");
                    Save_the_value_to_bgn("Value_DSK");
                    NamesOfTheValues("Value_Names_DSK");
                    listBox_Currency.Items.Clear();
                    radioButton4_CheckedChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Попълнете всички полета!", "Попълни!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox_Currency.Items.Clear();
                Show("Alpha Bank");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                listBox_Currency.Items.Clear();
                Show("SGE");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                listBox_Currency.Items.Clear();
                Show("Alianc");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                listBox_Currency.Items.Clear();
                Show("DSK");
            }
        }

        private void button_Delete_Currency_Click(object sender, EventArgs e)
        {
            textBox_value.Text = "";
        }

        private void textBox_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 46 && (e.KeyChar != '.')&&(e.KeyChar!=8))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
