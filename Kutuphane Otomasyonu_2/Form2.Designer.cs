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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.guncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 661);
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
            this.ekleKullanicibtn.Text = "Ekle";
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
            this.guncelleKullanicibtn.Text = "Güncelle";
            this.guncelleKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 192);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(236, 64);
            this.silKullanicibtn.TabIndex = 5;
            this.silKullanicibtn.Text = "Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 661);
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
    }
}