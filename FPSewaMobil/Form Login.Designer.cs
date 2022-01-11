
namespace FPSewaMobil
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(666, 416);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(298, 22);
            this.txtpwd.TabIndex = 9;
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(666, 327);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(298, 22);
            this.txtuser.TabIndex = 8;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(724, 469);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(178, 33);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // keluar
            // 
            this.keluar.Image = ((System.Drawing.Image)(resources.GetObject("keluar.Image")));
            this.keluar.Location = new System.Drawing.Point(724, 524);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(178, 34);
            this.keluar.TabIndex = 10;
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 701);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1032, 703);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}