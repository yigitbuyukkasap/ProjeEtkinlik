using System.Data.SqlClient;

namespace Proje.Veritabani
{
    public class Baglanti
    {
        public SqlConnection Baglan()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5GCPPSKV;Initial Catalog=ProjeEtkinlik;Integrated Security=True");
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else
                return null;
        }
        public SqlDataReader VeriCek(SqlConnection cn, string sorgu)
        {

            SqlCommand com = new SqlCommand(sorgu, cn);
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows == true)
                return rd;
            else
                return null;

        }
        public int VeriEkleGuncelleSil(SqlConnection con, string sorgu)
        {
            SqlCommand query = new SqlCommand(sorgu, con);
            int sonuc = query.ExecuteNonQuery();
            if (sonuc == 1)
                return 1;
            else
                return 0;
        }
    }
}
