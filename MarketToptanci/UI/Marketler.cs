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
    public partial class Marketler : Form
    {
        public Marketler()
        {
            InitializeComponent();
        }

        private void Marketler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MarketGetir("");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMarketEkle_Click(object sender, EventArgs e)
        {
            FormMarket formMarket = new FormMarket()
            {
                Text = "Market Ekle",
                Market = new Market() { ID = Guid.NewGuid() },
            };
            var sonuc = formMarket.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MarketEkle(formMarket.Market);

                if (b)
                {
                    DataSet ds = BLogic.MarketGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnMarketBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MarketGetir(toolStripTextBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void btnMarketDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FormMarket formMarket = new FormMarket()
            {
                Text = "Market Düzenle",
                Duzenleme = true,
                Market = new Market()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Adres = row.Cells[2].Value.ToString(),
                    Tel = row.Cells[3].Value.ToString(),
                    Email = row.Cells[4].Value.ToString(),
                },
            };

            var sonuc = formMarket.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MarketDuzenle(formMarket.Market);

                if (b)
                {
                    DataSet ds = BLogic.MarketGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnMarketSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = Guid.Parse(row.Cells[0].Value.ToString());

            var sonuc = MessageBox.Show("Seçili kaydın silinmesini istiyor musunuz ? ?", "Evet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MarketSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.MarketGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
