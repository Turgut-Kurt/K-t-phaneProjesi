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
    public partial class TeslimAl : Form
    {
        EmanetKitaplar ek;
        public TeslimAl(EmanetKitaplar gelen)
        {
            InitializeComponent();
            ek = gelen;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-R9TJ5F6;Initial Catalog=Kutuphane;Integrated Security=True");
        DataSet ds;
        SqlDataAdapter da;

        private void TeslimAl_Load(object sender, EventArgs e)
        {
            txttaad.Text=ek.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttakadi.Text= ek.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void btntakaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "UPDATE Emanet_Listesi SET teslim_tarih=@teslim_tarih,emanet_durumu=@emanet_durumu WHERE emanetID='"+ek.dataGridView1.CurrentRow.Cells[10].Value+"'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@teslim_tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@emanet_durumu", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
