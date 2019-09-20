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
    public partial class OkuyucuListe : Form
    {
        public OkuyucuListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds;
        IDataAdapter da;
        private void OkuyucuListe_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Okuyucu_Bilgileri", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void BtnOLara_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            da = new SqlDataAdapter("SELECT * FROM Okuyucu_Bilgileri WHERE ad_soyad LIKE '" + TxtOLadsoyad.Text + "%' AND no LIKE '" + TxtOLokulno.Text + "%'", baglanti);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Btnolcikis_Click(object sender, EventArgs e)
        {
            OkuyucuListe.ActiveForm.Close();
        }
        private void btnolsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sorgu = new SqlCommand("DELETE FROM Okuyucu_Bilgileri WHERE ad_soyad=@ad_soyad", baglanti);
                baglanti.Open();
                sorgu.Parameters.AddWithValue("@ad_soyad", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme islemi başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                da = new SqlDataAdapter("SELECT * FROM Okuyucu_Bilgileri", baglanti);
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
