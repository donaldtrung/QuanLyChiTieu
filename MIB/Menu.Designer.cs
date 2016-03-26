namespace MIB
{
    partial class Menux
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
            this.btn_addrevenue = new System.Windows.Forms.Button();
            this.btn_addexpenditure = new System.Windows.Forms.Button();
            this.btn_showrevenue = new System.Windows.Forms.Button();
            this.btn_showexpenditure = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addrevenue
            // 
            this.btn_addrevenue.Location = new System.Drawing.Point(59, 147);
            this.btn_addrevenue.Name = "btn_addrevenue";
            this.btn_addrevenue.Size = new System.Drawing.Size(139, 49);
            this.btn_addrevenue.TabIndex = 0;
            this.btn_addrevenue.Text = "Add Revenue";
            this.btn_addrevenue.UseVisualStyleBackColor = true;
            this.btn_addrevenue.Click += new System.EventHandler(this.btn_addrevenue_Click);
            // 
            // btn_addexpenditure
            // 
            this.btn_addexpenditure.Location = new System.Drawing.Point(213, 147);
            this.btn_addexpenditure.Name = "btn_addexpenditure";
            this.btn_addexpenditure.Size = new System.Drawing.Size(139, 49);
            this.btn_addexpenditure.TabIndex = 1;
            this.btn_addexpenditure.Text = "Add Expenditure";
            this.btn_addexpenditure.UseVisualStyleBackColor = true;
            this.btn_addexpenditure.Click += new System.EventHandler(this.btn_addexpenditure_Click);
            // 
            // btn_showrevenue
            // 
            this.btn_showrevenue.Location = new System.Drawing.Point(59, 202);
            this.btn_showrevenue.Name = "btn_showrevenue";
            this.btn_showrevenue.Size = new System.Drawing.Size(139, 47);
            this.btn_showrevenue.TabIndex = 2;
            this.btn_showrevenue.Text = "Show Revenue";
            this.btn_showrevenue.UseVisualStyleBackColor = true;
            this.btn_showrevenue.Click += new System.EventHandler(this.btn_showrevenue_Click);
            // 
            // btn_showexpenditure
            // 
            this.btn_showexpenditure.Location = new System.Drawing.Point(213, 202);
            this.btn_showexpenditure.Name = "btn_showexpenditure";
            this.btn_showexpenditure.Size = new System.Drawing.Size(139, 47);
            this.btn_showexpenditure.TabIndex = 3;
            this.btn_showexpenditure.Text = "Show Expenditure";
            this.btn_showexpenditure.UseVisualStyleBackColor = true;
            this.btn_showexpenditure.Click += new System.EventHandler(this.btn_showexpenditure_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(213, 255);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(139, 47);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "MY WALLET";
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(213, 108);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(56, 21);
            this.cbb_month.TabIndex = 6;
            this.cbb_month.TextChanged += new System.EventHandler(this.cbb_month_TextChanged);
            this.cbb_month.Enter += new System.EventHandler(this.cbb_month_Enter);
            // 
            // cbb_year
            // 
            this.cbb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(275, 108);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(77, 21);
            this.cbb_year.TabIndex = 7;
            this.cbb_year.TextChanged += new System.EventHandler(this.cbb_year_TextChanged);
            this.cbb_year.Enter += new System.EventHandler(this.cbb_year_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year";
            // 
            // btn_statistics
            // 
            this.btn_statistics.Location = new System.Drawing.Point(59, 255);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(139, 47);
            this.btn_statistics.TabIndex = 4;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // Menux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_year);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_showexpenditure);
            this.Controls.Add(this.btn_showrevenue);
            this.Controls.Add(this.btn_addexpenditure);
            this.Controls.Add(this.btn_addrevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addrevenue;
        private System.Windows.Forms.Button btn_addexpenditure;
        private System.Windows.Forms.Button btn_showrevenue;
        private System.Windows.Forms.Button btn_showexpenditure;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_statistics;

        public System.Windows.Forms.ComboBox GetCBBMonth()
        {
            return cbb_month;
        }

        public System.Windows.Forms.ComboBox GetCBBYear()
        {
            return cbb_year;
        }
    }
}

