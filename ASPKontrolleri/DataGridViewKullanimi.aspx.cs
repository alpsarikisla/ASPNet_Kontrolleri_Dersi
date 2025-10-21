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
    public partial class DataGridViewKullanimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VeriKaynagi veriKaynagi = new VeriKaynagi();
            gv_ogrenciler.DataSource = veriKaynagi.OgrenciGetir();
            gv_ogrenciler.DataBind();

            gv_kategoriler.DataSource = KategoriGetir();
            gv_kategoriler.DataBind();
        }
        public List<Kategori> KategoriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand komut = baglanti.CreateCommand();

            komut.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
            baglanti.Open();

            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                Kategori kat = new Kategori();
                kat.ID = okuyucu.GetInt32(0);
                kat.Isim = okuyucu.GetString(1);
                //kat.Aciklama = !okuyucu.IsDBNull(2) ? okuyucu.GetString(2) : "";
                if (!okuyucu.IsDBNull(2))
                {
                    kat.Aciklama = okuyucu.GetString(2);
                }
                else
                {
                    kat.Aciklama = "";
                }
                kategoriler.Add(kat);
            }
            return kategoriler;
        }
        public List<Kategori> UrunGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand komut = baglanti.CreateCommand();

            komut.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
            baglanti.Open();

            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                Kategori kat = new Kategori();
                kat.ID = okuyucu.GetInt32(0);
                kat.Isim = okuyucu.GetString(1);
                //kat.Aciklama = !okuyucu.IsDBNull(2) ? okuyucu.GetString(2) : "";
                if (!okuyucu.IsDBNull(2))
                {
                    kat.Aciklama = okuyucu.GetString(2);
                }
                else
                {
                    kat.Aciklama = "";
                }
                kategoriler.Add(kat);
            }
            return kategoriler;
        }
    }
}