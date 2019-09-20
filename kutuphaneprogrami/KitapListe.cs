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
    public partial class KitapListe : Form
    {
        public KitapListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;
        private void KitapListe_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Kitap_Bilgileri", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Btnklcikis_Click(object sender, EventArgs e)
        {
            OkuyucuListe.ActiveForm.Close();
        }
        private void Btnklara_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            da = new SqlDataAdapter("SELECT * FROM Kitap_Bilgileri WHERE kitap_adi LIKE '" + txtklkitapadi.Text + "%' AND yazar_adi LIKE '" + txtklkitapyazar.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnklsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sorgu = new SqlCommand("DELETE FROM Kitap_Bilgileri WHERE kitap_adi=@kitap_adi", baglanti);
                baglanti.Open();
                sorgu.Parameters.AddWithValue("@kitap_adi", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme islemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                da = new SqlDataAdapter("SELECT * FROM Kitap_Bilgileri", baglanti);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
            }
        }
    }
}
