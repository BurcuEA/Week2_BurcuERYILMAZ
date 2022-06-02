// Interface Seggregeation Principle

using Week2.ISP;

PersonelMusteri pMusteri = new PersonelMusteri();
pMusteri.Id = 1;
pMusteri.Ad = "Özge";
pMusteri.Adres = "Kadıköy/İstanbul..";

pMusteri.Soyad = "Yılmaz";
pMusteri.Yas = 20;

Console.WriteLine($"Musteri Interface'i ile gelen ortak alanlar : Id :{pMusteri.Id} ,Ad : {pMusteri.Ad} ,Adres :{pMusteri.Adres}");
Console.WriteLine($"Personel maaşı : {pMusteri.MaasHesapla(5004M)}");
//pMusteri.CalisanSayisi() metodu gelmez

//pMusteri.KurulusTarihi ya da diğer  SirketMusteri classına özel olan alanlar gelmemeli

SirketMusteri sMusteri = new SirketMusteri();
sMusteri.Id = 5;
sMusteri.Ad = "A Marketleri";
sMusteri.Adres = "Maltepe/Ankara..";

sMusteri.IsyeriId = 6;
sMusteri.KurulusTarihi = DateTime.Today;

Console.WriteLine($"Farklı alanlardan bazıları : Şirket IsyeriId :{sMusteri.IsyeriId} ");
Console.WriteLine($"{sMusteri.CalisanSayisi()}");
Console.WriteLine($"Şirkette hesaplanan maaş : {sMusteri.MaasHesapla(2*5004M)}");

//sMusteri.DogumTarihi ya da diğer  PersonelMusteri classına özel olan alanlar gelmemeli


