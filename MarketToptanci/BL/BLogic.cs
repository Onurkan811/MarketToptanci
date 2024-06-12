using MarketToptanci.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketToptanci.BL
{
    public static class BLogic
    {
        public static bool MarketEkle(Market m)
        {
            int res = DataLayer.MarketEkle(m);
            return (res > 0);

        }

        internal static bool FirmaDuzenle(Firma f)
        {
            int res = DataLayer.FirmaDuzenle(f);
            return (res > 0);
        }

        internal static bool FirmaEkle(Firma f)
        {
            int res = DataLayer.FirmaEkle(f);
            return (res > 0);
        }

        internal static DataSet FirmaGetir(string filtre)
        {
            DataSet ds = DataLayer.FirmaGetir(filtre);
            return ds;
        }

        internal static bool FirmaSil(Guid id)
        {
            int res = DataLayer.FirmaSil(id);
            return (res > 0);
        }

        internal static bool MarketDuzenle(Market m)
        {
            int res = DataLayer.MarketDuzenle(m);
            return (res > 0);
        }

        internal static DataSet MarketGetir(string filtre)
        {
            DataSet ds = DataLayer.MarketGetir(filtre);
            return ds;
        }

        internal static bool MarketSil(Guid id)
        {
            int res = DataLayer.MarketSil(id);
            return (res > 0);
        }

        internal static bool UrunEkle(Urun u)
        {
            int res = DataLayer.UrunEkle(u);
            return (res > 0);
        }

        internal static DataSet UrunGetir(string filtre)
        {
            DataSet ds = DataLayer.UrunGetir(filtre);
            return ds;
        }
    }
}
