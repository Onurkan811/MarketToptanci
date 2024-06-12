using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketToptanci
{
    public class Market
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Ad}";
        }
    }

    public class Firma
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Ad}";
        }
    }

    public class Urun
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public int Miktar { get; set; }
        public Firma Firma { get; set; }

        public override string ToString()
        {
            return $"{Fiyat}-{Ad} {Fiyat}$";
        }
    }

    public enum StokHareketTur
    {
        Giris,
        Cikis
    }

    public class Hareketler
    {
        public Guid ID { get; set; }
        public Urun Urun { get; set; }
        public DateTime Tarih { get; set; }
        public StokHareketTur Tur { get; set; }
    }

    public class Siparis
    {
        public Guid ID { get; set; }
        public Market Market { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public List<SiparisDetaylari> SiparisDetaylari { get; set; }
    }

    public class SiparisDetaylari
    {
        public Guid ID { get; set; }
        public Siparis Siparis { get; set; }
        public Urun Urun { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}

