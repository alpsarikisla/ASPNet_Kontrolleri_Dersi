using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class TextBoxKullanimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_titleDegistir_Click(object sender, EventArgs e)
        {
            this.Title = tb_metin.Text;
        }
    }
}