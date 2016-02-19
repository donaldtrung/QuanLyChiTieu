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
    public partial class Change : Form
    {
        static DataType tmp;
        public Change(string time)
        {
            InitializeComponent();
            this.ControlBox = false;
            InitCombobox();

            tmp = Menux.MW.InitTextbox_ChangeForm(time);

            cbb_unit.Text = tmp.unit;
            tb_money.Text = tmp.money;
            tb_describe.Text = tmp.describe;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (CheckInputValue())
            {
                tmp.unit = cbb_unit.Text;
                tmp.money = tb_money.Text;
                tmp.describe = tb_describe.Text;

                Menux.MW.UpdateData(tmp);
                Menux.MW.Write(Menux.MW.file_input);

                MessageBox.Show("Success !!", "Result");

                this.Close();
            }
            else
            {
                MessageBox.Show("You need fill all text box", "Warning");
            }
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

        private void tb_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CheckInputValue(e))
            {
                MessageBox.Show("Invalid!");
                e.Handled = true;
            }
        }
    }
}
