namespace uiSucks.Editing_Forms
{
    partial class Edit_Train
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
            this.components = new System.ComponentModel.Container();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.comboTrainType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.BackColor = System.Drawing.Color.DimGray;
            this.richtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richtxtDescription.Location = new System.Drawing.Point(166, 242);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(364, 52);
            this.richtxtDescription.TabIndex = 106;
            this.richtxtDescription.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(58, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 105;
            this.label15.Text = "description";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(300, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 104;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(121)))), ((int)(((byte)(4)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(179, 338);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(103, 26);
            this.btnAddEmployee.TabIndex = 103;
            this.btnAddEmployee.Text = "Update Train";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(58, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 102;
            this.label5.Text = "MAC Address";
            // 
            // txtMAC
            // 
            this.txtMAC.BackColor = System.Drawing.Color.DimGray;
            this.txtMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMAC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMAC.Location = new System.Drawing.Point(166, 210);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(364, 13);
            this.txtMAC.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(58, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "Destination";
            // 
            // comboDestination
            // 
            this.comboDestination.BackColor = System.Drawing.Color.Gray;
            this.comboDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDestination.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Items.AddRange(new object[] {
            "Ayat",
            "CMC",
            "Megenagna",
            "st. Estifanos",
            "Mexico",
            "Torhailoch",
            "Menlik II Square",
            "Abenet",
            "Lanncha",
            "Saris",
            "Kaliti"});
            this.comboDestination.Location = new System.Drawing.Point(166, 168);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(364, 21);
            this.comboDestination.TabIndex = 99;
            // 
            // comboStart
            // 
            this.comboStart.BackColor = System.Drawing.Color.Gray;
            this.comboStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboStart.FormattingEnabled = true;
            this.comboStart.Items.AddRange(new object[] {
            "Ayat",
            "CMC",
            "Megenagna",
            "st. Estifanos",
            "Mexico",
            "Torhailoch",
            "Menlik II Square",
            "Abenet",
            "Lanncha",
            "Saris",
            "Kaliti"});
            this.comboStart.Location = new System.Drawing.Point(166, 127);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(364, 21);
            this.comboStart.TabIndex = 98;
            // 
            // comboTrainType
            // 
            this.comboTrainType.BackColor = System.Drawing.Color.Gray;
            this.comboTrainType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTrainType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboTrainType.FormattingEnabled = true;
            this.comboTrainType.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.comboTrainType.Location = new System.Drawing.Point(166, 80);
            this.comboTrainType.Name = "comboTrainType";
            this.comboTrainType.Size = new System.Drawing.Size(364, 21);
            this.comboTrainType.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(58, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 96;
            this.label10.Text = "Train Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(58, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Starting Station";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "Edit Existing Train";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 93;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Edit_Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::uiSucks.Properties.Resources._001;
            this.ClientSize = new System.Drawing.Size(580, 387);
            this.Controls.Add(this.richtxtDescription);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboDestination);
            this.Controls.Add(this.comboStart);
            this.Controls.Add(this.comboTrainType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Train";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_Train";
            this.Load += new System.EventHandler(this.Edit_Train_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.ComboBox comboTrainType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}