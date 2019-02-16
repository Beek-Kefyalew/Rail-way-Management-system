namespace uiSucks
{
    partial class TrainMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMytrain = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WorkTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contact1 = new uiSucks.Contact();
            this.myTrainUC1 = new uiSucks.MyTrainUC();
            this.help1 = new uiSucks.Help();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(153, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 30);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(913, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(822, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logout";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::uiSucks.Properties.Resources._01;
            this.panel3.Controls.Add(this.btnMytrain);
            this.panel3.Controls.Add(this.btnabout);
            this.panel3.Controls.Add(this.btnhelp);
            this.panel3.Controls.Add(this.btnContact);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnReports);
            this.panel3.Controls.Add(this.btnMap);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 613);
            this.panel3.TabIndex = 9;
            // 
            // btnMytrain
            // 
            this.btnMytrain.BackColor = System.Drawing.Color.Transparent;
            this.btnMytrain.FlatAppearance.BorderSize = 0;
            this.btnMytrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMytrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMytrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMytrain.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMytrain.ForeColor = System.Drawing.Color.White;
            this.btnMytrain.Image = global::uiSucks.Properties.Resources.D41R4kQxg7DdL;
            this.btnMytrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMytrain.Location = new System.Drawing.Point(0, 102);
            this.btnMytrain.Name = "btnMytrain";
            this.btnMytrain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMytrain.Size = new System.Drawing.Size(153, 33);
            this.btnMytrain.TabIndex = 10;
            this.btnMytrain.Text = "     My Train";
            this.btnMytrain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMytrain.UseVisualStyleBackColor = false;
            this.btnMytrain.Click += new System.EventHandler(this.btnMytrain_Click);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.Transparent;
            this.btnabout.FlatAppearance.BorderSize = 0;
            this.btnabout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnabout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabout.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.White;
            this.btnabout.Image = global::uiSucks.Properties.Resources.iconfinder_info_4105939;
            this.btnabout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnabout.Location = new System.Drawing.Point(0, 297);
            this.btnabout.Name = "btnabout";
            this.btnabout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnabout.Size = new System.Drawing.Size(153, 33);
            this.btnabout.TabIndex = 7;
            this.btnabout.Text = "     About";
            this.btnabout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnabout.UseVisualStyleBackColor = false;
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.Transparent;
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.ForeColor = System.Drawing.Color.White;
            this.btnhelp.Image = global::uiSucks.Properties.Resources.iconfinder_fav_410593GRE7W;
            this.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhelp.Location = new System.Drawing.Point(0, 258);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnhelp.Size = new System.Drawing.Size(153, 33);
            this.btnhelp.TabIndex = 8;
            this.btnhelp.Text = "     Help";
            this.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Transparent;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.Image = global::uiSucks.Properties.Resources.iconfinder_Call_calling_phone_communication_4014660;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(0, 219);
            this.btnContact.Name = "btnContact";
            this.btnContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnContact.Size = new System.Drawing.Size(153, 33);
            this.btnContact.TabIndex = 9;
            this.btnContact.Text = "     Contact ";
            this.btnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "          RM-RF System   1.0";
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::uiSucks.Properties.Resources.iconfinder_OUTLINE_Bussiness_and_Media_22_40W41213;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 180);
            this.btnReports.Name = "btnReports";
            this.btnReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReports.Size = new System.Drawing.Size(153, 33);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "     Report issue";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Transparent;
            this.btnMap.FlatAppearance.BorderSize = 0;
            this.btnMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.Image = global::uiSucks.Properties.Resources.Screenshot_at_2019_02_01_13_07_27;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMap.Location = new System.Drawing.Point(0, 141);
            this.btnMap.Name = "btnMap";
            this.btnMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMap.Size = new System.Drawing.Size(153, 33);
            this.btnMap.TabIndex = 5;
            this.btnMap.Text = "     Map";
            this.btnMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::uiSucks.Properties.Resources._001;
            this.panel4.Controls.Add(this.WorkTitle);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 96);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // WorkTitle
            // 
            this.WorkTitle.AutoSize = true;
            this.WorkTitle.BackColor = System.Drawing.Color.Transparent;
            this.WorkTitle.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkTitle.ForeColor = System.Drawing.Color.Gray;
            this.WorkTitle.Location = new System.Drawing.Point(32, 68);
            this.WorkTitle.Name = "WorkTitle";
            this.WorkTitle.Size = new System.Drawing.Size(93, 14);
            this.WorkTitle.TabIndex = 2;
            this.WorkTitle.Text = "RM-RF Conductor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jhon Doe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::uiSucks.Properties.Resources.iconfinder_batman_hero_avatar_comics_4043232;
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.contact1);
            this.panel5.Controls.Add(this.myTrainUC1);
            this.panel5.Controls.Add(this.help1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(153, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 583);
            this.panel5.TabIndex = 11;
            // 
            // contact1
            // 
            this.contact1.Location = new System.Drawing.Point(138, 249);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(364, 138);
            this.contact1.TabIndex = 7;
            // 
            // myTrainUC1
            // 
            this.myTrainUC1.Location = new System.Drawing.Point(157, 27);
            this.myTrainUC1.Name = "myTrainUC1";
            this.myTrainUC1.Size = new System.Drawing.Size(383, 156);
            this.myTrainUC1.TabIndex = 6;
            this.myTrainUC1.Visible = false;
            this.myTrainUC1.Load += new System.EventHandler(this.myTrainUC1_Load);
            // 
            // help1
            // 
            this.help1.Location = new System.Drawing.Point(697, 402);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(202, 153);
            this.help1.TabIndex = 4;
            this.help1.Visible = false;
            // 
            // TrainMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 615);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainMain";
            this.Text = "TrainMain";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMytrain;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label WorkTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private Contact contact1;
        private MyTrainUC myTrainUC1;
        private Help help1;
    }
}