﻿namespace Kutuphane_Otomasyonu_2
{
    partial class addBookForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.txt_bookPages = new System.Windows.Forms.TextBox();
            this.txt_bookPublisher = new System.Windows.Forms.TextBox();
            this.txt_bookAuthor = new System.Windows.Forms.TextBox();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.backButton.Location = new System.Drawing.Point(179, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 48);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "GERİ DÖN";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.saveButton.Location = new System.Drawing.Point(179, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 48);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "KAYDET";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dGW1
            // 
            this.dGW1.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(398, 46);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(638, 296);
            this.dGW1.TabIndex = 35;
            this.dGW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW1_CellContentClick);
            // 
            // txt_bookPages
            // 
            this.txt_bookPages.BackColor = System.Drawing.Color.Beige;
            this.txt_bookPages.Location = new System.Drawing.Point(179, 187);
            this.txt_bookPages.Name = "txt_bookPages";
            this.txt_bookPages.Size = new System.Drawing.Size(200, 37);
            this.txt_bookPages.TabIndex = 45;
            // 
            // txt_bookPublisher
            // 
            this.txt_bookPublisher.BackColor = System.Drawing.Color.Beige;
            this.txt_bookPublisher.Location = new System.Drawing.Point(179, 144);
            this.txt_bookPublisher.Name = "txt_bookPublisher";
            this.txt_bookPublisher.Size = new System.Drawing.Size(200, 37);
            this.txt_bookPublisher.TabIndex = 44;
            // 
            // txt_bookAuthor
            // 
            this.txt_bookAuthor.BackColor = System.Drawing.Color.Beige;
            this.txt_bookAuthor.Location = new System.Drawing.Point(179, 98);
            this.txt_bookAuthor.Name = "txt_bookAuthor";
            this.txt_bookAuthor.Size = new System.Drawing.Size(200, 37);
            this.txt_bookAuthor.TabIndex = 43;
            // 
            // txt_bookName
            // 
            this.txt_bookName.BackColor = System.Drawing.Color.Beige;
            this.txt_bookName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_bookName.Location = new System.Drawing.Point(179, 50);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(200, 37);
            this.txt_bookName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Yayıncı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kitap Adı:";
            // 
            // addBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1068, 360);
            this.Controls.Add(this.txt_bookPages);
            this.Controls.Add(this.txt_bookPublisher);
            this.Controls.Add(this.txt_bookAuthor);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dGW1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "addBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addBookForm";
            this.Load += new System.EventHandler(this.addBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dGW1;
        private System.Windows.Forms.TextBox txt_bookPages;
        private System.Windows.Forms.TextBox txt_bookPublisher;
        private System.Windows.Forms.TextBox txt_bookAuthor;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}