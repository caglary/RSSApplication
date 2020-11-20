namespace RSSApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRssUrl = new System.Windows.Forms.ComboBox();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstHaberBasliklari = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnRssAdd = new System.Windows.Forms.Button();
            this.txtRss = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtRss);
            this.groupBox1.Controls.Add(this.btnRssAdd);
            this.groupBox1.Controls.Add(this.comboBoxRssUrl);
            this.groupBox1.Controls.Add(this.BtnGetir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1476, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // comboBoxRssUrl
            // 
            this.comboBoxRssUrl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRssUrl.FormattingEnabled = true;
            this.comboBoxRssUrl.Location = new System.Drawing.Point(3, 62);
            this.comboBoxRssUrl.Name = "comboBoxRssUrl";
            this.comboBoxRssUrl.Size = new System.Drawing.Size(790, 28);
            this.comboBoxRssUrl.TabIndex = 1;
            // 
            // BtnGetir
            // 
            this.BtnGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnGetir.Location = new System.Drawing.Point(799, 60);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(112, 31);
            this.BtnGetir.TabIndex = 0;
            this.BtnGetir.Text = "Getir";
            this.BtnGetir.UseVisualStyleBackColor = false;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstHaberBasliklari);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // lstHaberBasliklari
            // 
            this.lstHaberBasliklari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHaberBasliklari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHaberBasliklari.FormattingEnabled = true;
            this.lstHaberBasliklari.ItemHeight = 20;
            this.lstHaberBasliklari.Location = new System.Drawing.Point(3, 18);
            this.lstHaberBasliklari.Name = "lstHaberBasliklari";
            this.lstHaberBasliklari.Size = new System.Drawing.Size(580, 595);
            this.lstHaberBasliklari.TabIndex = 2;
            this.lstHaberBasliklari.SelectedIndexChanged += new System.EventHandler(this.LstHaberBasliklari_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(586, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 616);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 18);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(884, 595);
            this.webBrowser.TabIndex = 0;
            // 
            // btnRssAdd
            // 
            this.btnRssAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRssAdd.Location = new System.Drawing.Point(799, 26);
            this.btnRssAdd.Name = "btnRssAdd";
            this.btnRssAdd.Size = new System.Drawing.Size(112, 29);
            this.btnRssAdd.TabIndex = 2;
            this.btnRssAdd.Text = "Rss Ekle";
            this.btnRssAdd.UseVisualStyleBackColor = false;
            this.btnRssAdd.Click += new System.EventHandler(this.btnRssAdd_Click);
            // 
            // txtRss
            // 
            this.txtRss.Location = new System.Drawing.Point(3, 27);
            this.txtRss.Name = "txtRss";
            this.txtRss.Size = new System.Drawing.Size(790, 28);
            this.txtRss.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 712);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RSS Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstHaberBasliklari;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ComboBox comboBoxRssUrl;
        private System.Windows.Forms.Button btnRssAdd;
        private System.Windows.Forms.TextBox txtRss;
    }
}

