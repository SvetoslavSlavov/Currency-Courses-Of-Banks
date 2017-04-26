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
    public partial class Form_Enter : Form
    {
        public Form_Enter()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Form_Banks_Currency form_banks_currency = new Form_Banks_Currency();
            form_banks_currency.MdiParent = this.MdiParent;
            form_banks_currency.Show();
            this.Close();
        }
    }
}
