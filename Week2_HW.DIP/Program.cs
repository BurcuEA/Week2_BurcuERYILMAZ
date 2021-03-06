//Dependency Inversion Principle

using Week2.DIP;

Email m = new Email();
m.Kime = "abc@gmail.com";
m.Icerik = "Sayın Ali Yılmaz ";
Bildirim bldr = new Bildirim(m);
Console.WriteLine($"{bldr.SendBildirim()}");

Console.WriteLine();

Sms s = new Sms();
s.TelNo = "0555 555 55 55";
s.Icerik = "Sayın Ayşe Yaşar ";
bldr = new Bildirim(s);
Console.WriteLine($"{bldr.SendBildirim()}");

Console.WriteLine();

Whatsapp wu = new Whatsapp();
wu.TelNo = "0555 555 55 55";
wu.Icerik = "Sayın Burçin Adalı ";
bldr = new Bildirim(wu);
Console.WriteLine($"{bldr.SendBildirim()}");

