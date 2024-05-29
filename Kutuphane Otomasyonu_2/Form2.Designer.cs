namespace Kutuphane_Otomasyonu_2
{
    partial class IslemPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.guncelleKullanicibtn = new System.Windows.Forms.Button();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.silKitapbtn = new System.Windows.Forms.Button();
            this.guncelleKitapbtn = new System.Windows.Forms.Button();
            this.ekleKitapbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.silKitapbtn);
            this.panel1.Controls.Add(this.guncelleKitapbtn);
            this.panel1.Controls.Add(this.ekleKitapbtn);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.guncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 513);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 67);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kullanıcı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 64);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(236, 64);
            this.ekleKullanicibtn.TabIndex = 3;
            this.ekleKullanicibtn.Text = "Kullanıcı Ekle";
            this.ekleKullanicibtn.UseVisualStyleBackColor = true;
            this.ekleKullanicibtn.Click += new System.EventHandler(this.ekleKullanicibtn_Click);
            // 
            // guncelleKullanicibtn
            // 
            this.guncelleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleKullanicibtn.Location = new System.Drawing.Point(0, 128);
            this.guncelleKullanicibtn.Name = "guncelleKullanicibtn";
            this.guncelleKullanicibtn.Size = new System.Drawing.Size(236, 64);
            this.guncelleKullanicibtn.TabIndex = 4;
            this.guncelleKullanicibtn.Text = "Kullanıcı Güncelle";
            this.guncelleKullanicibtn.UseVisualStyleBackColor = true;
            this.guncelleKullanicibtn.Click += new System.EventHandler(this.guncelleKullanicibtn_Click);
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 192);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(236, 64);
            this.silKullanicibtn.TabIndex = 5;
            this.silKullanicibtn.Text = "Kullanıcı Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = true;
            this.silKullanicibtn.Click += new System.EventHandler(this.silKullanicibtn_Click);
            // 
            // silKitapbtn
            // 
            this.silKitapbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKitapbtn.Location = new System.Drawing.Point(0, 448);
            this.silKitapbtn.Name = "silKitapbtn";
            this.silKitapbtn.Size = new System.Drawing.Size(236, 64);
            this.silKitapbtn.TabIndex = 9;
            this.silKitapbtn.Text = "Kitap Sil";
            this.silKitapbtn.UseVisualStyleBackColor = true;
            this.silKitapbtn.Click += new System.EventHandler(this.silKitapbtn_Click);
            // 
            // guncelleKitapbtn
            // 
            this.guncelleKitapbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleKitapbtn.Location = new System.Drawing.Point(0, 384);
            this.guncelleKitapbtn.Name = "guncelleKitapbtn";
            this.guncelleKitapbtn.Size = new System.Drawing.Size(236, 64);
            this.guncelleKitapbtn.TabIndex = 8;
            this.guncelleKitapbtn.Text = "Kitap Güncelle";
            this.guncelleKitapbtn.UseVisualStyleBackColor = true;
            this.guncelleKitapbtn.Click += new System.EventHandler(this.guncelleKitapbtn_Click);
            // 
            // ekleKitapbtn
            // 
            this.ekleKitapbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKitapbtn.Location = new System.Drawing.Point(0, 320);
            this.ekleKitapbtn.Name = "ekleKitapbtn";
            this.ekleKitapbtn.Size = new System.Drawing.Size(236, 64);
            this.ekleKitapbtn.TabIndex = 7;
            this.ekleKitapbtn.Text = "Kitap Ekle";
            this.ekleKitapbtn.UseVisualStyleBackColor = true;
            this.ekleKitapbtn.Click += new System.EventHandler(this.ekleKitapbtn_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(0, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 64);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kitaplar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "IslemPaneli";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button silKullanicibtn;
        private System.Windows.Forms.Button guncelleKullanicibtn;
        private System.Windows.Forms.Button ekleKullanicibtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button silKitapbtn;
        private System.Windows.Forms.Button guncelleKitapbtn;
        private System.Windows.Forms.Button ekleKitapbtn;
        private System.Windows.Forms.Button button5;
    }
}