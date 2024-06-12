using MarketToptanci.BL;
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
    public partial class Firmalar : Form
    {
        public Firmalar()
        {
            InitializeComponent();
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {

        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            FormFirma formFirma = new FormFirma()
            {
                Text = "Urun Ekle",
                Firma = new Firma() { ID = Guid.NewGuid() },
            };
            var sonuc = formFirma.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FirmaEkle(formFirma.Firma);

                if (b)
                {
                    DataSet ds = BLogic.FirmaGetir("");
                    dataGridView3.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnFirmaBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.FirmaGetir(toolStripTextBox3.Text);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnFirmaDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            FormFirma formFirma = new FormFirma()
            {
                Text = "Firma Düzenle",
                Duzenleme = true,
                Firma = new Firma()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Adres = row.Cells[2].Value.ToString(),
                    Tel = row.Cells[3].Value.ToString(),
                    Email = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = formFirma.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FirmaDuzenle(formFirma.Firma);

                if (b)
                {
                    DataSet ds = BLogic.FirmaGetir("");
                    dataGridView3.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var ID = Guid.Parse(row.Cells[0].Value.ToString());

            var sonuc = MessageBox.Show("Seçili kaydın silinmesini istiyor musunuz ? ?", "Evet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.FirmaSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.FirmaGetir("");
                    dataGridView3.DataSource = ds.Tables[0];
                }
            }
        }

        public Firma Firma { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            Firma = new Firma()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Adres = row.Cells[2].Value.ToString(),
                Tel = row.Cells[3].Value.ToString(),
                Email = row.Cells[4].Value.ToString(),
            };
  
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
