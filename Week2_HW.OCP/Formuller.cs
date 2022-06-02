using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.OCP
{

    //Mevcut olan Formul1Uygula ve Formul2Uygula classları diye düşnelim.
    public class Formul1Uygula : IFormul
    {      
        public decimal Hesapla(decimal a, decimal b)
        {
            return a * b;
        }
    }
    public class Formul2Uygula : IFormul
    {
        public decimal Hesapla(decimal a, decimal b)
        {
            return a + b;
        }
    }

    /* Formul3Uygula ile Formüller class'ına yeni bir formül eklenerek GENİŞLETİLMİŞ oldu,
     Formul1Uygula ve Formul2Uygula classları ise değiştirilmemiş oldu. */
    public class Formul3Uygula : IFormul
    {
        public decimal Hesapla(decimal a, decimal b)
        {
            return (a + b) + (a*2);
        }
    }


}
