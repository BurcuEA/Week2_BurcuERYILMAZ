namespace Week2.POLY
{
    public interface IIslem
    {
        void GorevYap(string str);
        void MaasHesapla(string str);
    }

    public class Personel : IIslem
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";

        public string Unvan { get; set; }

        public void GorevYap(string gorevCesit)
        {
            Console.WriteLine($"{FullName} isimli kullanıcı {gorevCesit}  görevinden sorumludur.");

            this.MaasHesapla(FullName);
        }

        // virtual keyword'ü kullanılarak MaasHesapla metodunun override edilebilmesi sağlandı
        public virtual void MaasHesapla(string fName)
        {
            Console.WriteLine($"{fName} personeline ait STANDART maaş hesabı yapıldı..");
        }
    }
    public class Yonetici : Personel
    {
        // MaasHesapla metodu ezilerek Polymorphism uygulanmış oldu.
        public override void MaasHesapla(string fName)
        {
            Console.WriteLine($"{fName} personeline ait YÖNETİCİ maaş hesabı yapıldı..");
        }        
    }
    public class Calisan : Personel
    {
        public override void MaasHesapla(string fName)
        {
            Console.WriteLine($"{fName} personeline ait ÇALIŞAN maaş hesabı yapıldı..");
        }
    }
}
