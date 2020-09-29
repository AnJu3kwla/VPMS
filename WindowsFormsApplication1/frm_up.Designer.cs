namespace WindowsFormsApplication1
{
    partial class frm_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_up));
            this.lblnme = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lblmil = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UId = new System.Windows.Forms.Label();
            this.text_UId = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUType = new System.Windows.Forms.TextBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnme
            // 
            this.lblnme.AutoSize = true;
            this.lblnme.BackColor = System.Drawing.Color.Transparent;
            this.lblnme.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblnme.ForeColor = System.Drawing.Color.Black;
            this.lblnme.Location = new System.Drawing.Point(104, 193);
            this.lblnme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnme.Name = "lblnme";
            this.lblnme.Size = new System.Drawing.Size(52, 21);
            this.lblnme.TabIndex = 1;
            this.lblnme.Text = "Name\r\n";
            this.lblnme.Click += new System.EventHandler(this.lblnme_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_name.Location = new System.Drawing.Point(250, 176);
            this.txt_name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(203, 38);
            this.txt_name.TabIndex = 2;
            // 
            // lblmil
            // 
            this.lblmil.AutoSize = true;
            this.lblmil.BackColor = System.Drawing.Color.Transparent;
            this.lblmil.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblmil.ForeColor = System.Drawing.Color.Black;
            this.lblmil.Location = new System.Drawing.Point(104, 444);
            this.lblmil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmil.Name = "lblmil";
            this.lblmil.Size = new System.Drawing.Size(54, 21);
            this.lblmil.TabIndex = 3;
            this.lblmil.Text = "E-mail";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.BackColor = System.Drawing.Color.Transparent;
            this.lblnic.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblnic.ForeColor = System.Drawing.Color.Black;
            this.lblnic.Location = new System.Drawing.Point(104, 396);
            this.lblnic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(36, 21);
            this.lblnic.TabIndex = 4;
            this.lblnic.Text = "NIC";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.BackColor = System.Drawing.Color.Transparent;
            this.lbladd.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbladd.ForeColor = System.Drawing.Color.Black;
            this.lbladd.Location = new System.Drawing.Point(104, 345);
            this.lbladd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(66, 21);
            this.lbladd.TabIndex = 5;
            this.lbladd.Text = "Address";
            // 
            // txt_mobile
            // 
            this.txt_mobile.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mobile.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_mobile.Location = new System.Drawing.Point(250, 276);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(0);
            this.txt_mobile.Multiline = true;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(203, 38);
            this.txt_mobile.TabIndex = 7;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            // 
            // txt_add
            // 
            this.txt_add.BackColor = System.Drawing.SystemColors.Window;
            this.txt_add.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_add.Location = new System.Drawing.Point(250, 328);
            this.txt_add.Margin = new System.Windows.Forms.Padding(0);
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(203, 38);
            this.txt_add.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // txt_nic
            // 
            this.txt_nic.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_nic.Location = new System.Drawing.Point(250, 379);
            this.txt_nic.Margin = new System.Windows.Forms.Padding(0);
            this.txt_nic.Multiline = true;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(203, 38);
            this.txt_nic.TabIndex = 11;
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_mail.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_mail.Location = new System.Drawing.Point(250, 427);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(0);
            this.txt_mail.Multiline = true;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(203, 38);
            this.txt_mail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Contact no";
            // 
            // dob
            // 
            this.dob.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.dob.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(240)))), ((int)(((byte)(227)))));
            this.dob.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dob.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(250, 234);
            this.dob.Margin = new System.Windows.Forms.Padding(0);
            this.dob.Name = "dob";
            this.dob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dob.Size = new System.Drawing.Size(203, 29);
            this.dob.TabIndex = 15;
            this.dob.Value = new System.DateTime(2018, 8, 4, 22, 21, 16, 0);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(108, 604);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(144, 47);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pass.DataBindings.Add(new System.Windows.Forms.Binding("PasswordChar", global::WindowsFormsApplication1.Properties.Settings.Default, "pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_pass.Location = new System.Drawing.Point(250, 477);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(0);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = global::WindowsFormsApplication1.Properties.Settings.Default.pass;
            this.txt_pass.Size = new System.Drawing.Size(203, 38);
            this.txt_pass.TabIndex = 14;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(95, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "|  Sign Up";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UId
            // 
            this.lbl_UId.AutoSize = true;
            this.lbl_UId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UId.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_UId.ForeColor = System.Drawing.Color.Black;
            this.lbl_UId.Location = new System.Drawing.Point(104, 142);
            this.lbl_UId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UId.Name = "lbl_UId";
            this.lbl_UId.Size = new System.Drawing.Size(59, 21);
            this.lbl_UId.TabIndex = 1;
            this.lbl_UId.Text = "User Id";
            this.lbl_UId.Click += new System.EventHandler(this.lblnme_Click);
            // 
            // text_UId
            // 
            this.text_UId.BackColor = System.Drawing.SystemColors.Window;
            this.text_UId.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.text_UId.Location = new System.Drawing.Point(250, 125);
            this.text_UId.Margin = new System.Windows.Forms.Padding(0);
            this.text_UId.Multiline = true;
            this.text_UId.Name = "text_UId";
            this.text_UId.Size = new System.Drawing.Size(203, 38);
            this.text_UId.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(309, 604);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(144, 47);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(250, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 61);
            this.panel1.TabIndex = 24;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightGray;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(537, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(39, 34);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 631);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(104, 554);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Type";
            // 
            // textBoxUType
            // 
            this.textBoxUType.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUType.DataBindings.Add(new System.Windows.Forms.Binding("PasswordChar", global::WindowsFormsApplication1.Properties.Settings.Default, "pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUType.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.textBoxUType.Location = new System.Drawing.Point(250, 537);
            this.textBoxUType.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUType.Multiline = true;
            this.textBoxUType.Name = "textBoxUType";
            this.textBoxUType.PasswordChar = global::WindowsFormsApplication1.Properties.Settings.Default.pass;
            this.textBoxUType.Size = new System.Drawing.Size(203, 38);
            this.textBoxUType.TabIndex = 14;
            this.textBoxUType.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.textBoxUType.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Silver;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(462, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(39, 34);
            this.btnMin.TabIndex = 28;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Silver;
            this.btnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMax.BackgroundImage")));
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(498, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 34);
            this.btnMax.TabIndex = 27;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // frm_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 692);
            this.ControlBox = false;
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.textBoxUType);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblnic);
            this.Controls.Add(this.lblmil);
            this.Controls.Add(this.text_UId);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_UId);
            this.Controls.Add(this.lblnme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_up";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblnme;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lblmil;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_UId;
        private System.Windows.Forms.TextBox text_UId;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUType;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
    }
}