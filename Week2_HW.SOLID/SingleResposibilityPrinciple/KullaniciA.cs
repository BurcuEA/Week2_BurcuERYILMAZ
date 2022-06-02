using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_HW.SOLID.SingleResposibilityPrinciple
{
    //SingleResposibilityPrinciple
    public class KullaniciSingle  

    {
        private IOzelHesap _ozelHesap;
        public KullaniciSingle(IOzelHesap ozelHesap)
        {
            _ozelHesap = ozelHesap;
        }

        public decimal OzelHesapYap()
        {
            return _ozelHesap.Formul1Uygula();
        }
    }
}
