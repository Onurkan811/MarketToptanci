using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketToptanci.UI
{
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        public Firma Firma { get; set; }
        public bool Duzenleme { get; set; } = false;
        private void FormFirma_Load(object sender, EventArgs e)
        {      
            txtID.Text = Firma.ID.ToString();
            if (Duzenleme)
            {
                txtAd.Text = Firma.Ad;
                txtAdres.Text = Firma.Adres;
                txtMail.Text = Firma.Email;
                txtTel.Text = Firma.Tel;
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtAdres)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtTel)) return;

            Firma.Ad = txtAd.Text;
            Firma.Adres = txtAdres.Text;
            Firma.Email = txtMail.Text;
            Firma.Tel = txtTel.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya Hatalı Bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
