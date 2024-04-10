namespace toolCreateProjectLaravel
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
            this.dataBase = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalhost = new System.Windows.Forms.TextBox();
            this.localhost = new System.Windows.Forms.Label();
            this.TxtDataName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBase
            // 
            this.dataBase.Controls.Add(this.txtMatKhau);
            this.dataBase.Controls.Add(this.label2);
            this.dataBase.Controls.Add(this.txtTk);
            this.dataBase.Controls.Add(this.label3);
            this.dataBase.Controls.Add(this.txtlocalhost);
            this.dataBase.Controls.Add(this.localhost);
            this.dataBase.Controls.Add(this.TxtDataName);
            this.dataBase.Controls.Add(this.label1);
            this.dataBase.Controls.Add(this.button1);
            this.dataBase.Location = new System.Drawing.Point(24, 12);
            this.dataBase.Name = "dataBase";
            this.dataBase.Size = new System.Drawing.Size(764, 100);
            this.dataBase.TabIndex = 0;
            this.dataBase.TabStop = false;
            this.dataBase.Text = "dataBase";
            this.dataBase.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(390, 60);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 20);
            this.txtMatKhau.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(390, 21);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(100, 20);
            this.txtTk.TabIndex = 6;
            this.txtTk.Text = "root";
            this.txtTk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tài khoản";
            // 
            // txtlocalhost
            // 
            this.txtlocalhost.Location = new System.Drawing.Point(143, 59);
            this.txtlocalhost.Name = "txtlocalhost";
            this.txtlocalhost.Size = new System.Drawing.Size(100, 20);
            this.txtlocalhost.TabIndex = 4;
            this.txtlocalhost.Text = "localhost";
            // 
            // localhost
            // 
            this.localhost.AutoSize = true;
            this.localhost.Location = new System.Drawing.Point(28, 59);
            this.localhost.Name = "localhost";
            this.localhost.Size = new System.Drawing.Size(49, 13);
            this.localhost.TabIndex = 3;
            this.localhost.Text = "localhost";
            // 
            // TxtDataName
            // 
            this.TxtDataName.Location = new System.Drawing.Point(143, 20);
            this.TxtDataName.Name = "TxtDataName";
            this.TxtDataName.Size = new System.Drawing.Size(100, 20);
            this.TxtDataName.TabIndex = 2;
            this.TxtDataName.Text = "databsewebhocphp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tên cơ sở dữ liệu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kết nối CSDL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(190, 145);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(100, 20);
            this.txtlink.TabIndex = 1;
            this.txtlink.TextChanged += new System.EventHandler(this.txtlink_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "link file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "tạo model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "tạo Controllers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.dataBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dataBase.ResumeLayout(false);
            this.dataBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dataBase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalhost;
        private System.Windows.Forms.Label localhost;
        private System.Windows.Forms.TextBox TxtDataName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

