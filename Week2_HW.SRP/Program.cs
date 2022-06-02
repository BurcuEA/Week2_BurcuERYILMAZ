// Single Resposibility Principle

using Week2.SRP;

Urun r = new Urun();
r.Adi = "Buzdolabı";
r.Marka = "Arçelik";
Console.WriteLine($"Yeni Ürün : {r.Adi} - {r.Marka}");

UrunHesap rHes = new UrunHesap();
rHes.OranUygula(3M,5);
rHes.KesintiUygula(10M,20M);
Console.WriteLine($"Yeni Ürün Oranlı Fiyatı : {rHes.OranUygula(3M, 5)}  - Yeni Ürün Kesintili Fiyatı :  {rHes.KesintiUygula(100M, 20M)}");








