namespace MIB
{
    partial class Add_Revenue
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
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_describe = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cbb_unit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(77, 53);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(158, 20);
            this.tb_money.TabIndex = 0;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // tb_describe
            // 
            this.tb_describe.Location = new System.Drawing.Point(77, 113);
            this.tb_describe.Multiline = true;
            this.tb_describe.Name = "tb_describe";
            this.tb_describe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_describe.Size = new System.Drawing.Size(269, 148);
            this.tb_describe.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(207, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 39);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(303, 280);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 39);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cbb_unit
            // 
            this.cbb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_unit.FormattingEnabled = true;
            this.cbb_unit.Location = new System.Drawing.Point(241, 52);
            this.cbb_unit.Name = "cbb_unit";
            this.cbb_unit.Size = new System.Drawing.Size(149, 21);
            this.cbb_unit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decribe:";
            // 
            // Add_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_unit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_describe);
            this.Controls.Add(this.tb_money);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Revenue";
            this.Text = "Add Revenue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Revenue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_describe;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cbb_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}