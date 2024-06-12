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
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            foreach (var firma in Firma.ToString())
            {
                cbFirma.Items.Add(firma);
            }
            txtID.Text = Urun.ID.ToString();
        }

        private void txtUrun_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Urun Urun { get; set; }
        public Firma Firma { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrun)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(cbFirma)) return;

            Urun.Ad = txtUrun.Text;
            Urun.Kategori = cbKategori.Text;
            Urun.Fiyat = nmFiyat.Value;
            Urun.Miktar = (int)nmStok.Value;
            Urun.Firma = (Firma)cbFirma.SelectedItem;



            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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

            return true;
        }
    }
}
