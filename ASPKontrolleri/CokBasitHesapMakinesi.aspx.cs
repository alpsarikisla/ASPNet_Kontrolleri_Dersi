using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class CokBasitHesapMakinesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_topla_Click(object sender, EventArgs e)
        {
            //!string.IsNullOrEmpty(tb_sayi1.Text)
            //tb_sayi1'in Text kısmı Null veya boş değil ise

            if (!string.IsNullOrEmpty(tb_sayi1.Text) && !string.IsNullOrEmpty(tb_sayi2.Text))
            {
                double sayi1 = Convert.ToDouble(tb_sayi1.Text);
                double sayi2 = Convert.ToDouble(tb_sayi2.Text);
                double toplam = sayi1 + sayi2;
                tb_sonuc.Text = Convert.ToString(toplam);
            }
            else
            {
                lbl_mesaj.Text = "Sayı 1 Veya Sayı 2 Boş bırakılamaz";
            }
        }

        protected void btn_cikar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sayi1.Text) && !string.IsNullOrEmpty(tb_sayi2.Text))
            {
                double sayi1 = Convert.ToDouble(tb_sayi1.Text);
                double sayi2 = Convert.ToDouble(tb_sayi2.Text);
                double fark = sayi1 - sayi2;
                tb_sonuc.Text = Convert.ToString(fark);
            }
            else
            {
                lbl_mesaj.Text = "Sayı 1 Veya Sayı 2 Boş bırakılamaz";
            }
        }

        protected void btn_carp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sayi1.Text) && !string.IsNullOrEmpty(tb_sayi2.Text))
            {
                double sayi1 = Convert.ToDouble(tb_sayi1.Text);
                double sayi2 = Convert.ToDouble(tb_sayi2.Text);
                double carp = sayi1 * sayi2;
                tb_sonuc.Text = Convert.ToString(carp);
            }
            else
            {
                lbl_mesaj.Text = "Sayı 1 Veya Sayı 2 Boş bırakılamaz";
            }
        }

        protected void btn_bol_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sayi1.Text) && !string.IsNullOrEmpty(tb_sayi2.Text))
            {
                double sayi1 = Convert.ToDouble(tb_sayi1.Text);
                double sayi2 = Convert.ToDouble(tb_sayi2.Text);
                double bolum = sayi1 / sayi2;
                tb_sonuc.Text = Convert.ToString(bolum);
            }
            else
            {
                lbl_mesaj.Text = "Sayı 1 Veya Sayı 2 Boş bırakılamaz";
            }
        }
    }
}