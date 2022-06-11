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
            this.panel_openfestival = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.panel_openfestival.SuspendLayout();
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
            this.user_label.Click += new System.EventHandler(this.label2_Click);
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
            this.panel_base.Controls.Add(this.panel_openfestival);
            this.panel_base.Controls.Add(this.menu);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(910, 542);
            this.panel_base.TabIndex = 7;
            this.panel_base.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_home_Paint);
            // 
            // panel_openfestival
            // 
            this.panel_openfestival.Controls.Add(this.label1);
            this.panel_openfestival.Controls.Add(this.btn_addfestival);
            this.panel_openfestival.Controls.Add(this.listBox1);
            this.panel_openfestival.Controls.Add(this.btn_openfestival);
            this.panel_openfestival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_openfestival.Location = new System.Drawing.Point(173, 0);
            this.panel_openfestival.Name = "panel_openfestival";
            this.panel_openfestival.Size = new System.Drawing.Size(737, 542);
            this.panel_openfestival.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 286);
            this.listBox1.TabIndex = 0;
            // 
            // btn_openfestival
            // 
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
            // btn_addfestival
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Festivals";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            this.panel_openfestival.ResumeLayout(false);
            this.panel_openfestival.PerformLayout();
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
        private System.Windows.Forms.Panel panel_openfestival;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_openfestival;
        private System.Windows.Forms.Button btn_addfestival;
        private System.Windows.Forms.Label label1;
    }
}

