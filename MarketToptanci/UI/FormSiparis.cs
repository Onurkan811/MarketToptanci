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
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            foreach (var market in Market.ToString())
            {
                cbMarket.Items.Add(market);
            }
            txtID.Text = Siparis.ID.ToString();
        }
        public Market Market { get; set; }

        public SiparisDetaylari Detay { get; set; }

        public Siparis Siparis { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen Fiyat Giriniz");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Siparis.Market = (Market)cbMarket.SelectedItem;
            Siparis.SiparisTarihi = dtSiparis.Value;
            Siparis.TeslimTarihi = dtTeslim.Value;
            Siparis.ToplamTutar = nmFiyat.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
