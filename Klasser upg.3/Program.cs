


using Klasser_upg._3;

Console.WriteLine("Ser du fågeln?");
Fågel fågel1 = new Fågel();

fågel1.setVikt(530);
fågel1.setLängd(48);
fågel1.setNamn("Kroka");

Console.WriteLine(fågel1.getNamn());
Console.WriteLine(fågel1.getVikt());
Console.WriteLine(fågel1.getLängd());


Fågel fågel2 = new Fågel();

fågel2.setVikt(5800);
fågel2.setLängd(85);
fågel2.setNamn("Örn");

Console.WriteLine(fågel2.getNamn());
Console.WriteLine(fågel2.getVikt());
Console.WriteLine(fågel2.getLängd());

