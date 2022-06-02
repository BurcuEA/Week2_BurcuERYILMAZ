using Week2.POLY;

//Polymorphism : Bir nesne elemanının farklı ortamlarda farklı sonuçlar üretmesi.

Personel prs = new Personel();
prs.Name = "Ali";
prs.Surname = "Yılmaz";
prs.Unvan = "Akademisyen";
//prs.MaasHesapla(prs.FullName);
prs.GorevYap(prs.Unvan);

Console.WriteLine();

Yonetici yon = new Yonetici();
yon.Name = "Veli";
yon.Surname = "Yılmaz";
yon.Unvan = "Müdür";
yon.GorevYap(yon.Unvan);

Console.WriteLine();

Calisan cl = new Calisan();
cl.Name = "Sude";
cl.Surname = "Yılmaz";
cl.Unvan = "Yazılım Uzmanı";
cl.GorevYap(cl.Unvan);
