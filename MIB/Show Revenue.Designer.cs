namespace MIB
{
    partial class Show_Revenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cl_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(310, 274);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 38);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sum:";
            // 
            // tb_sum
            // 
            this.tb_sum.Enabled = false;
            this.tb_sum.Location = new System.Drawing.Point(49, 285);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(184, 20);
            this.tb_sum.TabIndex = 4;
            this.tb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VND";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(167, 9);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(66, 24);
            this.lb_date.TabIndex = 9;
            this.lb_date.Text = "label3";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_time,
            this.cl_money,
            this.cl_describe});
            this.dataGridView.Location = new System.Drawing.Point(15, 46);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(373, 218);
            this.dataGridView.TabIndex = 10;
            // 
            // cl_time
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.cl_time.DefaultCellStyle = dataGridViewCellStyle1;
            this.cl_time.Frozen = true;
            this.cl_time.HeaderText = "Time";
            this.cl_time.Name = "cl_time";
            this.cl_time.ReadOnly = true;
            this.cl_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cl_money
            // 
            this.cl_money.Frozen = true;
            this.cl_money.HeaderText = "Money";
            this.cl_money.Name = "cl_money";
            this.cl_money.ReadOnly = true;
            this.cl_money.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_money.Width = 120;
            // 
            // cl_describe
            // 
            this.cl_describe.Frozen = true;
            this.cl_describe.HeaderText = "Describe";
            this.cl_describe.Name = "cl_describe";
            this.cl_describe.ReadOnly = true;
            this.cl_describe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cl_describe.Width = 121;
            // 
            // Show_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Show_Revenue";
            this.Text = "Show Revenue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_describe;
    }
}