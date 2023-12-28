using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone s1 = new Nokia("11943211234", "X2-01", "351122334455", 256);
Smartphone s2 = new Iphone("11987655678", "Iphone 11 Pro", "355544332211", 512);

Console.Write($"Aparelho {s2.Numero}: ");
s2.Ligar();
Console.Write($"Aparelho {s1.Numero}: ");
s1.ReceberLigacao();

s1.InstalarAplicativo("Whats App");
s2.InstalarAplicativo("Clash of Clans");
