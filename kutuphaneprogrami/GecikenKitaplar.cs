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
    public partial class GecikenKitaplar : Form
    {
        public GecikenKitaplar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;
        string tarih = DateTime.Now.ToString("yyyy-MM-dd");
        private void Btngkcikis_Click(object sender, EventArgs e)
        {
            GecikenKitaplar.ActiveForm.Close();
        }
        private void GecikenKitaplar_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT ob.ad_soyad as [Adı Soyad],ob.no as [Numarası],ob.bolum as [Bölümü],kb.barkod_no as [Barkodu],kb.kitap_adi as [Kitap Adı],kb.yazar_adi as [Kitap Yazarı],el.baslangıc_tarih as[Baslangıç Tarihi],el.bitis_tarih as [Bitiş Tarihi],el.teslim_tarih as [Teslim Tarihi],el.emanet_durumu as [Emanet Durumu] FROM Emanet_Listesi as el INNER JOIN Kitap_Bilgileri as kb ON el.kitapID=kb.kitapID INNER JOIN Okuyucu_Bilgileri as ob ON el.okuyucuID=ob.okuyucuID WHERE el.bitis_tarih<'" +tarih+ "'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btngkara_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            da = new SqlDataAdapter("SELECT ob.ad_soyad as [Adı Soyad],ob.no as [Numarası],ob.bolum as [Bölümü],kb.barkod_no as [Barkodu],kb.kitap_adi as [Kitap Adı],kb.yazar_adi as [Kitap Yazarı],el.baslangıc_tarih as[Baslangıç Tarihi],el.bitis_tarih as [Bitiş Tarihi],el.teslim_tarih as [Teslim Tarihi],el.emanet_durumu as [Emanet Durumu] FROM Emanet_Listesi as el INNER JOIN Kitap_Bilgileri as kb ON el.kitapID=kb.kitapID INNER JOIN Okuyucu_Bilgileri as ob ON el.okuyucuID=ob.okuyucuID WHERE el.bitis_tarih<'" + tarih + "' AND kb.kitap_adi LIKE '" + txtgkkitapadi.Text + "%' AND ob.ad_soyad LIKE '" + txtgkadsoyad.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
