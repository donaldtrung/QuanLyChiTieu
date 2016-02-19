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
    public partial class Add_Revenue : Form
    {
        public Add_Revenue()
        {
            InitializeComponent();
            InitCombobox();
            this.ControlBox = false;       
       }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckInputValue())
            {
                DataType tmp = GetDataFromTextbox();
                Menux.MW.Add(tmp);
                Menux.MW.Write(Menux.MW.file_input);
                MessageBox.Show("Add Revenue Success", "Result");
                InitTextbox();                
            }
            else
            {
                MessageBox.Show("You need fill all text box", "Warning");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Program.GF.MenuForm.Show();
            Program.GF.MenuForm.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);

            this.Close();
        }

        private void tb_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CheckInputValue(e))
            {
                MessageBox.Show("Invalid!");
                e.Handled = true;
            }
        }

        private void InitCombobox()
        {
            cbb_unit.Items.Add("VND");
            cbb_unit.Items.Add("thousand VND");
            cbb_unit.Items.Add("hundred thousand VND");
            cbb_unit.Items.Add("million VND");
            cbb_unit.Items.Add("billion VND");
            cbb_unit.SelectedIndex = 1;  
        }

        private void InitTextbox()
        {
            tb_money.Text = "";
            tb_describe.Text = "";
        }

        private DataType GetDataFromTextbox()
        {
            DataType tmp = new DataType();

            tmp.money = tb_money.Text;
            tmp.describe = tb_describe.Text;
            tmp.unit = cbb_unit.Text;
            tmp.type = "revenue";
            tmp.time = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmp.date.month = Menux.MW.date.month;
            tmp.date.year = Menux.MW.date.year;

            return tmp;
        }

        private bool CheckInputValue(KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8 && Convert.ToInt16(e.KeyChar) != 13)
            {
                if (Convert.ToInt16(e.KeyChar) != Convert.ToInt16('.'))
                    return false;
                else
                    if (tb_money.Text.Contains('.') || tb_money.TextLength == 0)
                        return false;
                
            }

            return true;
        }

        private bool CheckInputValue()
        {
            if (tb_money.Text != "" && tb_describe.Text != "")
                return true;

            return false;
        }
    }
}
