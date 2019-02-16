namespace uiSucks
{
    partial class AddTrain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTrainType = new System.Windows.Forms.ComboBox();
            this.comboStart = new System.Windows.Forms.ComboBox();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 1);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Add New Train";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(58, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 79;
            this.label10.Text = "Train Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(58, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Starting Station";
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
            this.comboTrainType.Location = new System.Drawing.Point(166, 60);
            this.comboTrainType.Name = "comboTrainType";
            this.comboTrainType.Size = new System.Drawing.Size(364, 21);
            this.comboTrainType.TabIndex = 82;
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
            this.comboStart.Location = new System.Drawing.Point(166, 107);
            this.comboStart.Name = "comboStart";
            this.comboStart.Size = new System.Drawing.Size(364, 21);
            this.comboStart.TabIndex = 84;
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
            this.comboDestination.Location = new System.Drawing.Point(166, 148);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(364, 21);
            this.comboDestination.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(58, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 86;
            this.label4.Text = "Destination";
            // 
            // txtMAC
            // 
            this.txtMAC.BackColor = System.Drawing.Color.DimGray;
            this.txtMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMAC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMAC.Location = new System.Drawing.Point(166, 190);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(364, 13);
            this.txtMAC.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(58, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 88;
            this.label5.Text = "MAC Address";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(300, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 26);
            this.button2.TabIndex = 90;
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
            this.btnAddEmployee.Location = new System.Drawing.Point(179, 318);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(103, 26);
            this.btnAddEmployee.TabIndex = 89;
            this.btnAddEmployee.Text = "Add Train";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.BackColor = System.Drawing.Color.DimGray;
            this.richtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richtxtDescription.Location = new System.Drawing.Point(166, 222);
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.Size = new System.Drawing.Size(364, 52);
            this.richtxtDescription.TabIndex = 92;
            this.richtxtDescription.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(58, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 91;
            this.label15.Text = "description";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::uiSucks.Properties.Resources._001;
            this.ClientSize = new System.Drawing.Size(596, 381);
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
            this.Name = "AddTrain";
            this.Text = "AddTrain";
            this.Load += new System.EventHandler(this.AddTrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTrainType;
        private System.Windows.Forms.ComboBox comboStart;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.RichTextBox richtxtDescription;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}