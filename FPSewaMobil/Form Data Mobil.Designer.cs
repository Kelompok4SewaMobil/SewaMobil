
namespace FPSewaMobil
{
    partial class Form_Data_Mobil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Data_Mobil));
            this.btninsert = new System.Windows.Forms.Button();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txttahun = new System.Windows.Forms.TextBox();
            this.txtnomobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncari = new System.Windows.Forms.ToolStripButton();
            this.txtcari = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dgvdatamobil = new System.Windows.Forms.DataGridView();
            this.btnkembali = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatamobil)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(22, 258);
            this.btninsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(112, 35);
            this.btninsert.TabIndex = 27;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(222, 120);
            this.txtnama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(241, 26);
            this.txtnama.TabIndex = 24;
            // 
            // txttahun
            // 
            this.txttahun.Location = new System.Drawing.Point(222, 191);
            this.txttahun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttahun.Name = "txttahun";
            this.txttahun.Size = new System.Drawing.Size(241, 26);
            this.txttahun.TabIndex = 23;
            // 
            // txtnomobil
            // 
            this.txtnomobil.Location = new System.Drawing.Point(222, 52);
            this.txtnomobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnomobil.Name = "txtnomobil";
            this.txtnomobil.Size = new System.Drawing.Size(241, 26);
            this.txtnomobil.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "NAMA MOBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "TAHUN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "NO.MOBIL";
            // 
            // btncari
            // 
            this.btncari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncari.Image = ((System.Drawing.Image)(resources.GetObject("btncari.Image")));
            this.btncari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(34, 28);
            this.btncari.Text = "toolStripButton1";
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // txtcari
            // 
            this.txtcari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(223, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 28);
            this.toolStripLabel1.Text = "Pencarian Data :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtcari,
            this.btncari});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1028, 33);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(189, 258);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 35);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(364, 258);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 35);
            this.btndelete.TabIndex = 29;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(537, 258);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 35);
            this.btnreset.TabIndex = 30;
            this.btnreset.Text = "RESET DATA";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // dgvdatamobil
            // 
            this.dgvdatamobil.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatamobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatamobil.Location = new System.Drawing.Point(18, 305);
            this.dgvdatamobil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdatamobil.Name = "dgvdatamobil";
            this.dgvdatamobil.RowHeadersWidth = 62;
            this.dgvdatamobil.Size = new System.Drawing.Size(644, 312);
            this.dgvdatamobil.TabIndex = 31;
            // 
            // btnkembali
            // 
            this.btnkembali.Location = new System.Drawing.Point(537, 640);
            this.btnkembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(132, 42);
            this.btnkembali.TabIndex = 32;
            this.btnkembali.Text = "KEMBALI";
            this.btnkembali.UseVisualStyleBackColor = true;
            this.btnkembali.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_Data_Mobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 694);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.dgvdatamobil);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.txtnomobil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Data_Mobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Data_Mobil";
            this.Load += new System.EventHandler(this.Form_Data_Mobil_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatamobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txttahun;
        private System.Windows.Forms.TextBox txtnomobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btncari;
        private System.Windows.Forms.ToolStripTextBox txtcari;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView dgvdatamobil;
        private System.Windows.Forms.Button btnkembali;
    }
}