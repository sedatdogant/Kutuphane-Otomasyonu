namespace Kutuphane_Otomasyonu_2
{
    partial class updateUserForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW1
            // 
            this.dGW1.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(357, 49);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(464, 278);
            this.dGW1.TabIndex = 25;
            this.dGW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tel No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Soyad:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(137, 165);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(191, 37);
            this.txt_phoneNumber.TabIndex = 22;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(137, 107);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(191, 37);
            this.txt_surname.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(137, 49);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 37);
            this.txt_username.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.backButton.Location = new System.Drawing.Point(137, 279);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(191, 48);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "GERİ DÖN";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.updateButton.Location = new System.Drawing.Point(137, 225);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 48);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "GÜNCELLE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(858, 362);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
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
            this.Name = "updateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateUserForm";
            this.Load += new System.EventHandler(this.updateUserForm_Load);
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
    }
}