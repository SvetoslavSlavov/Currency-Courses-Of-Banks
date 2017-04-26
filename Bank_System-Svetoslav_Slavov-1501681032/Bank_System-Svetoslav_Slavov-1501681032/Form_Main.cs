using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Svetoslav_Slavov_1501681032
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Enter form_enter = new Form_Enter();
            form_enter.MdiParent = this;
            form_enter.Show();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Enter form_enter = new Form_Enter();
            form_enter.MdiParent = this;
            form_enter.Show();
        }

        private void изходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void отчетНаВалутитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report form_report = new Form_Report();
            form_report.MdiParent = this;
            form_report.Show();
        }

        private void валутенКалкулаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bank_Converter form_bank_converter = new Form_Bank_Converter();
            form_bank_converter.MdiParent = this;
            form_bank_converter.Show();
        }

        private void заАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Author author = new Form_Author();
            author.MdiParent = this;
            author.Show();
        }
    }
}
