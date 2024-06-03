namespace Kutuphane_Otomasyonu_2.Innovative_Section
{
    partial class bookSuggesitonForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.suggestionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dGW1 = new System.Windows.Forms.DataGridView();
            this.list = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGW2
            // 
            this.dGW2.BackgroundColor = System.Drawing.Color.Beige;
            this.dGW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW2.Location = new System.Drawing.Point(59, 148);
            this.dGW2.Name = "dGW2";
            this.dGW2.RowHeadersWidth = 51;
            this.dGW2.RowTemplate.Height = 24;
            this.dGW2.Size = new System.Drawing.Size(286, 399);
            this.dGW2.TabIndex = 31;
            this.dGW2.VirtualMode = true;
            this.dGW2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "için üstlerine tıklayabilirsin.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bu kitaplar hakkında bilgi almak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "5 kitap öneri olarak verilmektedir.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bu listede en çok ödünç alınan ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ödünç Alınan Kitapların Listesi:";
            // 
            // suggestionButton
            // 
            this.suggestionButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.suggestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suggestionButton.Location = new System.Drawing.Point(338, 40);
            this.suggestionButton.Name = "suggestionButton";
            this.suggestionButton.Size = new System.Drawing.Size(410, 63);
            this.suggestionButton.TabIndex = 24;
            this.suggestionButton.Text = "Öneri Listesini Görmek için Tıkla";
            this.suggestionButton.UseVisualStyleBackColor = false;
            this.suggestionButton.Click += new System.EventHandler(this.suggestionButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.Location = new System.Drawing.Point(37, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(232, 63);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "GERİ DÖN";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dGW1
            // 
            this.dGW1.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW1.Location = new System.Drawing.Point(37, 148);
            this.dGW1.Name = "dGW1";
            this.dGW1.RowHeadersWidth = 51;
            this.dGW1.RowTemplate.Height = 24;
            this.dGW1.Size = new System.Drawing.Size(288, 396);
            this.dGW1.TabIndex = 22;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Beige;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 29;
            this.list.Location = new System.Drawing.Point(351, 253);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(397, 294);
            this.list.TabIndex = 32;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // bookSuggesitonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(793, 559);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dGW2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suggestionButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dGW1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "bookSuggesitonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookSuggesitonForm";
            this.Load += new System.EventHandler(this.bookSuggesitonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGW2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button suggestionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dGW1;
        private System.Windows.Forms.ListBox list;
    }
}