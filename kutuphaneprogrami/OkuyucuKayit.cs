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
    public partial class OkuyucuKayit : Form
    {
        public OkuyucuKayit()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Btnokcikis_Click(object sender, EventArgs e)
        {
            OkuyucuKayit.ActiveForm.Close();
        }

        private void Btnokkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            string kayit = "INSERT INTO Okuyucu_Bilgileri (tc_no,ad_soyad,no,dogum_tarihi,dogum_yeri,telefon,e_posta,uyelik_tarihi,cinsiyet,adres,bolum,sınıf) VALUES (@tc_no,@ad_soyad,@no,@dogum_tarihi,@dogum_yeri,@telefon,@e_posta,@uyelik_tarihi,@cinsiyet,@adres,@bolum,@sınıf)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.Add("@tc_no", SqlDbType.NChar);
            komut.Parameters["@tc_no"].Value = Txtoktckimlik.Text.Trim();
            komut.Parameters.Add("@ad_soyad", SqlDbType.NVarChar);
            komut.Parameters["@ad_soyad"].Value = Txtokadsoyad.Text;
            komut.Parameters.Add("@no", SqlDbType.NChar);
            komut.Parameters["@no"].Value = Txtokno.Text.Trim();
            komut.Parameters.Add("@dogum_tarihi", SqlDbType.Date);
            komut.Parameters["@dogum_tarihi"].Value = Tarihokdogumtarih.Value.Date;
            komut.Parameters.Add("@dogum_yeri", SqlDbType.NVarChar);
            komut.Parameters["@dogum_yeri"].Value = Txtokdogumyeri.Text.Trim();
            komut.Parameters.Add("@telefon", SqlDbType.NChar);
            komut.Parameters["@telefon"].Value = Txtoktelefon.Text.Trim();
            komut.Parameters.Add("@e_posta", SqlDbType.NVarChar);
            komut.Parameters["@e_posta"].Value = Txtokeposta.Text.Trim();
            komut.Parameters.Add("@uyelik_tarihi", SqlDbType.Date);
            komut.Parameters["@uyelik_tarihi"].Value = Tarihokuyeliktarih.Value.Date;
            komut.Parameters.Add("@cinsiyet", SqlDbType.NChar);
            komut.Parameters["@cinsiyet"].Value = Cmbbxcinsiyet.Text;
            komut.Parameters.Add("@adres", SqlDbType.NVarChar);
            komut.Parameters["@adres"].Value = richTextBox1.Text;
            komut.Parameters.Add("@bolum", SqlDbType.Char);
            komut.Parameters["@bolum"].Value = cmbboxbolum.Text;
            komut.Parameters.Add("@sınıf", SqlDbType.Char);
            komut.Parameters["@sınıf"].Value = cmbboxsınıf.Text;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OkuyucuKayit_Load(object sender, EventArgs e)
        {

        }

        private void Txtoktckimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Txtokadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void Txtokno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Txtokdogumyeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void Txtoktelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
