namespace uiSucks
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.reportUC1 = new uiSucks.ReportUC();
            this.usersUC1 = new uiSucks.UsersUC();
            this.help1 = new uiSucks.Help();
            this.employeesUC1 = new uiSucks.employeesUC();
            this.trainsUC1 = new uiSucks.TrainsUC();
            this.mapControll1 = new uiSucks.mapControll();
            this.Home1 = new uiSucks.Home();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTask = new System.Windows.Forms.Panel();
            this.taskLine = new System.Windows.Forms.PictureBox();
            this.alltask = new System.Windows.Forms.Button();
            this.maintenance = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnTrains = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HomePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskLine)).BeginInit();
            this.menupanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 2);
            this.panel1.TabIndex = 0;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.reportUC1);
            this.HomePanel.Controls.Add(this.usersUC1);
            this.HomePanel.Controls.Add(this.help1);
            this.HomePanel.Controls.Add(this.employeesUC1);
            this.HomePanel.Controls.Add(this.trainsUC1);
            this.HomePanel.Controls.Add(this.mapControll1);
            this.HomePanel.Controls.Add(this.Home1);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(153, 32);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(955, 622);
            this.HomePanel.TabIndex = 4;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // reportUC1
            // 
            this.reportUC1.Location = new System.Drawing.Point(431, 397);
            this.reportUC1.Name = "reportUC1";
            this.reportUC1.Size = new System.Drawing.Size(211, 237);
            this.reportUC1.TabIndex = 6;
            // 
            // usersUC1
            // 
            this.usersUC1.AutoScroll = true;
            this.usersUC1.BackColor = System.Drawing.Color.Gainsboro;
            this.usersUC1.Location = new System.Drawing.Point(93, 297);
            this.usersUC1.Name = "usersUC1";
            this.usersUC1.Size = new System.Drawing.Size(274, 133);
            this.usersUC1.TabIndex = 5;
            // 
            // help1
            // 
            this.help1.AutoScroll = true;
            this.help1.Location = new System.Drawing.Point(386, 111);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(256, 189);
            this.help1.TabIndex = 4;
            this.help1.Visible = false;
            // 
            // employeesUC1
            // 
            this.employeesUC1.BackColor = System.Drawing.Color.Gainsboro;
            this.employeesUC1.command = null;
            this.employeesUC1.Connectionstr = "Data Source=.; Initial Catalog = RailMGMT ; Integrated Security=True";
            this.employeesUC1.Location = new System.Drawing.Point(443, 6);
            this.employeesUC1.Name = "employeesUC1";
            this.employeesUC1.Size = new System.Drawing.Size(240, 68);
            this.employeesUC1.TabIndex = 3;
            this.employeesUC1.Visible = false;
            this.employeesUC1.Load += new System.EventHandler(this.employeesUC1_Load);
            // 
            // trainsUC1
            // 
            this.trainsUC1.BackColor = System.Drawing.Color.Gainsboro;
            this.trainsUC1.command = null;
            this.trainsUC1.Connectionstr = "Data Source=.; Initial Catalog = RailMGMT ; Integrated Security=True";
            this.trainsUC1.Location = new System.Drawing.Point(22, 173);
            this.trainsUC1.Name = "trainsUC1";
            this.trainsUC1.Size = new System.Drawing.Size(229, 73);
            this.trainsUC1.TabIndex = 2;
            this.trainsUC1.Visible = false;
            // 
            // mapControll1
            // 
            this.mapControll1.Location = new System.Drawing.Point(260, 16);
            this.mapControll1.Name = "mapControll1";
            this.mapControll1.Size = new System.Drawing.Size(163, 99);
            this.mapControll1.TabIndex = 1;
            this.mapControll1.Visible = false;
            // 
            // Home1
            // 
            this.Home1.Location = new System.Drawing.Point(6, 38);
            this.Home1.Name = "Home1";
            this.Home1.Size = new System.Drawing.Size(147, 77);
            this.Home1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(153, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 30);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(929, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.AutoSize = true;
            this.logOut.BackColor = System.Drawing.Color.Transparent;
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.Silver;
            this.logOut.Location = new System.Drawing.Point(838, 6);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(47, 15);
            this.logOut.TabIndex = 9;
            this.logOut.Text = "Logout";
            this.logOut.Click += new System.EventHandler(this.label5_Click);
            this.logOut.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            this.logOut.MouseHover += new System.EventHandler(this.logOut_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.panelTask);
            this.panel3.Controls.Add(this.tasks);
            this.panel3.Controls.Add(this.menupanel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnReports);
            this.panel3.Controls.Add(this.btnMap);
            this.panel3.Controls.Add(this.btnTrains);
            this.panel3.Controls.Add(this.btnEmployees);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 652);
            this.panel3.TabIndex = 2;
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.Color.Transparent;
            this.panelTask.Controls.Add(this.taskLine);
            this.panelTask.Controls.Add(this.alltask);
            this.panelTask.Controls.Add(this.maintenance);
            this.panelTask.Location = new System.Drawing.Point(0, 336);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(150, 89);
            this.panelTask.TabIndex = 10;
            this.panelTask.Visible = false;
            // 
            // taskLine
            // 
            this.taskLine.BackColor = System.Drawing.Color.Transparent;
            this.taskLine.Image = global::uiSucks.Properties.Resources.Glong;
            this.taskLine.Location = new System.Drawing.Point(34, 10);
            this.taskLine.Name = "taskLine";
            this.taskLine.Size = new System.Drawing.Size(2, 49);
            this.taskLine.TabIndex = 12;
            this.taskLine.TabStop = false;
            // 
            // alltask
            // 
            this.alltask.BackColor = System.Drawing.Color.Transparent;
            this.alltask.FlatAppearance.BorderSize = 0;
            this.alltask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.alltask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.alltask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alltask.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltask.ForeColor = System.Drawing.Color.White;
            this.alltask.Image = global::uiSucks.Properties.Resources.iconfinder_info_4105939;
            this.alltask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alltask.Location = new System.Drawing.Point(50, 8);
            this.alltask.Name = "alltask";
            this.alltask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alltask.Size = new System.Drawing.Size(103, 23);
            this.alltask.TabIndex = 10;
            this.alltask.Text = "    AllTask";
            this.alltask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alltask.UseVisualStyleBackColor = false;
            // 
            // maintenance
            // 
            this.maintenance.BackColor = System.Drawing.Color.Transparent;
            this.maintenance.FlatAppearance.BorderSize = 0;
            this.maintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.maintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maintenance.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenance.ForeColor = System.Drawing.Color.White;
            this.maintenance.Image = global::uiSucks.Properties.Resources.green_setting;
            this.maintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenance.Location = new System.Drawing.Point(50, 39);
            this.maintenance.Name = "maintenance";
            this.maintenance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maintenance.Size = new System.Drawing.Size(103, 23);
            this.maintenance.TabIndex = 11;
            this.maintenance.Text = "    Maintenance";
            this.maintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.maintenance.UseVisualStyleBackColor = false;
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.Color.Transparent;
            this.tasks.FlatAppearance.BorderSize = 0;
            this.tasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.tasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasks.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks.ForeColor = System.Drawing.Color.White;
            this.tasks.Image = global::uiSucks.Properties.Resources.iconfinder_OUTLINE_Bussiness_and_Media_22_40W41213;
            this.tasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tasks.Location = new System.Drawing.Point(0, 297);
            this.tasks.Name = "tasks";
            this.tasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tasks.Size = new System.Drawing.Size(153, 33);
            this.tasks.TabIndex = 10;
            this.tasks.Text = "     Tasks       ";
            this.tasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tasks.UseVisualStyleBackColor = false;
            this.tasks.Click += new System.EventHandler(this.tasks_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.Transparent;
            this.menupanel.Controls.Add(this.btnUsers);
            this.menupanel.Controls.Add(this.help);
            this.menupanel.Location = new System.Drawing.Point(0, 427);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(153, 100);
            this.menupanel.TabIndex = 9;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::uiSucks.Properties.Resources.iconfinder_fav_410593GRE7W;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(-3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsers.Size = new System.Drawing.Size(153, 33);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "     Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.Color.White;
            this.help.Image = global::uiSucks.Properties.Resources.iconfinder_info_4105939;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.Location = new System.Drawing.Point(0, 42);
            this.help.Name = "help";
            this.help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.help.Size = new System.Drawing.Size(153, 33);
            this.help.TabIndex = 8;
            this.help.Text = "     Help";
            this.help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 638);
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
            this.btnReports.Location = new System.Drawing.Point(0, 258);
            this.btnReports.Name = "btnReports";
            this.btnReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReports.Size = new System.Drawing.Size(153, 33);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "     Report   ";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button6_Click);
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
            this.btnMap.Location = new System.Drawing.Point(0, 219);
            this.btnMap.Name = "btnMap";
            this.btnMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMap.Size = new System.Drawing.Size(153, 33);
            this.btnMap.TabIndex = 5;
            this.btnMap.Text = "     Map";
            this.btnMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnTrains
            // 
            this.btnTrains.BackColor = System.Drawing.Color.Transparent;
            this.btnTrains.FlatAppearance.BorderSize = 0;
            this.btnTrains.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTrains.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTrains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrains.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrains.ForeColor = System.Drawing.Color.White;
            this.btnTrains.Image = global::uiSucks.Properties.Resources.D41R4kQxg7DdL;
            this.btnTrains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrains.Location = new System.Drawing.Point(0, 141);
            this.btnTrains.Name = "btnTrains";
            this.btnTrains.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTrains.Size = new System.Drawing.Size(153, 33);
            this.btnTrains.TabIndex = 3;
            this.btnTrains.Text = "     Trains";
            this.btnTrains.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrains.UseVisualStyleBackColor = false;
            this.btnTrains.Click += new System.EventHandler(this.btnTrains_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::uiSucks.Properties.Resources.iconfinder_users_4105943;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 180);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEmployees.Size = new System.Drawing.Size(153, 33);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "     Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Green;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::uiSucks.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 102);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(153, 33);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "     Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 96);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "RM-RF Administator";
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 654);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.HomePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskLine)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnTrains;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Label logOut;
        private System.Windows.Forms.PictureBox taskLine;
        private System.Windows.Forms.Button maintenance;
        private System.Windows.Forms.Button alltask;
        private System.Windows.Forms.Button tasks;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Panel HomePanel;
        private Home Home1;
        private mapControll mapControll1;
        private TrainsUC trainsUC1;
        private employeesUC employeesUC1;
        private System.Windows.Forms.Label label4;
        private Help help1;
        private System.Windows.Forms.Button btnUsers;
        private UsersUC usersUC1;
        private ReportUC reportUC1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

