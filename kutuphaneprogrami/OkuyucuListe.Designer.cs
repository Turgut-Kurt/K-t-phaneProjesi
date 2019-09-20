namespace kutuphaneprogrami
{
    partial class OkuyucuListe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOLadsoyad = new System.Windows.Forms.TextBox();
            this.TxtOLokulno = new System.Windows.Forms.TextBox();
            this.btnolsil = new System.Windows.Forms.Button();
            this.Btnolcikis = new System.Windows.Forms.Button();
            this.BtnOLara = new System.Windows.Forms.Button();
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
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(383, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(513, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Okul No";
            // 
            // TxtOLadsoyad
            // 
            this.TxtOLadsoyad.Location = new System.Drawing.Point(370, 110);
            this.TxtOLadsoyad.Name = "TxtOLadsoyad";
            this.TxtOLadsoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtOLadsoyad.TabIndex = 4;
            // 
            // TxtOLokulno
            // 
            this.TxtOLokulno.Location = new System.Drawing.Point(495, 110);
            this.TxtOLokulno.Name = "TxtOLokulno";
            this.TxtOLokulno.Size = new System.Drawing.Size(100, 22);
            this.TxtOLokulno.TabIndex = 6;
            // 
            // btnolsil
            // 
            this.btnolsil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnolsil.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.images5;
            this.btnolsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnolsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnolsil.Location = new System.Drawing.Point(570, 620);
            this.btnolsil.Name = "btnolsil";
            this.btnolsil.Size = new System.Drawing.Size(150, 120);
            this.btnolsil.TabIndex = 18;
            this.btnolsil.Text = "SİL";
            this.btnolsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnolsil.UseVisualStyleBackColor = false;
            this.btnolsil.Click += new System.EventHandler(this.btnolsil_Click);
            // 
            // Btnolcikis
            // 
            this.Btnolcikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnolcikis.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.icon_TransitionBusiness;
            this.Btnolcikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnolcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnolcikis.Location = new System.Drawing.Point(770, 620);
            this.Btnolcikis.Name = "Btnolcikis";
            this.Btnolcikis.Size = new System.Drawing.Size(150, 120);
            this.Btnolcikis.TabIndex = 17;
            this.Btnolcikis.Text = "ÇIKIŞ";
            this.Btnolcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnolcikis.UseVisualStyleBackColor = false;
            this.Btnolcikis.Click += new System.EventHandler(this.Btnolcikis_Click);
            // 
            // BtnOLara
            // 
            this.BtnOLara.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOLara.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.img_162167;
            this.BtnOLara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOLara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOLara.Location = new System.Drawing.Point(640, 38);
            this.BtnOLara.Name = "BtnOLara";
            this.BtnOLara.Size = new System.Drawing.Size(120, 100);
            this.BtnOLara.TabIndex = 7;
            this.BtnOLara.Text = "Ara";
            this.BtnOLara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOLara.UseVisualStyleBackColor = false;
            this.BtnOLara.Click += new System.EventHandler(this.BtnOLara_Click);
            // 
            // OkuyucuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1037);
            this.Controls.Add(this.btnolsil);
            this.Controls.Add(this.Btnolcikis);
            this.Controls.Add(this.BtnOLara);
            this.Controls.Add(this.TxtOLokulno);
            this.Controls.Add(this.TxtOLadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OkuyucuListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Listesi";
            this.Load += new System.EventHandler(this.OkuyucuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOLadsoyad;
        private System.Windows.Forms.TextBox TxtOLokulno;
        private System.Windows.Forms.Button BtnOLara;
        private System.Windows.Forms.Button Btnolcikis;
        private System.Windows.Forms.Button btnolsil;
    }
}