using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class CheckBoxRadioButtonKontrolleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kayitol_Click(object sender, EventArgs e)
        {
            //lbl_mesaj.Text = Convert.ToString(cb_onay.Checked);
            if (cb_onay.Checked)
            {
                lbl_mesaj.Text = "Kayıt Başarılı";
            }
            else
            {
                lbl_mesaj.Text = "Kayıt olabilmek için kullanıcı sözleşmesini onaylamanız gerekmektedir";
            }
        }

        protected void btn_sec_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            string medeniHal = "";
            if (rb_erkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            if(rb_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            if(rb_evli.Checked)
            {
                medeniHal = "Evli";
            }
            if(rb_bekar.Checked)
            {
                medeniHal = "Bekar";
            }
            lbl_cinsiyet.Text = "Cinsiyet = " + cinsiyet + " Medeni Hal = " + medeniHal;
        }
    }
}