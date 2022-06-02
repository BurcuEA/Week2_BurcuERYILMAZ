using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.ISP
{
    public interface IMusteri
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Adres { get; set; }
    }
    public interface IMaas
    {
        decimal MaasHesapla(decimal tutar);
    }
    public interface IPersonel:IMaas 
    {
        string CalisanSayisi();
    }

    public class PersonelMusteri : IMusteri,IMaas 
    {
        // interface'de ortak olan alanlar..
        public int Id { get; set; }
        public string  Ad { get; set; }
        public string Adres { get; set; }

        // interface'de olmayıp PersonelMusteri classına ait olan alanlar..
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public DateTime DogumTarihi { get; set; }

        public decimal MaasHesapla(decimal brut)
        {
            return brut;
        }
    }

    public class SirketMusteri : IMusteri,IPersonel 
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }

        // interface'de olmayıp SirketMusteri classına ait olan alanlar..
        public int IsyeriId { get; set; }
        public int BirimId { get; set; }
        public int PozisyonId { get; set; }
        public DateTime KurulusTarihi { get; set; }

        public string CalisanSayisi()
        {
            return "Çalışan sayısı ...";
        }

        public decimal MaasHesapla(decimal tutar)
        {
            return tutar;
        }
    }




}
