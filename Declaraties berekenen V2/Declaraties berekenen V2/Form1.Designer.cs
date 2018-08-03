namespace Declaraties_berekenen_V2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_database = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.homeUserControl1 = new Declaraties_berekenen_V2.HomeUserControl();
            this.addUserControl1 = new Declaraties_berekenen_V2.AddUserControl();
            this.panel_navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.Black;
            this.panel_navigation.Controls.Add(this.sidePanel);
            this.panel_navigation.Controls.Add(this.btn_settings);
            this.panel_navigation.Controls.Add(this.btn_database);
            this.panel_navigation.Controls.Add(this.btn_add);
            this.panel_navigation.Controls.Add(this.btn_home);
            this.panel_navigation.Location = new System.Drawing.Point(-3, -1);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(270, 1076);
            this.panel_navigation.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidePanel.Location = new System.Drawing.Point(3, 124);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(12, 90);
            this.sidePanel.TabIndex = 5;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Black;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(15, 412);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(220, 90);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "       Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_database
            // 
            this.btn_database.BackColor = System.Drawing.Color.Black;
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_database.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_database.Image = ((System.Drawing.Image)(resources.GetObject("btn_database.Image")));
            this.btn_database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_database.Location = new System.Drawing.Point(15, 316);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(220, 90);
            this.btn_database.TabIndex = 2;
            this.btn_database.Text = "          Database";
            this.btn_database.UseVisualStyleBackColor = false;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(15, 220);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 90);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "  Add ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Black;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(15, 124);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(220, 90);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "    Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.ForeColor = System.Drawing.Color.Black;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1904, 117);
            this.panel_top.TabIndex = 1;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.ImageLocation = "downy fox.png";
            this.pb_logo.InitialImage = null;
            this.pb_logo.Location = new System.Drawing.Point(385, 0);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(118, 117);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(273, 123);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1600, 900);
            this.homeUserControl1.TabIndex = 3;
            this.homeUserControl1.Load += new System.EventHandler(this.homeUserControl1_Load);
            // 
            // addUserControl1
            // 
            this.addUserControl1.Location = new System.Drawing.Point(273, 123);
            this.addUserControl1.Name = "addUserControl1";
            this.addUserControl1.Size = new System.Drawing.Size(831, 625);
            this.addUserControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.panel_navigation);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.addUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Declaraties berekenen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_navigation;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_database;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pb_logo;
        private HomeUserControl homeUserControl1;
        private System.Windows.Forms.Panel sidePanel;
        private AddUserControl addUserControl1;
    }
}

