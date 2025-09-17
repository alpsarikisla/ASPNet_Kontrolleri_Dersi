using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class KullaniciGirisBst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_kadi.Text))
            {
                if (!string.IsNullOrEmpty(tb_sifre.Text))
                {
                    if (tb_kadi.Text == "admin" && tb_sifre.Text == "1234")
                    {
                        lbl_mesaj.Text = "Giriş Başarılı";
                        lbl_mesaj.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lbl_mesaj.Text = "Giriş Başarısız";
                        lbl_mesaj.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lbl_sifreMesaj.Text = "Şifre Boş Bırakılamaz";
                }
            }
            else
            {
                lbl_kadiMesaj.Text = "Kullanıcı Adı Boş bırakılamaz";
            }

        }
    }
}