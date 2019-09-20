namespace kutuphaneprogrami
{
    partial class EmanetKitaplar
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
            this.txtekkitapyazar = new System.Windows.Forms.TextBox();
            this.txtekkitapadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtekogrno = new System.Windows.Forms.TextBox();
            this.txtekadsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnteslimal = new System.Windows.Forms.Button();
            this.Btnekcikis = new System.Windows.Forms.Button();
            this.Btnekara = new System.Windows.Forms.Button();
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
            this.dataGridView1.TabIndex = 2;
            // 
            // txtekkitapyazar
            // 
            this.txtekkitapyazar.Location = new System.Drawing.Point(720, 110);
            this.txtekkitapyazar.Multiline = true;
            this.txtekkitapyazar.Name = "txtekkitapyazar";
            this.txtekkitapyazar.Size = new System.Drawing.Size(140, 25);
            this.txtekkitapyazar.TabIndex = 29;
            this.txtekkitapyazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtekkitapyazar_KeyPress);
            // 
            // txtekkitapadi
            // 
            this.txtekkitapadi.Location = new System.Drawing.Point(558, 110);
            this.txtekkitapadi.Multiline = true;
            this.txtekkitapadi.Name = "txtekkitapadi";
            this.txtekkitapadi.Size = new System.Drawing.Size(140, 25);
            this.txtekkitapadi.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(740, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kitap Yazarı";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(594, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kitap Adı";
            // 
            // txtekogrno
            // 
            this.txtekogrno.Location = new System.Drawing.Point(395, 110);
            this.txtekogrno.Multiline = true;
            this.txtekogrno.Name = "txtekogrno";
            this.txtekogrno.Size = new System.Drawing.Size(140, 25);
            this.txtekogrno.TabIndex = 33;
            this.txtekogrno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtekogrno_KeyPress);
            // 
            // txtekadsoyad
            // 
            this.txtekadsoyad.Location = new System.Drawing.Point(232, 110);
            this.txtekadsoyad.Multiline = true;
            this.txtekadsoyad.Name = "txtekadsoyad";
            this.txtekadsoyad.Size = new System.Drawing.Size(140, 25);
            this.txtekadsoyad.TabIndex = 32;
            this.txtekadsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtekadsoyad_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(425, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Okul No";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "AdıSoyadı";
            // 
            // btnteslimal
            // 
            this.btnteslimal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnteslimal.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.asdadaqweqdasdqwe;
            this.btnteslimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnteslimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteslimal.Location = new System.Drawing.Point(570, 620);
            this.btnteslimal.Name = "btnteslimal";
            this.btnteslimal.Size = new System.Drawing.Size(150, 120);
            this.btnteslimal.TabIndex = 36;
            this.btnteslimal.Text = "Teslim Al";
            this.btnteslimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnteslimal.UseVisualStyleBackColor = false;
            this.btnteslimal.Click += new System.EventHandler(this.btnteslimal_Click);
            // 
            // Btnekcikis
            // 
            this.Btnekcikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnekcikis.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.Login_icon;
            this.Btnekcikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnekcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnekcikis.Location = new System.Drawing.Point(770, 620);
            this.Btnekcikis.Name = "Btnekcikis";
            this.Btnekcikis.Size = new System.Drawing.Size(150, 120);
            this.Btnekcikis.TabIndex = 35;
            this.Btnekcikis.Text = "ÇIKIŞ";
            this.Btnekcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnekcikis.UseVisualStyleBackColor = false;
            this.Btnekcikis.Click += new System.EventHandler(this.Btnekcikis_Click);
            // 
            // Btnekara
            // 
            this.Btnekara.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btnekara.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.magnifying_glass_search_icon_graphic_vector_10190646;
            this.Btnekara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnekara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnekara.Location = new System.Drawing.Point(70, 44);
            this.Btnekara.Name = "Btnekara";
            this.Btnekara.Size = new System.Drawing.Size(120, 100);
            this.Btnekara.TabIndex = 34;
            this.Btnekara.Text = "Ara";
            this.Btnekara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnekara.UseVisualStyleBackColor = false;
            this.Btnekara.Click += new System.EventHandler(this.Btnekara_Click);
            // 
            // EmanetKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1037);
            this.Controls.Add(this.btnteslimal);
            this.Controls.Add(this.Btnekcikis);
            this.Controls.Add(this.Btnekara);
            this.Controls.Add(this.txtekogrno);
            this.Controls.Add(this.txtekadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtekkitapyazar);
            this.Controls.Add(this.txtekkitapadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitaplar";
            this.Load += new System.EventHandler(this.EmanetKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtekkitapyazar;
        private System.Windows.Forms.TextBox txtekkitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtekogrno;
        private System.Windows.Forms.TextBox txtekadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnekara;
        private System.Windows.Forms.Button Btnekcikis;
        private System.Windows.Forms.Button btnteslimal;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}