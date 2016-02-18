using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIB
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            Menux.MW.Statistic();
            this.ControlBox = false;

            Statistics_func(Menux.MW.sum_rev,Menux.MW.sum_exp,Menux.MW.balance);
        }
        private void Statistics_func(double sum_rev, double sum_exp, double balance)
        { 
            tb_revenue.Text = Menux.MW.ConvertMoney(sum_rev);
            tb_expenditure.Text = Menux.MW.ConvertMoney(sum_exp);
            tb_balance.Text = Menux.MW.ConvertMoney(balance);
       }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Program.GF.MenuForm.Show();
            Program.GF.MenuForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Close();
        }
    }
}
