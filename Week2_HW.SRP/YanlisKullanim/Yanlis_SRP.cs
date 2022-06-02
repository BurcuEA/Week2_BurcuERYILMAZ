using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_HW.SRP
{
    // Prop lar tanımlandı ve metodlar aynı classta tanımlanıp bir classın tek bir işten sorumlu olması kuralı çiğnendi..
    public class Yanlis_SRP
    {
        // Prop lar tanımlandı
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Formüller eklendi
        public decimal OranUygula(decimal tutar, int oran)
        {
            return tutar / oran;
        }
        public decimal KesintiUygula(decimal tutar, decimal aylikkesinti)
        {
            return tutar - aylikkesinti;
        }
    }


}
