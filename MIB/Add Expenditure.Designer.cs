namespace MIB
{
    partial class Add_Expenditure
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_describe = new System.Windows.Forms.TextBox();
            this.cbb_unit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(207, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 39);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(303, 280);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // tb_money
            // 
            this.tb_money.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_money.Location = new System.Drawing.Point(77, 53);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(156, 20);
            this.tb_money.TabIndex = 4;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // tb_describe
            // 
            this.tb_describe.Location = new System.Drawing.Point(77, 117);
            this.tb_describe.Multiline = true;
            this.tb_describe.Name = "tb_describe";
            this.tb_describe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_describe.Size = new System.Drawing.Size(269, 148);
            this.tb_describe.TabIndex = 5;
            // 
            // cbb_unit
            // 
            this.cbb_unit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_unit.FormattingEnabled = true;
            this.cbb_unit.Location = new System.Drawing.Point(239, 52);
            this.cbb_unit.Name = "cbb_unit";
            this.cbb_unit.Size = new System.Drawing.Size(151, 21);
            this.cbb_unit.TabIndex = 6;
            // 
            // Add_Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.cbb_unit);
            this.Controls.Add(this.tb_describe);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Expenditure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expenditure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_describe;
        private System.Windows.Forms.ComboBox cbb_unit;
    }
}