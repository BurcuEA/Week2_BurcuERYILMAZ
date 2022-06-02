// Open Closed Principle

using Week2_HW.OCP;

Console.WriteLine("Hello, World!");

Musteri m1 = new Musteri();


//Formul1Uygula fm1 = new Formul1Uygula();
Formul2Uygula fm2 = new Formul2Uygula();

//MusteriMaasHesapla mHes1 = new MusteriMaasHesapla(fm1);
MusteriMaasHesapla mHes2 = new MusteriMaasHesapla(fm2);

//Console.WriteLine($"Müşterinin Maaşı : {mHes1.MaasHesapla()}");
Console.WriteLine($"Müşterinin Maaşı : {mHes2.MaasHesapla(1000,200)}");


