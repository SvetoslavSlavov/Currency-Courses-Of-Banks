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
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }
        //Enable and make visible the objects
        private void button_show_Click(object sender, EventArgs e)
        {
            button_refresh.Enabled = true;
            button_refresh.Visible = true;

            button_show.Enabled = true;
            button_show.Visible = true;

            label_show.Enabled = true;
            label_show.Visible = true;

            comboBox_select.Enabled = true;
            comboBox_select.Visible = true;

            listBox_bank_report.Enabled = true;
            listBox_bank_report.Visible = true;
        }
        //чете от файла за превръщане на валута в лв. и добавя в listBox_bank_report
        private void read_Bank_Report(string bank_Name)
        {
            FileStream stream = new FileStream(bank_Name, FileMode.OpenOrCreate);
            using (StreamReader read = new StreamReader(stream))
            {
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    listBox_bank_report.Items.Add(line);
                }
            }
        }

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_select.Text)
            {
                case "Alpha Bank":
                    listBox_bank_report.Items.Clear();
                    read_Bank_Report("Alpha Bank");
                    break;
                case "SGE":
                    listBox_bank_report.Items.Clear();
                    read_Bank_Report("SGE");
                    break;
                case "Alianc":
                    listBox_bank_report.Items.Clear();
                    read_Bank_Report("Alianc");
                    break;
                case "DSK":
                    listBox_bank_report.Items.Clear();
                    read_Bank_Report("DSK");
                    break;
                default:
                    MessageBox.Show("Несъществуваща Банка!", "Невалидна Банка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            comboBox_select.Text = "---Избор на Банка---";
            listBox_bank_report.Items.Clear();
        }
        //за да не се пише в comboBox-а
        private void comboBox_select_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
