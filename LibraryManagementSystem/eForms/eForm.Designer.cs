namespace Kutuphane_Otomasyonu_2
{
    partial class eForm
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
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lendBookButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.suggestionButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateUserButton);
            this.groupBox1.Controls.Add(this.deleteUserButton);
            this.groupBox1.Controls.Add(this.addUserButton);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // updateUserButton
            // 
            this.updateUserButton.BackColor = System.Drawing.Color.Beige;
            this.updateUserButton.Location = new System.Drawing.Point(14, 247);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(384, 91);
            this.updateUserButton.TabIndex = 2;
            this.updateUserButton.Text = "Kullanıcı Güncelle";
            this.updateUserButton.UseVisualStyleBackColor = false;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Beige;
            this.deleteUserButton.Location = new System.Drawing.Point(14, 150);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(384, 91);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Kullanıcı Sil";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Beige;
            this.addUserButton.Location = new System.Drawing.Point(14, 53);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(384, 91);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Kullanıcı Ekle";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateBookButton);
            this.groupBox2.Controls.Add(this.deleteBookButton);
            this.groupBox2.Controls.Add(this.addBookButton);
            this.groupBox2.Location = new System.Drawing.Point(523, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 348);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // updateBookButton
            // 
            this.updateBookButton.BackColor = System.Drawing.Color.Beige;
            this.updateBookButton.Location = new System.Drawing.Point(14, 247);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(384, 91);
            this.updateBookButton.TabIndex = 2;
            this.updateBookButton.Text = "Kitap Güncelle";
            this.updateBookButton.UseVisualStyleBackColor = false;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.Beige;
            this.deleteBookButton.Location = new System.Drawing.Point(14, 150);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(384, 91);
            this.deleteBookButton.TabIndex = 1;
            this.deleteBookButton.Text = "Kitap Sil";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.Beige;
            this.addBookButton.Location = new System.Drawing.Point(14, 53);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(384, 91);
            this.addBookButton.TabIndex = 0;
            this.addBookButton.Text = "Kitap Ekle";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lendBookButton);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(29, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 253);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödünç ve Geri Alma İşlemleri";
            // 
            // lendBookButton
            // 
            this.lendBookButton.BackColor = System.Drawing.Color.Beige;
            this.lendBookButton.Location = new System.Drawing.Point(14, 53);
            this.lendBookButton.Name = "lendBookButton";
            this.lendBookButton.Size = new System.Drawing.Size(384, 91);
            this.lendBookButton.TabIndex = 2;
            this.lendBookButton.Text = "Kitabı Ödünç Ver";
            this.lendBookButton.UseVisualStyleBackColor = false;
            this.lendBookButton.Click += new System.EventHandler(this.lendBookButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Location = new System.Drawing.Point(14, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(384, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kitabı Geri Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.suggestionButton);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(523, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 253);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // suggestionButton
            // 
            this.suggestionButton.BackColor = System.Drawing.Color.Beige;
            this.suggestionButton.Location = new System.Drawing.Point(14, 53);
            this.suggestionButton.Name = "suggestionButton";
            this.suggestionButton.Size = new System.Drawing.Size(384, 91);
            this.suggestionButton.TabIndex = 2;
            this.suggestionButton.Text = "Kitap Öner";
            this.suggestionButton.UseVisualStyleBackColor = false;
            this.suggestionButton.Click += new System.EventHandler(this.suggestionButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Beige;
            this.button3.Location = new System.Drawing.Point(14, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(384, 91);
            this.button3.TabIndex = 1;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(979, 667);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "eForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eForm";
            this.Load += new System.EventHandler(this.eForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button lendBookButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button suggestionButton;
    }
}