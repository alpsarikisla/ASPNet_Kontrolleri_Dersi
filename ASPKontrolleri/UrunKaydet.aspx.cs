using ASPKontrolleri.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class UrunKaydet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KategorileriDoldur();
            TedarikcileriDoldur();
        }
        public void KategorileriDoldur()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kategoriler.Add(kat);
                }
            }
            finally{con.Close();}
            ddl_kategoriler.DataSource = kategoriler;
            ddl_kategoriler.DataBind();
        }
        public void TedarikcileriDoldur()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tedarikci t = new Tedarikci();
                    t.SupplierID = reader.GetInt32(0);
                    t.CompanyName = reader.GetString(1);
                    t.ContactName = !reader.IsDBNull(2) ? reader.GetString(2) : "-";
                    t.ContactTitle = !reader.IsDBNull(3) ? reader.GetString(3) : "-";
                    t.Adress = !reader.IsDBNull(4) ? reader.GetString(4) : "-";
                    t.City = !reader.IsDBNull(5) ? reader.GetString(5) : "-";
                    t.Region = !reader.IsDBNull(6) ? reader.GetString(6) : "-";
                    t.PostalCode = !reader.IsDBNull(7) ? reader.GetString(7) : " - ";
                    t.Country = !reader.IsDBNull(8) ? reader.GetString(8) : " - ";
                    t.Phone = !reader.IsDBNull(9) ? reader.GetString(9) : " - ";
                    t.Fax = !reader.IsDBNull(10) ? reader.GetString(10) : " - ";
                    t.HomePage = !reader.IsDBNull(11) ? reader.GetString(11) : " - ";
                    tedarikciler.Add(t);
                }
            }
            finally { con.Close(); }
            ddl_tedarikciler.DataSource = tedarikciler;
            ddl_tedarikciler.DataBind();
        }
    }
}