
namespace saatproje
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
            this.components = new System.ComponentModel.Container();
            this.BtnDurdur = new System.Windows.Forms.Button();
            this.BtnDevam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSaat = new System.Windows.Forms.Label();
            this.LblPC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LblSn = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TxtDk = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDurdur
            // 
            this.BtnDurdur.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnDurdur.Enabled = false;
            this.BtnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDurdur.ForeColor = System.Drawing.Color.White;
            this.BtnDurdur.Location = new System.Drawing.Point(36, 416);
            this.BtnDurdur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDurdur.Name = "BtnDurdur";
            this.BtnDurdur.Size = new System.Drawing.Size(419, 59);
            this.BtnDurdur.TabIndex = 0;
            this.BtnDurdur.Text = "DURDUR";
            this.BtnDurdur.UseVisualStyleBackColor = false;
            this.BtnDurdur.Click += new System.EventHandler(this.BtnDurdur_Click);
            // 
            // BtnDevam
            // 
            this.BtnDevam.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnDevam.Enabled = false;
            this.BtnDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDevam.ForeColor = System.Drawing.Color.White;
            this.BtnDevam.Location = new System.Drawing.Point(36, 482);
            this.BtnDevam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDevam.Name = "BtnDevam";
            this.BtnDevam.Size = new System.Drawing.Size(419, 59);
            this.BtnDevam.TabIndex = 1;
            this.BtnDevam.Text = "DEVAM ET";
            this.BtnDevam.UseVisualStyleBackColor = false;
            this.BtnDevam.Click += new System.EventHandler(this.BtnDevam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.LblSaat);
            this.panel1.Location = new System.Drawing.Point(36, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 241);
            this.panel1.TabIndex = 2;
            // 
            // LblSaat
            // 
            this.LblSaat.AutoSize = true;
            this.LblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaat.ForeColor = System.Drawing.Color.Black;
            this.LblSaat.Location = new System.Drawing.Point(132, 90);
            this.LblSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSaat.Name = "LblSaat";
            this.LblSaat.Size = new System.Drawing.Size(145, 54);
            this.LblSaat.TabIndex = 0;
            this.LblSaat.Text = "SAAT";
            // 
            // LblPC
            // 
            this.LblPC.AutoSize = true;
            this.LblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPC.Location = new System.Drawing.Point(375, 561);
            this.LblPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPC.Name = "LblPC";
            this.LblPC.Size = new System.Drawing.Size(79, 29);
            this.LblPC.TabIndex = 3;
            this.LblPC.Text = "SAAT";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dakika Giriniz :";
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.ForeColor = System.Drawing.Color.White;
            this.BtnBaslat.Location = new System.Drawing.Point(87, 50);
            this.BtnBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(325, 42);
            this.BtnBaslat.TabIndex = 6;
            this.BtnBaslat.Text = "BAŞLAT";
            this.BtnBaslat.UseVisualStyleBackColor = false;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LblSn
            // 
            this.LblSn.AutoSize = true;
            this.LblSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSn.Location = new System.Drawing.Point(31, 561);
            this.LblSn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSn.Name = "LblSn";
            this.LblSn.Size = new System.Drawing.Size(27, 29);
            this.LblSn.TabIndex = 7;
            this.LblSn.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 361);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 39);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 1;
            // 
            // TxtDk
            // 
            this.TxtDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDk.Location = new System.Drawing.Point(285, 11);
            this.TxtDk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDk.Name = "TxtDk";
            this.TxtDk.Size = new System.Drawing.Size(96, 30);
            this.TxtDk.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnBaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(497, 609);
            this.Controls.Add(this.TxtDk);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LblSn);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDevam);
            this.Controls.Add(this.BtnDurdur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamanlayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDurdur;
        private System.Windows.Forms.Button BtnDevam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSaat;
        private System.Windows.Forms.Label LblPC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LblSn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox TxtDk;
    }
}

