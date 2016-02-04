﻿using System;
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
    public partial class Show_Expenditure : Form
    {
        public Show_Expenditure()
        {
            InitializeComponent();
            InitForm();

            double sum = 0.0;
            textBox1.Text = Menux.MW.GetStringData("expenditure", ref sum);
            tb_sum.Text = Menux.MW.ConvertMoney(sum);
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Program.GF.MenuForm.Show();
            Program.GF.MenuForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Close();
        }
        private void InitForm()
        {
            lb_date.Text = Menux.MW.date.month + "/" + Menux.MW.date.year;
        }
    }
}