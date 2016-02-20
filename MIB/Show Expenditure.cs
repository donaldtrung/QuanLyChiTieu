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
    public partial class Show_Expenditure : Form
    {
        public Show_Expenditure()
        {
            InitializeComponent();
            InitForm();
            this.ControlBox = false;

            updateData("expenditure");

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

        private void btn_change_Click(object sender, EventArgs e)
        {
            string time = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Change ch = new Change(time);

            ch.ShowDialog();
            updateData("expenditure");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this row !!", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Deleted successfully!!", "Result", MessageBoxButtons.OK);

                string time = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string type = Menux.MW.DeleteRow(time);
                updateData(type);
            }

            Menux.MW.Write(Menux.MW.file_input);
        }

        private void updateData(string type)
        {
            double sum = 0.0;
            dataGridView.DataSource = Menux.MW.GetStringData(type, ref sum);
            tb_sum.Text = Menux.MW.ConvertMoney(sum);

            if (dataGridView.RowCount == 0)
            {
                btn_delete.Enabled = false;
                btn_change.Enabled = false;
            }
        }
    }
}
