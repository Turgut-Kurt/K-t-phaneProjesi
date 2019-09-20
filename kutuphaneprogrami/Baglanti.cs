using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace kutuphaneprogrami
{
    class Baglanti
    {
        public static void kur()
        {
            string kaynak = "Data Source=DESKTOP-3L5LDLR;Initial Catalog=AHBS;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(kaynak);
            DataSet ds;
            //SqlDataAdapter da;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hasta_Bilgileri", baglanti);
            ds = new DataSet();
            da.Fill(ds);
               // dataGridView1.DataSource = ds.Tables[0];*/
        }
    }
}
