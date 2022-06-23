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
            this.panel_festival = new System.Windows.Forms.Panel();
            this.manager_type = new System.Windows.Forms.ComboBox();
            this.promoter_type = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datepicker_proposal = new System.Windows.Forms.DateTimePicker();
            this.textBox_manager_cc = new System.Windows.Forms.TextBox();
            this.textBox_promoter_cc = new System.Windows.Forms.TextBox();
            this.manager_sex = new System.Windows.Forms.Label();
            this.manager_phone = new System.Windows.Forms.Label();
            this.manager_email = new System.Windows.Forms.Label();
            this.manager_name = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.promoter_sex = new System.Windows.Forms.Label();
            this.promoter_phone = new System.Windows.Forms.Label();
            this.promoter_email = new System.Windows.Forms.Label();
            this.promoter_name = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown_ticketssold = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel_openinglist = new System.Windows.Forms.Panel();
            this.gridview_festivals = new System.Windows.Forms.DataGridView();
            this.gridview_festivalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_datebegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_ndays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promotername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promoteremail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promoterphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_bandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_openfestival = new System.Windows.Forms.Button();
            this.btn_addfestival = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.server.SuspendLayout();
            this.user.SuspendLayout();
            this.password.SuspendLayout();
            this.form_login.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_base.SuspendLayout();
            this.panel_festival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).BeginInit();
            this.panel_openinglist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_festivals)).BeginInit();
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
            this.btn_concerts.Click += new System.EventHandler(this.btn_concerts_Click);
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
            this.btn_stages.Click += new System.EventHandler(this.btn_stages_Click);
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
            this.btn_bands.Click += new System.EventHandler(this.btn_bands_Click);
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
            this.btn_meals.Click += new System.EventHandler(this.btn_meals_Click);
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
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.menu);
            this.panel_base.Controls.Add(this.panel_festival);
            this.panel_base.Controls.Add(this.panel_openinglist);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(910, 542);
            this.panel_base.TabIndex = 7;
            // 
            // panel_festival
            // 
            this.panel_festival.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_festival.Controls.Add(this.manager_type);
            this.panel_festival.Controls.Add(this.promoter_type);
            this.panel_festival.Controls.Add(this.label11);
            this.panel_festival.Controls.Add(this.datepicker_proposal);
            this.panel_festival.Controls.Add(this.textBox_manager_cc);
            this.panel_festival.Controls.Add(this.textBox_promoter_cc);
            this.panel_festival.Controls.Add(this.manager_sex);
            this.panel_festival.Controls.Add(this.manager_phone);
            this.panel_festival.Controls.Add(this.manager_email);
            this.panel_festival.Controls.Add(this.manager_name);
            this.panel_festival.Controls.Add(this.label20);
            this.panel_festival.Controls.Add(this.label21);
            this.panel_festival.Controls.Add(this.label22);
            this.panel_festival.Controls.Add(this.label23);
            this.panel_festival.Controls.Add(this.label24);
            this.panel_festival.Controls.Add(this.label25);
            this.panel_festival.Controls.Add(this.promoter_sex);
            this.panel_festival.Controls.Add(this.promoter_phone);
            this.panel_festival.Controls.Add(this.promoter_email);
            this.panel_festival.Controls.Add(this.promoter_name);
            this.panel_festival.Controls.Add(this.label19);
            this.panel_festival.Controls.Add(this.numericUpDown_ticketssold);
            this.panel_festival.Controls.Add(this.label18);
            this.panel_festival.Controls.Add(this.label17);
            this.panel_festival.Controls.Add(this.label10);
            this.panel_festival.Controls.Add(this.label9);
            this.panel_festival.Controls.Add(this.label8);
            this.panel_festival.Controls.Add(this.label7);
            this.panel_festival.Controls.Add(this.label6);
            this.panel_festival.Controls.Add(this.label5);
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
            this.panel_festival.Location = new System.Drawing.Point(176, 3);
            this.panel_festival.Name = "panel_festival";
            this.panel_festival.Size = new System.Drawing.Size(731, 539);
            this.panel_festival.TabIndex = 10;
            this.panel_festival.UseWaitCursor = true;
            // 
            // manager_type
            // 
            this.manager_type.Enabled = false;
            this.manager_type.FormattingEnabled = true;
            this.manager_type.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.manager_type.Location = new System.Drawing.Point(405, 318);
            this.manager_type.Name = "manager_type";
            this.manager_type.Size = new System.Drawing.Size(158, 21);
            this.manager_type.TabIndex = 66;
            this.manager_type.UseWaitCursor = true;
            // 
            // promoter_type
            // 
            this.promoter_type.Enabled = false;
            this.promoter_type.FormattingEnabled = true;
            this.promoter_type.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.promoter_type.Location = new System.Drawing.Point(51, 318);
            this.promoter_type.Name = "promoter_type";
            this.promoter_type.Size = new System.Drawing.Size(158, 21);
            this.promoter_type.TabIndex = 65;
            this.promoter_type.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(335, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Proposal Date";
            this.label11.UseWaitCursor = true;
            // 
            // datepicker_proposal
            // 
            this.datepicker_proposal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_proposal.Enabled = false;
            this.datepicker_proposal.Location = new System.Drawing.Point(338, 168);
            this.datepicker_proposal.Name = "datepicker_proposal";
            this.datepicker_proposal.Size = new System.Drawing.Size(133, 20);
            this.datepicker_proposal.TabIndex = 61;
            this.datepicker_proposal.UseWaitCursor = true;
            // 
            // textBox_manager_cc
            // 
            this.textBox_manager_cc.Enabled = false;
            this.textBox_manager_cc.Location = new System.Drawing.Point(461, 372);
            this.textBox_manager_cc.Name = "textBox_manager_cc";
            this.textBox_manager_cc.Size = new System.Drawing.Size(158, 20);
            this.textBox_manager_cc.TabIndex = 60;
            this.textBox_manager_cc.UseWaitCursor = true;
            // 
            // textBox_promoter_cc
            // 
            this.textBox_promoter_cc.Enabled = false;
            this.textBox_promoter_cc.Location = new System.Drawing.Point(123, 372);
            this.textBox_promoter_cc.Name = "textBox_promoter_cc";
            this.textBox_promoter_cc.Size = new System.Drawing.Size(158, 20);
            this.textBox_promoter_cc.TabIndex = 59;
            this.textBox_promoter_cc.UseWaitCursor = true;
            // 
            // manager_sex
            // 
            this.manager_sex.AutoSize = true;
            this.manager_sex.Enabled = false;
            this.manager_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_sex.Location = new System.Drawing.Point(386, 347);
            this.manager_sex.Name = "manager_sex";
            this.manager_sex.Size = new System.Drawing.Size(70, 13);
            this.manager_sex.TabIndex = 58;
            this.manager_sex.Text = "manager_sex";
            this.manager_sex.UseWaitCursor = true;
            // 
            // manager_phone
            // 
            this.manager_phone.AutoSize = true;
            this.manager_phone.Enabled = false;
            this.manager_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_phone.Location = new System.Drawing.Point(419, 300);
            this.manager_phone.Name = "manager_phone";
            this.manager_phone.Size = new System.Drawing.Size(84, 13);
            this.manager_phone.TabIndex = 55;
            this.manager_phone.Text = "manager_phone";
            this.manager_phone.UseWaitCursor = true;
            // 
            // manager_email
            // 
            this.manager_email.AutoSize = true;
            this.manager_email.Enabled = false;
            this.manager_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_email.Location = new System.Drawing.Point(393, 278);
            this.manager_email.Name = "manager_email";
            this.manager_email.Size = new System.Drawing.Size(78, 13);
            this.manager_email.TabIndex = 54;
            this.manager_email.Text = "manager_email";
            this.manager_email.UseWaitCursor = true;
            // 
            // manager_name
            // 
            this.manager_name.AutoSize = true;
            this.manager_name.Enabled = false;
            this.manager_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_name.Location = new System.Drawing.Point(396, 257);
            this.manager_name.Name = "manager_name";
            this.manager_name.Size = new System.Drawing.Size(80, 13);
            this.manager_name.TabIndex = 53;
            this.manager_name.Text = "manager_name";
            this.manager_name.UseWaitCursor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(355, 321);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Type";
            this.label20.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(355, 375);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Personal ID number";
            this.label21.UseWaitCursor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(355, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "Telephone";
            this.label22.UseWaitCursor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(355, 347);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Sex";
            this.label23.UseWaitCursor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(355, 278);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Email";
            this.label24.UseWaitCursor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(355, 257);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Name";
            this.label25.UseWaitCursor = true;
            // 
            // promoter_sex
            // 
            this.promoter_sex.AutoSize = true;
            this.promoter_sex.Enabled = false;
            this.promoter_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_sex.Location = new System.Drawing.Point(48, 347);
            this.promoter_sex.Name = "promoter_sex";
            this.promoter_sex.Size = new System.Drawing.Size(70, 13);
            this.promoter_sex.TabIndex = 46;
            this.promoter_sex.Text = "promoter_sex";
            this.promoter_sex.UseWaitCursor = true;
            // 
            // promoter_phone
            // 
            this.promoter_phone.AutoSize = true;
            this.promoter_phone.Enabled = false;
            this.promoter_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_phone.Location = new System.Drawing.Point(78, 300);
            this.promoter_phone.Name = "promoter_phone";
            this.promoter_phone.Size = new System.Drawing.Size(84, 13);
            this.promoter_phone.TabIndex = 43;
            this.promoter_phone.Text = "promoter_phone";
            this.promoter_phone.UseWaitCursor = true;
            // 
            // promoter_email
            // 
            this.promoter_email.AutoSize = true;
            this.promoter_email.Enabled = false;
            this.promoter_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_email.Location = new System.Drawing.Point(52, 278);
            this.promoter_email.Name = "promoter_email";
            this.promoter_email.Size = new System.Drawing.Size(78, 13);
            this.promoter_email.TabIndex = 42;
            this.promoter_email.Text = "promoter_email";
            this.promoter_email.UseWaitCursor = true;
            // 
            // promoter_name
            // 
            this.promoter_name.AutoSize = true;
            this.promoter_name.Enabled = false;
            this.promoter_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_name.Location = new System.Drawing.Point(55, 257);
            this.promoter_name.Name = "promoter_name";
            this.promoter_name.Size = new System.Drawing.Size(80, 13);
            this.promoter_name.TabIndex = 41;
            this.promoter_name.Text = "promoter_name";
            this.promoter_name.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(496, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total of tickets sold";
            this.label19.UseWaitCursor = true;
            // 
            // numericUpDown_ticketssold
            // 
            this.numericUpDown_ticketssold.Enabled = false;
            this.numericUpDown_ticketssold.Location = new System.Drawing.Point(499, 167);
            this.numericUpDown_ticketssold.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_ticketssold.Name = "numericUpDown_ticketssold";
            this.numericUpDown_ticketssold.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ticketssold.TabIndex = 39;
            this.numericUpDown_ticketssold.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(495, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Tickets";
            this.label18.UseWaitCursor = true;
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
            this.label17.UseWaitCursor = true;
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
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(14, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Personal ID number";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(17, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sex";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            this.label4.UseWaitCursor = true;
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
            this.textBox_festivalname.UseWaitCursor = true;
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
            this.label_promotername.UseWaitCursor = true;
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
            this.btn_changefestival.Location = new System.Drawing.Point(17, 491);
            this.btn_changefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_changefestival.Name = "btn_changefestival";
            this.btn_changefestival.Size = new System.Drawing.Size(133, 30);
            this.btn_changefestival.TabIndex = 9;
            this.btn_changefestival.Text = "Change Festival";
            this.btn_changefestival.UseVisualStyleBackColor = true;
            this.btn_changefestival.UseWaitCursor = true;
            this.btn_changefestival.Click += new System.EventHandler(this.btn_changefestival_Click);
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
            this.btn_deletefestival.Location = new System.Drawing.Point(601, 497);
            this.btn_deletefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_deletefestival.Name = "btn_deletefestival";
            this.btn_deletefestival.Size = new System.Drawing.Size(124, 30);
            this.btn_deletefestival.TabIndex = 8;
            this.btn_deletefestival.Text = "Delete Festival";
            this.btn_deletefestival.UseVisualStyleBackColor = false;
            this.btn_deletefestival.UseWaitCursor = true;
            this.btn_deletefestival.Click += new System.EventHandler(this.btn_deletefestival_Click);
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
            this.label_festivalid.UseWaitCursor = true;
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
            this.label3.UseWaitCursor = true;
            // 
            // datepicker_festivalend
            // 
            this.datepicker_festivalend.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_festivalend.Enabled = false;
            this.datepicker_festivalend.Location = new System.Drawing.Point(179, 168);
            this.datepicker_festivalend.Name = "datepicker_festivalend";
            this.datepicker_festivalend.Size = new System.Drawing.Size(133, 20);
            this.datepicker_festivalend.TabIndex = 3;
            this.datepicker_festivalend.UseWaitCursor = true;
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
            this.label2.UseWaitCursor = true;
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
            this.datepicker_festivalbegin.UseWaitCursor = true;
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
            this.btn_editfestival.Location = new System.Drawing.Point(170, 491);
            this.btn_editfestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_editfestival.Name = "btn_editfestival";
            this.btn_editfestival.Size = new System.Drawing.Size(111, 30);
            this.btn_editfestival.TabIndex = 7;
            this.btn_editfestival.Text = "Edit";
            this.btn_editfestival.UseVisualStyleBackColor = true;
            this.btn_editfestival.UseWaitCursor = true;
            this.btn_editfestival.Click += new System.EventHandler(this.btn_editfestival_Click);
            // 
            // panel_openinglist
            // 
            this.panel_openinglist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_openinglist.Controls.Add(this.gridview_festivals);
            this.panel_openinglist.Controls.Add(this.btn_openfestival);
            this.panel_openinglist.Controls.Add(this.btn_addfestival);
            this.panel_openinglist.Controls.Add(this.label1);
            this.panel_openinglist.Location = new System.Drawing.Point(176, 0);
            this.panel_openinglist.Name = "panel_openinglist";
            this.panel_openinglist.Size = new System.Drawing.Size(734, 542);
            this.panel_openinglist.TabIndex = 41;
            // 
            // gridview_festivals
            // 
            this.gridview_festivals.AllowUserToAddRows = false;
            this.gridview_festivals.AllowUserToDeleteRows = false;
            this.gridview_festivals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_festivals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.gridview_festivals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridview_festivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_festivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridview_festivalid,
            this.gridview_name,
            this.gridview_datebegin,
            this.gridview_ndays,
            this.gridview_promotername,
            this.gridview_promoteremail,
            this.gridview_promoterphone,
            this.gridview_bandname});
            this.gridview_festivals.Location = new System.Drawing.Point(17, 91);
            this.gridview_festivals.Name = "gridview_festivals";
            this.gridview_festivals.ReadOnly = true;
            this.gridview_festivals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_festivals.Size = new System.Drawing.Size(705, 309);
            this.gridview_festivals.TabIndex = 10;
            this.gridview_festivals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_festivals_SelectChange);
            // 
            // gridview_festivalid
            // 
            this.gridview_festivalid.HeaderText = "Festival ID";
            this.gridview_festivalid.Name = "gridview_festivalid";
            this.gridview_festivalid.ReadOnly = true;
            this.gridview_festivalid.Visible = false;
            // 
            // gridview_name
            // 
            this.gridview_name.HeaderText = "Name";
            this.gridview_name.Name = "gridview_name";
            this.gridview_name.ReadOnly = true;
            // 
            // gridview_datebegin
            // 
            this.gridview_datebegin.HeaderText = "Date Beginning";
            this.gridview_datebegin.Name = "gridview_datebegin";
            this.gridview_datebegin.ReadOnly = true;
            // 
            // gridview_ndays
            // 
            this.gridview_ndays.HeaderText = "Number of Days";
            this.gridview_ndays.Name = "gridview_ndays";
            this.gridview_ndays.ReadOnly = true;
            // 
            // gridview_promotername
            // 
            this.gridview_promotername.HeaderText = "Promoter Name";
            this.gridview_promotername.Name = "gridview_promotername";
            this.gridview_promotername.ReadOnly = true;
            // 
            // gridview_promoteremail
            // 
            this.gridview_promoteremail.HeaderText = "Promoter Email";
            this.gridview_promoteremail.Name = "gridview_promoteremail";
            this.gridview_promoteremail.ReadOnly = true;
            // 
            // gridview_promoterphone
            // 
            this.gridview_promoterphone.HeaderText = "Promoter Phone Number";
            this.gridview_promoterphone.Name = "gridview_promoterphone";
            this.gridview_promoterphone.ReadOnly = true;
            // 
            // gridview_bandname
            // 
            this.gridview_bandname.HeaderText = "Band Name";
            this.gridview_bandname.Name = "gridview_bandname";
            this.gridview_bandname.ReadOnly = true;
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
            this.btn_openfestival.Location = new System.Drawing.Point(358, 501);
            this.btn_openfestival.Name = "btn_openfestival";
            this.btn_openfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_openfestival.TabIndex = 7;
            this.btn_openfestival.Text = "Open Festival";
            this.btn_openfestival.UseVisualStyleBackColor = true;
            this.btn_openfestival.Click += new System.EventHandler(this.btn_openfestival_Click);
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
            this.btn_addfestival.Location = new System.Drawing.Point(546, 501);
            this.btn_addfestival.Name = "btn_addfestival";
            this.btn_addfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_addfestival.TabIndex = 8;
            this.btn_addfestival.Text = "Add Festival";
            this.btn_addfestival.UseVisualStyleBackColor = true;
            this.btn_addfestival.Click += new System.EventHandler(this.btn_addfestival_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Festivals";
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
            this.panel_festival.ResumeLayout(false);
            this.panel_festival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).EndInit();
            this.panel_openinglist.ResumeLayout(false);
            this.panel_openinglist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_festivals)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel_openinglist;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDown_ticketssold;
        private System.Windows.Forms.Label promoter_email;
        private System.Windows.Forms.Label promoter_name;
        private System.Windows.Forms.Label promoter_phone;
        private System.Windows.Forms.TextBox textBox_manager_cc;
        private System.Windows.Forms.TextBox textBox_promoter_cc;
        private System.Windows.Forms.Label manager_sex;
        private System.Windows.Forms.Label manager_phone;
        private System.Windows.Forms.Label manager_email;
        private System.Windows.Forms.Label manager_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label promoter_sex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datepicker_proposal;
        private System.Windows.Forms.DataGridView gridview_festivals;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_festivalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_datebegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_ndays;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promotername;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promoteremail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promoterphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_bandname;
        private System.Windows.Forms.ComboBox manager_type;
        private System.Windows.Forms.ComboBox promoter_type;
    }
}

