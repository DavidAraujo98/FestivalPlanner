using System.Drawing;

namespace PlanFest
{
    partial class PlanFest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanFest));
            this.server_input = new System.Windows.Forms.TextBox();
            this.server_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.server = new System.Windows.Forms.FlowLayoutPanel();
            this.user = new System.Windows.Forms.FlowLayoutPanel();
            this.user_label = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.FlowLayoutPanel();
            this.password_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.form_login = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_festivals = new System.Windows.Forms.Button();
            this.btn_concerts = new System.Windows.Forms.Button();
            this.btn_stages = new System.Windows.Forms.Button();
            this.btn_bands = new System.Windows.Forms.Button();
            this.btn_meals = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.panel_base = new System.Windows.Forms.Panel();
            this.panel_festivalslist = new System.Windows.Forms.Panel();
            this.panel_festival = new System.Windows.Forms.Panel();
            this.numericUpDown_ticketssold = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_managertype = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_manageridnumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_managertelephone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_managersex = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_manageremail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_managername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_promoteridnumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_promotertelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_promotersex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_promoteremail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_promotername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_festivalname = new System.Windows.Forms.TextBox();
            this.label_promotername = new System.Windows.Forms.Label();
            this.btn_changefestival = new System.Windows.Forms.Button();
            this.btn_deletefestival = new System.Windows.Forms.Button();
            this.label_festivalid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker_festivalend = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker_festivalbegin = new System.Windows.Forms.DateTimePicker();
            this.btn_editfestival = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addfestival = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_openfestival = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.server.SuspendLayout();
            this.user.SuspendLayout();
            this.password.SuspendLayout();
            this.form_login.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_base.SuspendLayout();
            this.panel_festivalslist.SuspendLayout();
            this.panel_festival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).BeginInit();
            this.SuspendLayout();
            // 
            // server_input
            // 
            this.server_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_input.Location = new System.Drawing.Point(3, 23);
            this.server_input.Name = "server_input";
            this.server_input.Size = new System.Drawing.Size(259, 22);
            this.server_input.TabIndex = 0;
            // 
            // server_label
            // 
            this.server_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.server_label.AutoSize = true;
            this.server_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.server_label.Location = new System.Drawing.Point(3, 0);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(259, 20);
            this.server_label.TabIndex = 1;
            this.server_label.Text = "Server name";
            this.server_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.server_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // server
            // 
            this.server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.server.AutoSize = true;
            this.server.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.server.Controls.Add(this.server_label);
            this.server.Controls.Add(this.server_input);
            this.server.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.server.Location = new System.Drawing.Point(40, 48);
            this.server.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(265, 48);
            this.server.TabIndex = 2;
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.user.Controls.Add(this.user_label);
            this.user.Controls.Add(this.user_input);
            this.user.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.user.Location = new System.Drawing.Point(40, 112);
            this.user.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(265, 48);
            this.user.TabIndex = 3;
            // 
            // user_label
            // 
            this.user_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.user_label.Location = new System.Drawing.Point(3, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(259, 20);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "Login";
            this.user_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_input
            // 
            this.user_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_input.Location = new System.Drawing.Point(3, 23);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(259, 22);
            this.user_input.TabIndex = 0;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.AutoSize = true;
            this.password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.password.Controls.Add(this.password_label);
            this.password.Controls.Add(this.password_input);
            this.password.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.password.Location = new System.Drawing.Point(40, 176);
            this.password.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(265, 48);
            this.password.TabIndex = 4;
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.password_label.Location = new System.Drawing.Point(3, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(259, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(3, 23);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '●';
            this.password_input.Size = new System.Drawing.Size(259, 22);
            this.password_input.TabIndex = 0;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // form_login
            // 
            this.form_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.form_login.AutoSize = true;
            this.form_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.form_login.BackColor = System.Drawing.Color.White;
            this.form_login.Controls.Add(this.server);
            this.form_login.Controls.Add(this.user);
            this.form_login.Controls.Add(this.password);
            this.form_login.Controls.Add(this.btn_connect);
            this.form_login.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.form_login.Location = new System.Drawing.Point(273, 120);
            this.form_login.Margin = new System.Windows.Forms.Padding(0);
            this.form_login.Name = "form_login";
            this.form_login.Padding = new System.Windows.Forms.Padding(40);
            this.form_login.Size = new System.Drawing.Size(345, 311);
            this.form_login.TabIndex = 5;
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = true;
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(40, 248);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(265, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.menu.Controls.Add(this.logo);
            this.menu.Controls.Add(this.btn_festivals);
            this.menu.Controls.Add(this.btn_concerts);
            this.menu.Controls.Add(this.btn_stages);
            this.menu.Controls.Add(this.btn_bands);
            this.menu.Controls.Add(this.btn_meals);
            this.menu.Controls.Add(this.btn_staff);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(173, 542);
            this.menu.TabIndex = 6;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(173, 88);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_festivals
            // 
            this.btn_festivals.AutoSize = true;
            this.btn_festivals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_festivals.FlatAppearance.BorderSize = 0;
            this.btn_festivals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_festivals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_festivals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_festivals.Location = new System.Drawing.Point(0, 138);
            this.btn_festivals.Margin = new System.Windows.Forms.Padding(0, 50, 0, 3);
            this.btn_festivals.Name = "btn_festivals";
            this.btn_festivals.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_festivals.Size = new System.Drawing.Size(173, 50);
            this.btn_festivals.TabIndex = 1;
            this.btn_festivals.Text = "Festivals";
            this.btn_festivals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_festivals.UseVisualStyleBackColor = true;
            this.btn_festivals.Click += new System.EventHandler(this.btn_festivals_Click);
            // 
            // btn_concerts
            // 
            this.btn_concerts.AutoSize = true;
            this.btn_concerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_concerts.FlatAppearance.BorderSize = 0;
            this.btn_concerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_concerts.Location = new System.Drawing.Point(0, 191);
            this.btn_concerts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_concerts.Name = "btn_concerts";
            this.btn_concerts.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_concerts.Size = new System.Drawing.Size(173, 50);
            this.btn_concerts.TabIndex = 2;
            this.btn_concerts.Text = "Concerts";
            this.btn_concerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_concerts.UseVisualStyleBackColor = true;
            this.btn_concerts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stages
            // 
            this.btn_stages.AutoSize = true;
            this.btn_stages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_stages.FlatAppearance.BorderSize = 0;
            this.btn_stages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_stages.Location = new System.Drawing.Point(0, 244);
            this.btn_stages.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_stages.Name = "btn_stages";
            this.btn_stages.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_stages.Size = new System.Drawing.Size(173, 50);
            this.btn_stages.TabIndex = 3;
            this.btn_stages.Text = "Stages";
            this.btn_stages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stages.UseVisualStyleBackColor = true;
            this.btn_stages.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_bands
            // 
            this.btn_bands.AutoSize = true;
            this.btn_bands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_bands.FlatAppearance.BorderSize = 0;
            this.btn_bands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_bands.Location = new System.Drawing.Point(0, 297);
            this.btn_bands.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_bands.Name = "btn_bands";
            this.btn_bands.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_bands.Size = new System.Drawing.Size(173, 50);
            this.btn_bands.TabIndex = 4;
            this.btn_bands.Text = "Bands";
            this.btn_bands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bands.UseVisualStyleBackColor = true;
            this.btn_bands.Click += new System.EventHandler(this.Bands_Click);
            // 
            // btn_meals
            // 
            this.btn_meals.AutoSize = true;
            this.btn_meals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_meals.FlatAppearance.BorderSize = 0;
            this.btn_meals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_meals.Location = new System.Drawing.Point(0, 350);
            this.btn_meals.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_meals.Name = "btn_meals";
            this.btn_meals.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_meals.Size = new System.Drawing.Size(173, 50);
            this.btn_meals.TabIndex = 5;
            this.btn_meals.Text = "Meals";
            this.btn_meals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_meals.UseVisualStyleBackColor = true;
            // 
            // btn_staff
            // 
            this.btn_staff.AutoSize = true;
            this.btn_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_staff.Location = new System.Drawing.Point(0, 403);
            this.btn_staff.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_staff.Size = new System.Drawing.Size(173, 50);
            this.btn_staff.TabIndex = 6;
            this.btn_staff.Text = "Staff";
            this.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.UseVisualStyleBackColor = true;
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.panel_festivalslist);
            this.panel_base.Controls.Add(this.menu);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(910, 542);
            this.panel_base.TabIndex = 7;
            this.panel_base.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_home_Paint);
            // 
            // panel_festivalslist
            // 
            this.panel_festivalslist.Controls.Add(this.panel_festival);
            this.panel_festivalslist.Controls.Add(this.label1);
            this.panel_festivalslist.Controls.Add(this.btn_addfestival);
            this.panel_festivalslist.Controls.Add(this.listBox1);
            this.panel_festivalslist.Controls.Add(this.btn_openfestival);
            this.panel_festivalslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_festivalslist.Location = new System.Drawing.Point(173, 0);
            this.panel_festivalslist.Name = "panel_festivalslist";
            this.panel_festivalslist.Size = new System.Drawing.Size(737, 542);
            this.panel_festivalslist.TabIndex = 7;
            // 
            // panel_festival
            // 
            this.panel_festival.Controls.Add(this.label19);
            this.panel_festival.Controls.Add(this.numericUpDown_ticketssold);
            this.panel_festival.Controls.Add(this.label18);
            this.panel_festival.Controls.Add(this.label17);
            this.panel_festival.Controls.Add(this.comboBox_managertype);
            this.panel_festival.Controls.Add(this.label16);
            this.panel_festival.Controls.Add(this.textBox_manageridnumber);
            this.panel_festival.Controls.Add(this.label15);
            this.panel_festival.Controls.Add(this.textBox_managertelephone);
            this.panel_festival.Controls.Add(this.label14);
            this.panel_festival.Controls.Add(this.comboBox_managersex);
            this.panel_festival.Controls.Add(this.label13);
            this.panel_festival.Controls.Add(this.textBox_manageremail);
            this.panel_festival.Controls.Add(this.label12);
            this.panel_festival.Controls.Add(this.textBox_managername);
            this.panel_festival.Controls.Add(this.label11);
            this.panel_festival.Controls.Add(this.label10);
            this.panel_festival.Controls.Add(this.comboBox1);
            this.panel_festival.Controls.Add(this.label9);
            this.panel_festival.Controls.Add(this.textBox_promoteridnumber);
            this.panel_festival.Controls.Add(this.label8);
            this.panel_festival.Controls.Add(this.textBox_promotertelephone);
            this.panel_festival.Controls.Add(this.label7);
            this.panel_festival.Controls.Add(this.comboBox_promotersex);
            this.panel_festival.Controls.Add(this.label6);
            this.panel_festival.Controls.Add(this.textBox_promoteremail);
            this.panel_festival.Controls.Add(this.label5);
            this.panel_festival.Controls.Add(this.textBox_promotername);
            this.panel_festival.Controls.Add(this.label4);
            this.panel_festival.Controls.Add(this.textBox_festivalname);
            this.panel_festival.Controls.Add(this.label_promotername);
            this.panel_festival.Controls.Add(this.btn_changefestival);
            this.panel_festival.Controls.Add(this.btn_deletefestival);
            this.panel_festival.Controls.Add(this.label_festivalid);
            this.panel_festival.Controls.Add(this.label3);
            this.panel_festival.Controls.Add(this.datepicker_festivalend);
            this.panel_festival.Controls.Add(this.label2);
            this.panel_festival.Controls.Add(this.datepicker_festivalbegin);
            this.panel_festival.Controls.Add(this.btn_editfestival);
            this.panel_festival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_festival.Location = new System.Drawing.Point(0, 0);
            this.panel_festival.Name = "panel_festival";
            this.panel_festival.Size = new System.Drawing.Size(737, 542);
            this.panel_festival.TabIndex = 10;
            this.panel_festival.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_festival_Paint);
            // 
            // numericUpDown_ticketssold
            // 
            this.numericUpDown_ticketssold.Location = new System.Drawing.Point(355, 168);
            this.numericUpDown_ticketssold.Name = "numericUpDown_ticketssold";
            this.numericUpDown_ticketssold.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ticketssold.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(351, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Tickets";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label17.Location = new System.Drawing.Point(13, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Calendar";
            // 
            // comboBox_managertype
            // 
            this.comboBox_managertype.Enabled = false;
            this.comboBox_managertype.FormattingEnabled = true;
            this.comboBox_managertype.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.comboBox_managertype.Location = new System.Drawing.Point(527, 435);
            this.comboBox_managertype.Name = "comboBox_managertype";
            this.comboBox_managertype.Size = new System.Drawing.Size(121, 21);
            this.comboBox_managertype.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(524, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Type";
            // 
            // textBox_manageridnumber
            // 
            this.textBox_manageridnumber.Enabled = false;
            this.textBox_manageridnumber.Location = new System.Drawing.Point(355, 435);
            this.textBox_manageridnumber.Name = "textBox_manageridnumber";
            this.textBox_manageridnumber.Size = new System.Drawing.Size(142, 20);
            this.textBox_manageridnumber.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(352, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Personal ID number";
            // 
            // textBox_managertelephone
            // 
            this.textBox_managertelephone.Enabled = false;
            this.textBox_managertelephone.Location = new System.Drawing.Point(506, 371);
            this.textBox_managertelephone.Name = "textBox_managertelephone";
            this.textBox_managertelephone.Size = new System.Drawing.Size(142, 20);
            this.textBox_managertelephone.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(503, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Telephone";
            // 
            // comboBox_managersex
            // 
            this.comboBox_managersex.Enabled = false;
            this.comboBox_managersex.FormattingEnabled = true;
            this.comboBox_managersex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_managersex.Location = new System.Drawing.Point(355, 370);
            this.comboBox_managersex.Name = "comboBox_managersex";
            this.comboBox_managersex.Size = new System.Drawing.Size(121, 21);
            this.comboBox_managersex.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(352, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Sex";
            // 
            // textBox_manageremail
            // 
            this.textBox_manageremail.Enabled = false;
            this.textBox_manageremail.Location = new System.Drawing.Point(355, 321);
            this.textBox_manageremail.Name = "textBox_manageremail";
            this.textBox_manageremail.Size = new System.Drawing.Size(293, 20);
            this.textBox_manageremail.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(352, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Email";
            // 
            // textBox_managername
            // 
            this.textBox_managername.Enabled = false;
            this.textBox_managername.Location = new System.Drawing.Point(355, 271);
            this.textBox_managername.Name = "textBox_managername";
            this.textBox_managername.Size = new System.Drawing.Size(293, 20);
            this.textBox_managername.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(352, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(351, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Manager";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.comboBox1.Location = new System.Drawing.Point(191, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(188, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_promoteridnumber
            // 
            this.textBox_promoteridnumber.Enabled = false;
            this.textBox_promoteridnumber.Location = new System.Drawing.Point(19, 434);
            this.textBox_promoteridnumber.Name = "textBox_promoteridnumber";
            this.textBox_promoteridnumber.Size = new System.Drawing.Size(142, 20);
            this.textBox_promoteridnumber.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(16, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Personal ID number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox_promotertelephone
            // 
            this.textBox_promotertelephone.Enabled = false;
            this.textBox_promotertelephone.Location = new System.Drawing.Point(170, 372);
            this.textBox_promotertelephone.Name = "textBox_promotertelephone";
            this.textBox_promotertelephone.Size = new System.Drawing.Size(142, 20);
            this.textBox_promotertelephone.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(167, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_promotersex
            // 
            this.comboBox_promotersex.Enabled = false;
            this.comboBox_promotersex.FormattingEnabled = true;
            this.comboBox_promotersex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_promotersex.Location = new System.Drawing.Point(19, 371);
            this.comboBox_promotersex.Name = "comboBox_promotersex";
            this.comboBox_promotersex.Size = new System.Drawing.Size(121, 21);
            this.comboBox_promotersex.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sex";
            // 
            // textBox_promoteremail
            // 
            this.textBox_promoteremail.Enabled = false;
            this.textBox_promoteremail.Location = new System.Drawing.Point(19, 321);
            this.textBox_promoteremail.Name = "textBox_promoteremail";
            this.textBox_promoteremail.Size = new System.Drawing.Size(293, 20);
            this.textBox_promoteremail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_promotername
            // 
            this.textBox_promotername.Enabled = false;
            this.textBox_promotername.Location = new System.Drawing.Point(19, 271);
            this.textBox_promotername.Name = "textBox_promotername";
            this.textBox_promotername.Size = new System.Drawing.Size(293, 20);
            this.textBox_promotername.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // textBox_festivalname
            // 
            this.textBox_festivalname.Enabled = false;
            this.textBox_festivalname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_festivalname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.textBox_festivalname.Location = new System.Drawing.Point(17, 34);
            this.textBox_festivalname.Name = "textBox_festivalname";
            this.textBox_festivalname.Size = new System.Drawing.Size(708, 38);
            this.textBox_festivalname.TabIndex = 11;
            // 
            // label_promotername
            // 
            this.label_promotername.AutoSize = true;
            this.label_promotername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_promotername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label_promotername.Location = new System.Drawing.Point(13, 221);
            this.label_promotername.Name = "label_promotername";
            this.label_promotername.Size = new System.Drawing.Size(74, 20);
            this.label_promotername.TabIndex = 10;
            this.label_promotername.Text = "Promoter";
            // 
            // btn_changefestival
            // 
            this.btn_changefestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_changefestival.AutoSize = true;
            this.btn_changefestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_changefestival.FlatAppearance.BorderSize = 0;
            this.btn_changefestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changefestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changefestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_changefestival.Location = new System.Drawing.Point(17, 500);
            this.btn_changefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_changefestival.Name = "btn_changefestival";
            this.btn_changefestival.Size = new System.Drawing.Size(133, 30);
            this.btn_changefestival.TabIndex = 9;
            this.btn_changefestival.Text = "Change Festival";
            this.btn_changefestival.UseVisualStyleBackColor = true;
            // 
            // btn_deletefestival
            // 
            this.btn_deletefestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletefestival.AutoSize = true;
            this.btn_deletefestival.BackColor = System.Drawing.Color.Red;
            this.btn_deletefestival.FlatAppearance.BorderSize = 0;
            this.btn_deletefestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletefestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletefestival.ForeColor = System.Drawing.Color.White;
            this.btn_deletefestival.Location = new System.Drawing.Point(604, 500);
            this.btn_deletefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_deletefestival.Name = "btn_deletefestival";
            this.btn_deletefestival.Size = new System.Drawing.Size(124, 30);
            this.btn_deletefestival.TabIndex = 8;
            this.btn_deletefestival.Text = "Delete Festival";
            this.btn_deletefestival.UseVisualStyleBackColor = false;
            // 
            // label_festivalid
            // 
            this.label_festivalid.AutoSize = true;
            this.label_festivalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_festivalid.Location = new System.Drawing.Point(14, 75);
            this.label_festivalid.Name = "label_festivalid";
            this.label_festivalid.Size = new System.Drawing.Size(57, 13);
            this.label_festivalid.TabIndex = 5;
            this.label_festivalid.Text = "[festival id]";
            this.label_festivalid.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(176, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datepicker_festivalend
            // 
            this.datepicker_festivalend.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_festivalend.Enabled = false;
            this.datepicker_festivalend.Location = new System.Drawing.Point(179, 168);
            this.datepicker_festivalend.Name = "datepicker_festivalend";
            this.datepicker_festivalend.Size = new System.Drawing.Size(133, 20);
            this.datepicker_festivalend.TabIndex = 3;
            this.datepicker_festivalend.ValueChanged += new System.EventHandler(this.datepicker_festivalend_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // datepicker_festivalbegin
            // 
            this.datepicker_festivalbegin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_festivalbegin.Enabled = false;
            this.datepicker_festivalbegin.Location = new System.Drawing.Point(17, 167);
            this.datepicker_festivalbegin.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.datepicker_festivalbegin.Name = "datepicker_festivalbegin";
            this.datepicker_festivalbegin.Size = new System.Drawing.Size(133, 20);
            this.datepicker_festivalbegin.TabIndex = 1;
            this.datepicker_festivalbegin.ValueChanged += new System.EventHandler(this.datepicker_festivalbegining_ValueChanged);
            // 
            // btn_editfestival
            // 
            this.btn_editfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editfestival.AutoSize = true;
            this.btn_editfestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_editfestival.FlatAppearance.BorderSize = 0;
            this.btn_editfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_editfestival.Location = new System.Drawing.Point(170, 500);
            this.btn_editfestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_editfestival.Name = "btn_editfestival";
            this.btn_editfestival.Size = new System.Drawing.Size(111, 30);
            this.btn_editfestival.TabIndex = 7;
            this.btn_editfestival.Text = "Edit";
            this.btn_editfestival.UseVisualStyleBackColor = true;
            this.btn_editfestival.Click += new System.EventHandler(this.btn_editfestival_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Festivals";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_addfestival
            // 
            this.btn_addfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addfestival.AutoSize = true;
            this.btn_addfestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_addfestival.FlatAppearance.BorderSize = 0;
            this.btn_addfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_addfestival.Location = new System.Drawing.Point(543, 423);
            this.btn_addfestival.Name = "btn_addfestival";
            this.btn_addfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_addfestival.TabIndex = 8;
            this.btn_addfestival.Text = "Add Festival";
            this.btn_addfestival.UseVisualStyleBackColor = true;
            this.btn_addfestival.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btn_openfestival
            // 
            this.btn_openfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openfestival.AutoSize = true;
            this.btn_openfestival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.btn_openfestival.Enabled = false;
            this.btn_openfestival.FlatAppearance.BorderSize = 0;
            this.btn_openfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_openfestival.Location = new System.Drawing.Point(355, 423);
            this.btn_openfestival.Name = "btn_openfestival";
            this.btn_openfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_openfestival.TabIndex = 7;
            this.btn_openfestival.Text = "Open Festival";
            this.btn_openfestival.UseVisualStyleBackColor = true;
            this.btn_openfestival.Click += new System.EventHandler(this.btn_openfestival_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(352, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total of tickets sold";
            // 
            // PlanFest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 542);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.form_login);
            this.Name = "PlanFest";
            this.Text = "PlanFest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.server.ResumeLayout(false);
            this.server.PerformLayout();
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            this.password.ResumeLayout(false);
            this.password.PerformLayout();
            this.form_login.ResumeLayout(false);
            this.form_login.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            this.panel_festivalslist.ResumeLayout(false);
            this.panel_festivalslist.PerformLayout();
            this.panel_festival.ResumeLayout(false);
            this.panel_festival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_input;
        private System.Windows.Forms.Label server_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel server;
        private System.Windows.Forms.FlowLayoutPanel user;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.FlowLayoutPanel password;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.FlowLayoutPanel form_login;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_festivals;
        private System.Windows.Forms.Button btn_concerts;
        private System.Windows.Forms.Button btn_stages;
        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.Button btn_bands;
        private System.Windows.Forms.Button btn_meals;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Panel panel_festivalslist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_openfestival;
        private System.Windows.Forms.Button btn_addfestival;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_festival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepicker_festivalbegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepicker_festivalend;
        private System.Windows.Forms.Label label_festivalid;
        private System.Windows.Forms.Button btn_deletefestival;
        private System.Windows.Forms.Button btn_editfestival;
        private System.Windows.Forms.TextBox textBox_festivalname;
        private System.Windows.Forms.Label label_promotername;
        private System.Windows.Forms.Button btn_changefestival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_promoteremail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_promotername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_promotersex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_managertype;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_manageridnumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_managertelephone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_managersex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_manageremail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_managername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_promoteridnumber;
        private System.Windows.Forms.TextBox textBox_promotertelephone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown_ticketssold;
        private System.Windows.Forms.Label label19;
    }
}

