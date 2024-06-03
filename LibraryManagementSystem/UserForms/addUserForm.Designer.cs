namespace Kutuphane_Otomasyonu_2
{
    partial class addUserForm
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
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW1
            // 
            this.dGW1.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(346, 37);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(464, 278);
            this.dGW1.TabIndex = 17;
            this.dGW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tel No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.BackColor = System.Drawing.Color.Beige;
            this.txt_phoneNumber.Location = new System.Drawing.Point(126, 153);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(191, 37);
            this.txt_phoneNumber.TabIndex = 13;
            // 
            // txt_surname
            // 
            this.txt_surname.BackColor = System.Drawing.Color.Beige;
            this.txt_surname.Location = new System.Drawing.Point(126, 95);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(191, 37);
            this.txt_surname.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Beige;
            this.txt_username.Location = new System.Drawing.Point(126, 37);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 37);
            this.txt_username.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.saveButton.Location = new System.Drawing.Point(126, 213);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 48);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "KAYDET";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.backButton.Location = new System.Drawing.Point(126, 267);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(191, 48);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "GERİ DÖN";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(830, 349);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dGW1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "addUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addUserForm";
            this.Load += new System.EventHandler(this.addUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGW1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
    }
}