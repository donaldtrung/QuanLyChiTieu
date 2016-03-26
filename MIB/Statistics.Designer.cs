namespace MIB
{
    partial class Statistics
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
            this.tb_revenue = new System.Windows.Forms.TextBox();
            this.tb_expenditure = new System.Windows.Forms.TextBox();
            this.tb_balance = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_revenue
            // 
            this.tb_revenue.Enabled = false;
            this.tb_revenue.Location = new System.Drawing.Point(103, 77);
            this.tb_revenue.Name = "tb_revenue";
            this.tb_revenue.ReadOnly = true;
            this.tb_revenue.Size = new System.Drawing.Size(184, 20);
            this.tb_revenue.TabIndex = 5;
            this.tb_revenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_expenditure
            // 
            this.tb_expenditure.Enabled = false;
            this.tb_expenditure.Location = new System.Drawing.Point(103, 122);
            this.tb_expenditure.Name = "tb_expenditure";
            this.tb_expenditure.ReadOnly = true;
            this.tb_expenditure.Size = new System.Drawing.Size(184, 20);
            this.tb_expenditure.TabIndex = 6;
            this.tb_expenditure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_balance
            // 
            this.tb_balance.Enabled = false;
            this.tb_balance.Location = new System.Drawing.Point(103, 181);
            this.tb_balance.Name = "tb_balance";
            this.tb_balance.ReadOnly = true;
            this.tb_balance.Size = new System.Drawing.Size(184, 20);
            this.tb_balance.TabIndex = 7;
            this.tb_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(291, 266);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 38);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Revenue: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Expenditure: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "đồng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "đồng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "đồng";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_balance);
            this.Controls.Add(this.tb_expenditure);
            this.Controls.Add(this.tb_revenue);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_revenue;
        private System.Windows.Forms.TextBox tb_expenditure;
        private System.Windows.Forms.TextBox tb_balance;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}