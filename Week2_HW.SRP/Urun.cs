using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.SRP
{
    #region "Doğru Kullanım"

    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Marka { get; set; }
    }

    public interface IUrun
    {
        decimal OranUygula(decimal a, int b);
        decimal KesintiUygula(decimal a, decimal b);
    }

    public class UrunHesap : IUrun
    {
        public decimal OranUygula(decimal tutar, int oran)
        {
            return tutar * oran;
        }
        public decimal KesintiUygula(decimal tutar, decimal aylikkesinti)
        {
            return tutar - aylikkesinti;
        }
    }

    #endregion 

    #region "Hatalı Kullanım"

    // Prop lar tanımlandı ve metodlar aynı classta tanımlanıp bir classın tek bir işten sorumlu olması kuralı çiğnendi..
    public class Yanlis_SRP
    {
        // Aynı class'a Prop lar tanımlandı
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Aynı class'a Formüller eklendi
        public decimal OranUygula(decimal tutar, int oran)
        {
            return tutar / oran;
        }
        public decimal KesintiUygula(decimal tutar, decimal aylikkesinti)
        {
            return tutar - aylikkesinti;
        }
    }
  #endregion 

}
