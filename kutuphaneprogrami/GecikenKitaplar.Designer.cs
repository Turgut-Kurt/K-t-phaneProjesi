namespace kutuphaneprogrami
{
    partial class GecikenKitaplar
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
            this.Btngkcikis = new System.Windows.Forms.Button();
            this.Btngkara = new System.Windows.Forms.Button();
            this.txtgkkitapadi = new System.Windows.Forms.TextBox();
            this.txtgkadsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.TabIndex = 3;
            // 
            // Btngkcikis
            // 
            this.Btngkcikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btngkcikis.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.High_contrast_application_exit_svg;
            this.Btngkcikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btngkcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngkcikis.Location = new System.Drawing.Point(770, 620);
            this.Btngkcikis.Name = "Btngkcikis";
            this.Btngkcikis.Size = new System.Drawing.Size(150, 120);
            this.Btngkcikis.TabIndex = 36;
            this.Btngkcikis.Text = "ÇIKIŞ";
            this.Btngkcikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btngkcikis.UseVisualStyleBackColor = false;
            this.Btngkcikis.Click += new System.EventHandler(this.Btngkcikis_Click);
            // 
            // Btngkara
            // 
            this.Btngkara.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btngkara.BackgroundImage = global::kutuphaneprogrami.Properties.Resources.qwewq;
            this.Btngkara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btngkara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngkara.Location = new System.Drawing.Point(70, 44);
            this.Btngkara.Name = "Btngkara";
            this.Btngkara.Size = new System.Drawing.Size(120, 100);
            this.Btngkara.TabIndex = 37;
            this.Btngkara.Text = "Ara";
            this.Btngkara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btngkara.UseVisualStyleBackColor = false;
            this.Btngkara.Click += new System.EventHandler(this.Btngkara_Click);
            // 
            // txtgkkitapadi
            // 
            this.txtgkkitapadi.Location = new System.Drawing.Point(395, 110);
            this.txtgkkitapadi.Multiline = true;
            this.txtgkkitapadi.Name = "txtgkkitapadi";
            this.txtgkkitapadi.Size = new System.Drawing.Size(140, 25);
            this.txtgkkitapadi.TabIndex = 41;
            // 
            // txtgkadsoyad
            // 
            this.txtgkadsoyad.Location = new System.Drawing.Point(232, 110);
            this.txtgkadsoyad.Multiline = true;
            this.txtgkadsoyad.Name = "txtgkadsoyad";
            this.txtgkadsoyad.Size = new System.Drawing.Size(140, 25);
            this.txtgkadsoyad.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(425, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "KitapAdı";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "AdıSoyadı";
            // 
            // GecikenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1037);
            this.Controls.Add(this.txtgkkitapadi);
            this.Controls.Add(this.txtgkadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btngkara);
            this.Controls.Add(this.Btngkcikis);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GecikenKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geciken Kitaplar";
            this.Load += new System.EventHandler(this.GecikenKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btngkcikis;
        private System.Windows.Forms.Button Btngkara;
        private System.Windows.Forms.TextBox txtgkkitapadi;
        private System.Windows.Forms.TextBox txtgkadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}