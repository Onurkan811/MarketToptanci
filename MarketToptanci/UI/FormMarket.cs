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
    public partial class FormMarket : Form
    {
        public FormMarket()
        {
            InitializeComponent();
        }

        private void FormMarket_Load(object sender, EventArgs e)
        {
            txtID.Text = Market.ID.ToString();
            if (Duzenleme)
            {
                txtAd.Text = Market.Ad;
                txtAdres.Text = Market.Adres;
                txtMail.Text = Market.Email;
                txtTel.Text = Market.Tel;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtAdres)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtTel)) return;

            Market.Ad = txtAd.Text;
            Market.Adres = txtAdres.Text;
            Market.Email = txtMail.Text;
            Market.Tel = txtTel.Text;

            DialogResult = DialogResult.OK;
        }

        public Market Market { get; set; }
        public bool Duzenleme { get; set; } = false;
        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
            if(c is TextBox)
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
