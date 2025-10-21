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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gv_urunler.DataSource = UrunListele();
                gv_urunler.DataBind();
                ddl_kategoriler.DataSource = KategoriListele();
                ddl_kategoriler.DataBind();
            }
        }
        protected void btn_filtrele_Click(object sender, EventArgs e)
        {
            if (ddl_kategoriler.SelectedItem.Value != "-1")
            {
                int katNo = Convert.ToInt32(ddl_kategoriler.SelectedItem.Value);
                gv_urunler.DataSource= UrunListeleKategori(katNo);
                gv_urunler.DataBind();
            }
            else
            {
                gv_urunler.DataSource = UrunListele();
                gv_urunler.DataBind();
            }
        }
        public List<Urun> UrunListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, P.ProductName, P.CategoryID, C.CategoryName, P.SupplierID, S.CompanyName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, p.ReorderLevel, P.Discontinued FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.ProductID = reader.GetInt32(0);
                    u.ProductName = reader.GetString(1);
                    u.CategoryID = reader.GetInt32(2);
                    u.CategoryName = reader.GetString(3);
                    u.SupplierID = reader.GetInt32(4);
                    u.CompanyName = reader.GetString(5);
                    u.QuantityPerUnit = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    u.UnitPrice = reader.GetDecimal(7);
                    u.UnitsInStock = reader.GetInt16(8);
                    u.ReorderLevel = reader.GetInt16(9);
                    u.Discontinued = reader.GetBoolean(10);
                    if (u.Discontinued == true)
                    {
                        u.SatistaMi = "Satış Dışı";
                    }

                    urunler.Add(u);
                }
            }
            finally
            {
                con.Close();
            }
            return urunler;
        }

        public List<Urun> UrunListeleKategori(int katNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, P.ProductName, P.CategoryID, C.CategoryName, P.SupplierID, S.CompanyName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, p.ReorderLevel, P.Discontinued FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID WHERE P.CategoryID=@kid";
                cmd.Parameters.AddWithValue("@kid", katNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.ProductID = reader.GetInt32(0);
                    u.ProductName = reader.GetString(1);
                    u.CategoryID = reader.GetInt32(2);
                    u.CategoryName = reader.GetString(3);
                    u.SupplierID = reader.GetInt32(4);
                    u.CompanyName = reader.GetString(5);
                    u.QuantityPerUnit = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    u.UnitPrice = reader.GetDecimal(7);
                    u.UnitsInStock = reader.GetInt16(8);
                    u.ReorderLevel = reader.GetInt16(9);
                    u.Discontinued = reader.GetBoolean(10);
                    if (u.Discontinued == true)
                    {
                        u.SatistaMi = "Satış Dışı";
                    }

                    urunler.Add(u);
                }
            }
            finally
            {
                con.Close();
            }
            return urunler;
        }

        public List<Kategori> KategoriListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            List<Kategori> kategoriler = new List<Kategori>();

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
                return kategoriler;
            }
            finally
            {
                con.Close();
            }
        }

        
    }
}