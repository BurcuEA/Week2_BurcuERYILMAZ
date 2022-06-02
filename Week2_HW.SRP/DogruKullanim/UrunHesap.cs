using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_HW.SRP
{
    public class UrunHesap : IUrun
    {
        public decimal OranUygula(decimal tutar,int oran)
        {
            return tutar * oran;
        }
        public decimal KesintiUygula(decimal tutar,decimal aylikkesinti)
        {
            return tutar-aylikkesinti ;
        }

    }
}
