namespace kutuphaneprogrami
{
    partial class KitapListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtklkitapyazar = new System.Windows.Forms.TextBox();
            this.txtklkitapadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnklsil = new System.Windows.Forms.Button();
            this.Btnklcikis = new System.Windows.Forms.Button();
            this.Btnklara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtklkitapyazar
            // 
            this.txtklkitapyazar.Location = new System.Drawing.Point(546, 110);
            this.txtklkitapyazar.Multiline = true;
            this.txtklkitapyazar.Name = "txtklkitapyazar";
            this.txtklkitapyazar.Size = new System.Drawing.Size(140, 25);
            this.txtklkitapyazar.TabIndex = 25;
            // 
            // txtklkitapadi
            // 
            this.txtklkitapadi.Location = new System.Drawing.Point(370, 110);
            this.txtklkitapadi.Multiline = true;
            this.txtklkitapadi.Name = "txtklkitapadi";
            this.txtklkitapadi.Size = new System.Drawing.Size(140, 25);
            this.txtklkitapadi.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(566, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kitap Yazarı";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(405, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kitap Adı";
            // 
            // btnklsil
            // 
            this.btnklsil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnklsil.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.img_259199;
            this.btnklsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnklsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnklsil.Location = new System.Drawing.Point(570, 620);
            this.btnklsil.Name = "btnklsil";
            this.btnklsil.Size = new System.Drawing.Size(150, 120);
            this.btnklsil.TabIndex = 28;
            this.btnklsil.Text = "SİL";
            this.btnklsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnklsil.UseVisualStyleBackColor = false;
            this.btnklsil.Click += new System.EventHandler(this.btnklsil_Click);
            // 
            // Btnklcikis
            // 
            this.Btnklcikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnklcikis.BackgroundImage = global::kutuphaneprogrami.Properties.Resources._256_256_d58cee45141ee91804ce2ec5a86eccc7_exit;
            this.Btnklcikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnklcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnklcikis.Location = new System.Drawing.Point(770, 620);
            this.Btnklcikis.Name = "Btnklcikis";
            this.Btnklcikis.Size = new System.Drawing.Size(150, 120);
            this.Btnklcikis.TabIndex = 27;
            this.Btnklcikis.Text = "ÇIKIŞ";
            this.Btnklcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnklcikis.UseVisualStyleBackColor = false;
            this.Btnklcikis.Click += new System.EventHandler(this.Btnklcikis_Click);
            // 
            // Btnklara
            // 
            this.Btnklara.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnklara.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.search_book_icon_68567;
            this.Btnklara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnklara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnklara.Location = new System.Drawing.Point(724, 38);
            this.Btnklara.Name = "Btnklara";
            this.Btnklara.Size = new System.Drawing.Size(120, 100);
            this.Btnklara.TabIndex = 26;
            this.Btnklara.Text = "Ara";
            this.Btnklara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnklara.UseVisualStyleBackColor = false;
            this.Btnklara.Click += new System.EventHandler(this.Btnklara_Click);
            // 
            // KitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1037);
            this.Controls.Add(this.btnklsil);
            this.Controls.Add(this.Btnklcikis);
            this.Controls.Add(this.Btnklara);
            this.Controls.Add(this.txtklkitapyazar);
            this.Controls.Add(this.txtklkitapadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.KitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtklkitapyazar;
        private System.Windows.Forms.TextBox txtklkitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnklara;
        private System.Windows.Forms.Button btnklsil;
        private System.Windows.Forms.Button Btnklcikis;
    }
}