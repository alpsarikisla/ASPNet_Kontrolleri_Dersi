using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPKontrolleri
{
    public partial class DropDownListKontrolu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sec_Click(object sender, EventArgs e)
        {
            string secilenElemanText = ddl_Sorumlu.SelectedItem.Text;
            string secilenElemanValue = ddl_Sorumlu.SelectedItem.Value;
            lbl_secilen.Text = "Seçilen Sorumlu = " + secilenElemanText +" Numara = " + secilenElemanValue;
        }

        protected void ddl_sinifBaskani_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenElemanText = ddl_sinifBaskani.SelectedItem.Text;
            string secilenElemanValue = ddl_sinifBaskani.SelectedItem.Value;
            lbl_secilenBaskan.Text = "Seçilen Başkan = " + secilenElemanText + " Numara = " + secilenElemanValue;
        }

        protected void btn_eklenecek_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_eklenecek.Text))
            {
                ddl_ekleneler.Items.Add(tb_eklenecek.Text);
                tb_eklenecek.Text = "";
            }
        }

        protected void btn_yazdir_Click(object sender, EventArgs e)
        {
            lbl_secilmis.Text = "Text = " + ddl_ekleneler.SelectedItem.Text + " Value = " + ddl_ekleneler.SelectedItem.Value;
        }
    }
}