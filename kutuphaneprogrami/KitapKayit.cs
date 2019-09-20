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
    public partial class KitapKayit : Form
    {
        public KitapKayit()
        {
            InitializeComponent();
        }
        string kaynak = "Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True";
        
       
        //ds= new DataSet();
        //SqlDataAdapter da;
        /*SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgileri", baglanti);
        ds = new DataSet();
        da.Fill(ds);
               // dataGridView1.DataSource = ds.Tables[0];*/

        private void Btnkkcikis_Click(object sender, EventArgs e)
        {
            KitapKayit.ActiveForm.Close();

        }

        private void KitapKayit_Load(object sender, EventArgs e)
        {

        }

        private void Btnkkkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
            baglanti.Open();
            string kayit= "INSERT INTO Kitap_Bilgileri (barkod_no,kitap_adi,yazar_adi,yayin_evi,kitap_turu,kayit_tarihi) VALUES (@barkod_no,@kitap_adi,@yazar_adi,@yayin_evi,@kitap_turu,@kayit_tarihi)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.Add("@barkod_no", SqlDbType.NChar);
            komut.Parameters["@barkod_no"].Value = Txtbarkod.Text.Trim();
            komut.Parameters.Add("@kitap_adi", SqlDbType.NVarChar);
            komut.Parameters["@kitap_adi"].Value = Txtkitapad.Text;
            komut.Parameters.Add("@yazar_adi", SqlDbType.NVarChar);
            komut.Parameters["@yazar_adi"].Value = Txtyazarad.Text;
            komut.Parameters.Add("@yayin_evi", SqlDbType.NVarChar);
            komut.Parameters["@yayin_evi"].Value = Txtyayınevi.Text;
            komut.Parameters.Add("@kitap_turu", SqlDbType.NVarChar);
            komut.Parameters["@kitap_turu"].Value = Txtkitapturu.Text;
            komut.Parameters.Add("@kayit_tarihi", SqlDbType.Date);
            komut.Parameters["@kayit_tarihi"].Value = dateTimePicker1.Value.Date;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Txtkitapad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txtyazarad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void Txtyayınevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void Txtkitapturu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
    
    
}
