
namespace FPSewaMobil
{
    partial class Form_Laporan
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
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(25, 31);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 33);
            this.print.TabIndex = 0;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            // 
            // Form_Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.print);
            this.Name = "Form_Laporan";
            this.Text = "Form_Laporan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button print;
    }
}