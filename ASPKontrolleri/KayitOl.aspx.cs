using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kayitOl_Click(object sender, EventArgs e)
        {
            bool kaydet = true;

            lbl_isimMesaj.Text = lbl_kullaniciAdiMesaj.Text = lbl_mailMesaj.Text; lbl_mesaj.Text = lbl_sifreMesaj.Text = lbl_sifreTekrarMesaj.Text = "";
            lbl_isimMesaj.Visible = lbl_kullaniciAdiMesaj.Visible = lbl_mailMesaj.Visible = lbl_sifreMesaj.Visible = lbl_sifreTekrarMesaj.Visible = false;

            if (string.IsNullOrEmpty(tb_isim.Text)) {
                kaydet = false;
                lbl_isimMesaj.Visible = true;
                lbl_isimMesaj.Text = "İsim boş bırakılamaz";
            }
            if (string.IsNullOrEmpty(tb_kullaniciAdi.Text))
            {
                kaydet = false;
                lbl_kullaniciAdiMesaj.Visible = true;
                lbl_kullaniciAdiMesaj.Text = "Kullanıcı Adı Boş Bırakılamaz";
            }
            if (string.IsNullOrEmpty(tb_mail.Text)) {
                kaydet = false;
                lbl_mailMesaj.Visible = true;
                lbl_mailMesaj.Text = "Mail AdresiBoş Bırakılamaz";
            }
            else
            {
                if (!tb_mail.Text.Contains('@'))
                {
                    kaydet = false;
                    lbl_mailMesaj.Visible = true;
                    lbl_mailMesaj.Text = "Mail adresiniz hatalı";
                }
            }
            if (string.IsNullOrEmpty(tb_sifre.Text)) 
            {
                kaydet = false;
                lbl_sifreMesaj.Visible = true;
                lbl_sifreMesaj.Text = "Şİfre boş bırakılamaz";
            }
            if(tb_sifre.Text != tb_sifreTekrar.Text)
            {
                kaydet = false;
                lbl_sifreTekrarMesaj.Visible = true;
                lbl_sifreTekrarMesaj.Text = "Şifreler uyuşmuyor";
            }

            if (kaydet== true) {
                lbl_mesaj.Text = "Kayıt Başarılı";
            }
        }
    }
}