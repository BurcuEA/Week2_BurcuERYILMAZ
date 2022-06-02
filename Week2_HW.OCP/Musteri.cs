using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.OCP
{
    //Müşteri claas'ı gerekli değil andak Single Responsibility Prensibine uygun devam etmek amacıyla ayrı classlar ayrı görevler
    public class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal Maas { get; set; }
       
    }
    public class MusteriMaasHesapla
    {
        private IFormul _formul;          

        public MusteriMaasHesapla(IFormul formul)
        {
            _formul = formul;
        }

        public decimal MaasHesapla(decimal tutar1,decimal tutar2)
        {
            //return _formul.Hesapla(3000, 100);
            return _formul.Hesapla(tutar1, tutar2);
        }
    }
}
