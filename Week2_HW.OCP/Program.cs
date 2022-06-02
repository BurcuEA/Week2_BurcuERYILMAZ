// Open Closed Principle

using Week2.OCP;

Musteri m1 = new Musteri();

// İstenen hangi formül kullanılacaksa sadece onu belirtmek yeterli. MusteriMaasHesapla(fm2) paramtresini değiştirmek yeterli.
//Formul1Uygula fm1 = new Formul1Uygula();
Formul2Uygula fm2 = new Formul2Uygula();

Console.WriteLine();

//MusteriMaasHesapla mHes1 = new MusteriMaasHesapla(fm1);
MusteriMaasHesapla mHes2 = new MusteriMaasHesapla(fm2);

//Console.WriteLine($"Müşterinin Maaşı : {mHes1.MaasHesapla()}");
Console.WriteLine($"Müşterinin Maaşı : {mHes2.MaasHesapla(1000,200)}");


