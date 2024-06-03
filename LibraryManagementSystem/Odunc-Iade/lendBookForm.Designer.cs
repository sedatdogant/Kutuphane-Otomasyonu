namespace Kutuphane_Otomasyonu_2.Odunc_Iade
{
    partial class lendBookForm
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
            this.dGW2 = new System.Windows.Forms.DataGridView();
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lendButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW2
            // 
            this.dGW2.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW2.Location = new System.Drawing.Point(627, 151);
            this.dGW2.Name = "dGW2";
            this.dGW2.RowHeadersWidth = 51;
            this.dGW2.RowTemplate.Height = 24;
            this.dGW2.Size = new System.Drawing.Size(505, 539);
            this.dGW2.TabIndex = 17;
            // 
            // dGW1
            // 
            this.dGW1.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(44, 151);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(533, 539);
            this.dGW1.TabIndex = 16;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Beige;
            this.txt_search.Location = new System.Drawing.Point(764, 114);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(277, 34);
            this.txt_search.TabIndex = 34;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(473, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(453, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkKhaki;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(631, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "Kitaplar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkKhaki;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(48, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Kullanıcılar:";
            // 
            // lendButton
            // 
            this.lendButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lendButton.ForeColor = System.Drawing.Color.Black;
            this.lendButton.Location = new System.Drawing.Point(673, 22);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(239, 67);
            this.lendButton.TabIndex = 29;
            this.lendButton.Text = "ÖDÜNÇ VER";
            this.lendButton.UseVisualStyleBackColor = false;
            this.lendButton.Click += new System.EventHandler(this.lendButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(942, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(239, 67);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "GERİ DÖN";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(511, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 34);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Ara";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkKhaki;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Kullanıcın TC\'sini giriniz:";
            // 
            // txt_TC
            // 
            this.txt_TC.BackColor = System.Drawing.Color.Beige;
            this.txt_TC.Location = new System.Drawing.Point(318, 38);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(187, 34);
            this.txt_TC.TabIndex = 25;
            // 
            // lendBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1202, 717);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.dGW2);
            this.Controls.Add(this.dGW1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "lendBookForm";
            this.Text = "lendBookForm";
            this.Load += new System.EventHandler(this.lendBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGW2;
        private System.Windows.Forms.DataGridView dGW1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TC;
    }
}