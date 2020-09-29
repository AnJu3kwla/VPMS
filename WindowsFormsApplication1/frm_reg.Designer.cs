namespace WindowsFormsApplication1
{
    partial class frm_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reg));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cust_Name = new System.Windows.Forms.TextBox();
            this.txt_Cust_Cont = new System.Windows.Forms.TextBox();
            this.txt_Cust_Add = new System.Windows.Forms.TextBox();
            this.txt_Cust_Nic = new System.Windows.Forms.TextBox();
            this.txt_Cust_Email = new System.Windows.Forms.TextBox();
            this.txt_Cust_Vectype = new System.Windows.Forms.TextBox();
            this.txt_Cust_Vecnum = new System.Windows.Forms.TextBox();
            this.btn_Cust_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.db_cust = new System.Windows.Forms.DataGridView();
            this.lbl_CId = new System.Windows.Forms.Label();
            this.txt_Cust_Id = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label1.Location = new System.Drawing.Point(60, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label3.Location = new System.Drawing.Point(60, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label4.Location = new System.Drawing.Point(60, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label5.Location = new System.Drawing.Point(60, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label6.Location = new System.Drawing.Point(60, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label2.Location = new System.Drawing.Point(60, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vehicle Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label7.Location = new System.Drawing.Point(60, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Vehicle Number";
            // 
            // txt_Cust_Name
            // 
            this.txt_Cust_Name.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Name.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Name.Location = new System.Drawing.Point(190, 208);
            this.txt_Cust_Name.Multiline = true;
            this.txt_Cust_Name.Name = "txt_Cust_Name";
            this.txt_Cust_Name.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Name.TabIndex = 9;
            // 
            // txt_Cust_Cont
            // 
            this.txt_Cust_Cont.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Cont.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Cont.Location = new System.Drawing.Point(190, 265);
            this.txt_Cust_Cont.Multiline = true;
            this.txt_Cust_Cont.Name = "txt_Cust_Cont";
            this.txt_Cust_Cont.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Cont.TabIndex = 10;
            // 
            // txt_Cust_Add
            // 
            this.txt_Cust_Add.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Add.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Add.Location = new System.Drawing.Point(190, 315);
            this.txt_Cust_Add.Multiline = true;
            this.txt_Cust_Add.Name = "txt_Cust_Add";
            this.txt_Cust_Add.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Add.TabIndex = 11;
            // 
            // txt_Cust_Nic
            // 
            this.txt_Cust_Nic.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Nic.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Nic.Location = new System.Drawing.Point(190, 367);
            this.txt_Cust_Nic.Multiline = true;
            this.txt_Cust_Nic.Name = "txt_Cust_Nic";
            this.txt_Cust_Nic.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Nic.TabIndex = 12;
            // 
            // txt_Cust_Email
            // 
            this.txt_Cust_Email.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Email.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Email.Location = new System.Drawing.Point(190, 419);
            this.txt_Cust_Email.Multiline = true;
            this.txt_Cust_Email.Name = "txt_Cust_Email";
            this.txt_Cust_Email.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Email.TabIndex = 13;
            // 
            // txt_Cust_Vectype
            // 
            this.txt_Cust_Vectype.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Vectype.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Vectype.Location = new System.Drawing.Point(190, 472);
            this.txt_Cust_Vectype.Multiline = true;
            this.txt_Cust_Vectype.Name = "txt_Cust_Vectype";
            this.txt_Cust_Vectype.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Vectype.TabIndex = 14;
            // 
            // txt_Cust_Vecnum
            // 
            this.txt_Cust_Vecnum.BackColor = System.Drawing.Color.White;
            this.txt_Cust_Vecnum.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Vecnum.Location = new System.Drawing.Point(190, 527);
            this.txt_Cust_Vecnum.Multiline = true;
            this.txt_Cust_Vecnum.Name = "txt_Cust_Vecnum";
            this.txt_Cust_Vecnum.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Vecnum.TabIndex = 15;
            // 
            // btn_Cust_Save
            // 
            this.btn_Cust_Save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Cust_Save.FlatAppearance.BorderSize = 0;
            this.btn_Cust_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cust_Save.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btn_Cust_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Cust_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cust_Save.Location = new System.Drawing.Point(458, 582);
            this.btn_Cust_Save.Name = "btn_Cust_Save";
            this.btn_Cust_Save.Size = new System.Drawing.Size(150, 47);
            this.btn_Cust_Save.TabIndex = 16;
            this.btn_Cust_Save.Text = "Enter";
            this.btn_Cust_Save.UseVisualStyleBackColor = false;
            this.btn_Cust_Save.Click += new System.EventHandler(this.btn_Cust_Save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(289, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(826, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 21.75F);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(58, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 35);
            this.label8.TabIndex = 20;
            this.label8.Text = "Customer Detils";
            // 
            // db_cust
            // 
            this.db_cust.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.db_cust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.db_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_cust.Location = new System.Drawing.Point(459, 156);
            this.db_cust.Name = "db_cust";
            this.db_cust.Size = new System.Drawing.Size(700, 408);
            this.db_cust.TabIndex = 0;
            this.db_cust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_cust_CellContentClick);
            // 
            // lbl_CId
            // 
            this.lbl_CId.AutoSize = true;
            this.lbl_CId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CId.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lbl_CId.Location = new System.Drawing.Point(60, 172);
            this.lbl_CId.Name = "lbl_CId";
            this.lbl_CId.Size = new System.Drawing.Size(95, 21);
            this.lbl_CId.TabIndex = 1;
            this.lbl_CId.Text = "Customer Id";
            // 
            // txt_Cust_Id
            // 
            this.txt_Cust_Id.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.txt_Cust_Id.Location = new System.Drawing.Point(190, 156);
            this.txt_Cust_Id.Multiline = true;
            this.txt_Cust_Id.Name = "txt_Cust_Id";
            this.txt_Cust_Id.Size = new System.Drawing.Size(249, 37);
            this.txt_Cust_Id.TabIndex = 9;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Location = new System.Drawing.Point(1009, 582);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 47);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(279, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 58);
            this.panel1.TabIndex = 23;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightGray;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1162, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(39, 33);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 674);
            this.panel2.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(641, 582);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 47);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnMin.Location = new System.Drawing.Point(1087, -1);
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
            this.btnMax.Location = new System.Drawing.Point(1123, -1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 34);
            this.btnMax.TabIndex = 27;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // frm_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 669);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cust_Save);
            this.Controls.Add(this.txt_Cust_Vecnum);
            this.Controls.Add(this.txt_Cust_Vectype);
            this.Controls.Add(this.txt_Cust_Email);
            this.Controls.Add(this.txt_Cust_Nic);
            this.Controls.Add(this.txt_Cust_Add);
            this.Controls.Add(this.txt_Cust_Cont);
            this.Controls.Add(this.txt_Cust_Id);
            this.Controls.Add(this.txt_Cust_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_CId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.db_cust);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.frm_reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_cust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Cust_Name;
        private System.Windows.Forms.TextBox txt_Cust_Cont;
        private System.Windows.Forms.TextBox txt_Cust_Add;
        private System.Windows.Forms.TextBox txt_Cust_Nic;
        private System.Windows.Forms.TextBox txt_Cust_Email;
        private System.Windows.Forms.TextBox txt_Cust_Vectype;
        private System.Windows.Forms.TextBox txt_Cust_Vecnum;
        private System.Windows.Forms.Button btn_Cust_Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView db_cust;
        private System.Windows.Forms.Label lbl_CId;
        private System.Windows.Forms.TextBox txt_Cust_Id;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
    }
}