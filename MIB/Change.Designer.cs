namespace MIB
{
    partial class Change
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbb_unit = new System.Windows.Forms.ComboBox();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_describe = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_unit
            // 
            this.cbb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_unit.FormattingEnabled = true;
            this.cbb_unit.Location = new System.Drawing.Point(242, 56);
            this.cbb_unit.Name = "cbb_unit";
            this.cbb_unit.Size = new System.Drawing.Size(141, 21);
            this.cbb_unit.TabIndex = 1;
            this.cbb_unit.Enter += new System.EventHandler(this.cbb_unit_Enter);
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(93, 56);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(143, 20);
            this.tb_money.TabIndex = 0;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // tb_describe
            // 
            this.tb_describe.Location = new System.Drawing.Point(93, 94);
            this.tb_describe.Multiline = true;
            this.tb_describe.Name = "tb_describe";
            this.tb_describe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_describe.Size = new System.Drawing.Size(290, 111);
            this.tb_describe.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(309, 211);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 34);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(227, 211);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 34);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Money: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Describe: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLEASE INPUT NEW VALUES";
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_describe);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.cbb_unit);
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_unit;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_describe;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}