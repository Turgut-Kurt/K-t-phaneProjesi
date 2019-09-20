using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kutuphaneprogrami
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;
        int ksayisi, yeniksayisi,eksayisi,id;
        private void AnaForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1);
            da = new SqlDataAdapter("SELECT okuyucuID as ID,tc_no as TC,ad_soyad as [Adı Soyadı],no as [Numarası],telefon as Telefon,bolum as [Bölümü],sınıf as Sınıfı FROM Okuyucu_Bilgileri", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            label2.Text = "Üye Sayısı   :   " + ds.Tables[0].Rows.Count.ToString();
            da = new SqlDataAdapter("SELECT * FROM Emanet_Listesi WHERE emanet_durumu  LIKE '" + textBox3.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            label9.Text = "Emanetteki Kitap Sayısı :  " + ds.Tables[0].Rows.Count.ToString();
            eksayisi = ds.Tables[0].Rows.Count;
            da = new SqlDataAdapter("SELECT kb.kitapID as ID,kb.barkod_no as [Kitap No],kb.kitap_adi as [Kitap Adı],kb.yazar_adi as [Yazar Adı],kb.yayin_evi as [Yayın Evi],kb.kitap_turu as [Kitap Türü]  FROM Kitap_Bilgileri as kb LEFT JOIN Emanet_listesi as el ON kb.kitapID=el.kitapID WHERE el.kitapID IS NULL OR el.emanet_durumu='Teslim Edildi'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            ksayisi= ds.Tables[0].Rows.Count;
            yeniksayisi = ksayisi + eksayisi;
            label8.Text = "Kitap Sayısı  :  " + yeniksayisi;
        }

        private void BtnKitapKayit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapKayit kitap = new KitapKayit();
            kitap.ShowDialog();
            this.Visible = true;
        }
        private void Btnokuyucukayit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OkuyucuKayit kayit = new OkuyucuKayit();
            kayit.ShowDialog();
            this.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OkuyucuListe liste = new OkuyucuListe();
            liste.ShowDialog();
            this.Visible = true;
        }
        private void btnkisiara_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            da = new SqlDataAdapter("SELECT * FROM Okuyucu_Bilgileri WHERE ad_soyad LIKE '" + txtadsoyad.Text + "%' AND no LIKE '" + txtogrno.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnkitapara_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();
            da = new SqlDataAdapter("SELECT * FROM Kitap_Bilgileri as kb LEFT JOIN Emanet_listesi as el ON kb.kitapID=el.kitapID WHERE el.kitapID IS NULL AND kitap_adi LIKE '" + txtkitapadi.Text + "%' AND yazar_adi LIKE '" + txtkitapyazar.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void txtadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void txtogrno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtkitapadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void txtkitapyazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void btnkitapliste_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapListe kliste = new KitapListe();
            kliste.ShowDialog();
            this.Visible = true;
        }
        private void EmanetKitap_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmanetKitaplar emanet = new EmanetKitaplar();
            emanet.ShowDialog();
            this.Visible = true;
        }

        private void btngeciken_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GecikenKitaplar geciken = new GecikenKitaplar();
            geciken.ShowDialog();
            this.Visible = true;
        }

        private void btnyedekal_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtaokuyuad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            da = new SqlDataAdapter("SELECT * FROM Emanet_Listesi WHERE emanet_durumu='Teslim Edilmedi' AND okuyucuID="+id+"", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            textBox2.Text =ds.Tables[0].Rows.Count.ToString();
            da = new SqlDataAdapter("SELECT * FROM Emanet_Listesi WHERE emanet_durumu='Teslim Edildi'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            textBox1.Text = ds.Tables[0].Rows.Count.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtakitapadi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnemanetkayıt_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            string kayit = "INSERT INTO Emanet_Listesi (kitapID,okuyucuID,baslangıc_tarih,bitis_tarih,emanet_durumu) VALUES (@kitapID,@okuyucuID,@baslangıc_tarih,@bitis_tarih,@emanet_durumu)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.Add("@kitapID", SqlDbType.Int);
            komut.Parameters["@kitapID"].Value = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            komut.Parameters.Add("@okuyucuID", SqlDbType.Int);
            komut.Parameters["@okuyucuID"].Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            komut.Parameters.Add("@baslangıc_tarih", SqlDbType.Date);
            komut.Parameters["@baslangıc_tarih"].Value = dateTimePicker1.Value;
            komut.Parameters.Add("@bitis_tarih", SqlDbType.Date);
            komut.Parameters["@bitis_tarih"].Value = dateTimePicker2.Value;
            komut.Parameters.Add("@emanet_durumu", SqlDbType.NVarChar);
            komut.Parameters["@emanet_durumu"].Value = textBox3.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
