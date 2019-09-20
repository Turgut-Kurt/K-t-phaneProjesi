namespace kutuphaneprogrami
{
    partial class TeslimAl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttaad = new System.Windows.Forms.TextBox();
            this.txttakadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btntakaydet = new System.Windows.Forms.Button();
            this.btntacik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // txttaad
            // 
            this.txttaad.Enabled = false;
            this.txttaad.Location = new System.Drawing.Point(185, 35);
            this.txttaad.Name = "txttaad";
            this.txttaad.Size = new System.Drawing.Size(140, 22);
            this.txttaad.TabIndex = 2;
            // 
            // txttakadi
            // 
            this.txttakadi.Enabled = false;
            this.txttakadi.Location = new System.Drawing.Point(185, 67);
            this.txttakadi.Name = "txttakadi";
            this.txttakadi.Size = new System.Drawing.Size(140, 22);
            this.txttakadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teslim Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teslim Durumu";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(185, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Teslim Edildi";
            // 
            // btntakaydet
            // 
            this.btntakaydet.Location = new System.Drawing.Point(106, 229);
            this.btntakaydet.Name = "btntakaydet";
            this.btntakaydet.Size = new System.Drawing.Size(80, 50);
            this.btntakaydet.TabIndex = 9;
            this.btntakaydet.Text = "KAYDET";
            this.btntakaydet.UseVisualStyleBackColor = true;
            this.btntakaydet.Click += new System.EventHandler(this.btntakaydet_Click);
            // 
            // btntacik
            // 
            this.btntacik.Location = new System.Drawing.Point(228, 229);
            this.btntacik.Name = "btntacik";
            this.btntacik.Size = new System.Drawing.Size(80, 50);
            this.btntacik.TabIndex = 10;
            this.btntacik.Text = "ÇIK";
            this.btntacik.UseVisualStyleBackColor = true;
            // 
            // TeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.btntacik);
            this.Controls.Add(this.btntakaydet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttakadi);
            this.Controls.Add(this.txttaad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeslimAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeslimAl";
            this.Load += new System.EventHandler(this.TeslimAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaad;
        private System.Windows.Forms.TextBox txttakadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btntakaydet;
        private System.Windows.Forms.Button btntacik;
    }
}