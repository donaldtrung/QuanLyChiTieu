using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.IO;

namespace MIB
{
    public partial class Menux : Form
    {        
        public static MyWallet MW = new MyWallet();

        public Menux()
        {
            InitializeComponent();
            InitCombobox();
            this.ControlBox = false;

            MW.Read(MW.data, MW.file_input);
        }

        private void btn_addrevenue_Click(object sender, EventArgs e)
        {
            Add_Revenue AddRevenueForm = new Add_Revenue();
            AddRevenueForm.Show();
            AddRevenueForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

           this.Hide();
        }

        private void btn_showrevenue_Click(object sender, EventArgs e)
        {
           Show_Revenue ShowRevenueForm = new Show_Revenue();
           ShowRevenueForm.Show();
           ShowRevenueForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addexpenditure_Click(object sender, EventArgs e)
        {
            Add_Expenditure add = new Add_Expenditure();

            add.Show();
            add.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Hide();
        }

        private void btn_showexpenditure_Click(object sender, EventArgs e)
        {
            Show_Expenditure show = new Show_Expenditure();

            show.Show();
            show.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Hide();
        }

        private void cbb_month_TextChanged(object sender, EventArgs e)
        {
            MW.date.month = cbb_month.Text;
        }

        private void cbb_year_TextChanged(object sender, EventArgs e)
        {
            MW.date.year = cbb_year.Text;
        }
        private void InitCombobox()
        {
            cbb_month.Items.Add("01");
            cbb_month.Items.Add("02");
            cbb_month.Items.Add("03");
            cbb_month.Items.Add("04");
            cbb_month.Items.Add("05");
            cbb_month.Items.Add("06");
            cbb_month.Items.Add("07");
            cbb_month.Items.Add("08");
            cbb_month.Items.Add("09");
            cbb_month.Items.Add("10");
            cbb_month.Items.Add("11");
            cbb_month.Items.Add("12");


            string month = DateTime.Now.Month.ToString(), year = DateTime.Now.Year.ToString();
            cbb_year.Items.Add((year).ToString());
            cbb_year.Items.Add((Int32.Parse(year) - 1).ToString());
            cbb_year.Items.Add((Int32.Parse(year) - 2).ToString());

            cbb_month.SelectedIndex = Int32.Parse(month) - 1;
            cbb_year.SelectedIndex = 0;        
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics StatisticsForm = new Statistics();
            StatisticsForm.Show();
            StatisticsForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Hide();
        }
        
    }
}
