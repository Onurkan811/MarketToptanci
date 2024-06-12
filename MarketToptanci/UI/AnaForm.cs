using MarketToptanci.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketToptanci.BL;

namespace MarketToptanci
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        
        private void AnaForm_Load(object sender, EventArgs e)
        {
        }

        private void btnMarketler_Click(object sender, EventArgs e)
        {
            new Marketler().ShowDialog();
        }

        private void btnFirmalar_Click(object sender, EventArgs e)
        {
            new Firmalar().ShowDialog();
        }
    }
}
