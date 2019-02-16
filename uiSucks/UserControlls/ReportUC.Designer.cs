namespace uiSucks
{
    partial class ReportUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFinancialReport = new System.Windows.Forms.Button();
            this.btnTrainReport = new System.Windows.Forms.Button();
            this.btnTicketReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtReport = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.btnFinancialReport);
            this.panel3.Controls.Add(this.btnTrainReport);
            this.panel3.Controls.Add(this.btnTicketReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 58);
            this.panel3.TabIndex = 15;
            // 
            // btnFinancialReport
            // 
            this.btnFinancialReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.btnFinancialReport.FlatAppearance.BorderSize = 0;
            this.btnFinancialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancialReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancialReport.ForeColor = System.Drawing.Color.White;
            this.btnFinancialReport.Location = new System.Drawing.Point(583, 5);
            this.btnFinancialReport.Name = "btnFinancialReport";
            this.btnFinancialReport.Size = new System.Drawing.Size(172, 46);
            this.btnFinancialReport.TabIndex = 43;
            this.btnFinancialReport.Text = "Financial Report";
            this.btnFinancialReport.UseVisualStyleBackColor = false;
            this.btnFinancialReport.Click += new System.EventHandler(this.btnFinancialReport_Click);
            // 
            // btnTrainReport
            // 
            this.btnTrainReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.btnTrainReport.FlatAppearance.BorderSize = 0;
            this.btnTrainReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainReport.ForeColor = System.Drawing.Color.White;
            this.btnTrainReport.Location = new System.Drawing.Point(405, 5);
            this.btnTrainReport.Name = "btnTrainReport";
            this.btnTrainReport.Size = new System.Drawing.Size(172, 46);
            this.btnTrainReport.TabIndex = 44;
            this.btnTrainReport.Text = "Train Report";
            this.btnTrainReport.UseVisualStyleBackColor = false;
            this.btnTrainReport.Click += new System.EventHandler(this.btnTrainReport_Click);
            // 
            // btnTicketReport
            // 
            this.btnTicketReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.btnTicketReport.FlatAppearance.BorderSize = 0;
            this.btnTicketReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketReport.ForeColor = System.Drawing.Color.White;
            this.btnTicketReport.Location = new System.Drawing.Point(227, 5);
            this.btnTicketReport.Name = "btnTicketReport";
            this.btnTicketReport.Size = new System.Drawing.Size(172, 46);
            this.btnTicketReport.TabIndex = 42;
            this.btnTicketReport.Text = "Ticket Report";
            this.btnTicketReport.UseVisualStyleBackColor = false;
            this.btnTicketReport.Click += new System.EventHandler(this.btnTicketReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "0 trains match";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(54, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 40);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::uiSucks.Properties.Resources.iconfinder_icon_123_printer_3148W20;
            this.pictureBox1.Location = new System.Drawing.Point(781, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Management Report",
            "Employee Report",
            "User Report",
            "Customer Report"});
            this.comboBox1.Location = new System.Drawing.Point(15, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtReport);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 72);
            this.panel1.TabIndex = 12;
            // 
            // txtReport
            // 
            this.txtReport.AutoSize = true;
            this.txtReport.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtReport.Location = new System.Drawing.Point(87, 18);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(226, 26);
            this.txtReport.TabIndex = 2;
            this.txtReport.Text = "Select Report Reports ^";
            this.txtReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 356);
            this.dataGridView1.TabIndex = 16;
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(960, 620);
            this.Load += new System.EventHandler(this.ReportUC_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinancialReport;
        private System.Windows.Forms.Button btnTrainReport;
        private System.Windows.Forms.Button btnTicketReport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
