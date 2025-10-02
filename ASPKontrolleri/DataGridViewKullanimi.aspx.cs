using ASPKontrolleri.Model;
using System;
using System.Collections.Generic;
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
        }
    }
}