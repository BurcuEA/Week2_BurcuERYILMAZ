// Liskov's Subsititution Principle

//Kus kKus = new Kus(); abstract class

using Week2.LSP;

Kus kKus = new Tavuk();
//Console.WriteLine($"{kKus.AyakSayisi()}");
Console.WriteLine($"Tavuk----{kKus.Ses()}");
Console.WriteLine($"{kKus.Yuru()}");

kKus = new Ordek();
Console.WriteLine($"Ördek----{kKus.Ses()}");
Console.WriteLine($"{kKus.Yuru()}");
//Console.WriteLine($"{kKus.Uc}");
Console.WriteLine($"{((Ordek)kKus).Uc()}");

kKus = new Papagan();
Console.WriteLine($"Papağan----{kKus.Ses()}");
Console.WriteLine($"{kKus.Yuru()}");
Console.WriteLine($"{((Papagan)kKus).Uc()}");
Console.WriteLine($"{((Papagan)kKus).Konus()}");








