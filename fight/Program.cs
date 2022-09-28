using System;

int ch1Hp = 100;
int ch2Hp = 100;

Console.WriteLine("Freja har utmanat dig till en fight");
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();


Random generator = new Random();

Console.WriteLine($"Lycka till {name}");

while (ch1Hp > 0 && ch2Hp > 0)
{
    Console.WriteLine("\n------- NY RUNDA -------");
    Console.WriteLine($"{name}: {ch1Hp}  Freja: {ch2Hp}\n");

    int ch1Damage = generator.Next(20);
    ch2Hp -= ch1Damage;
    ch2Hp = Math.Max(0, ch2Hp);
    Console.WriteLine($"{name} gör {ch1Damage} skada på Freja");

    int ch2Damage = generator.Next(20);
    ch1Hp -= ch2Damage;
    ch1Hp = Math.Max(0, ch1Hp);
    Console.WriteLine($"Freja gör {ch2Damage} skada på {name}");

    Console.WriteLine("Tryck på enter för att attackera igen");
    Console.ReadKey();
}

if (ch1Hp == 0 && ch2Hp == 0)
{
    Console.WriteLine("Oavgjort!");
}
else if (ch1Hp == 0)
{
    Console.WriteLine($"Freja vann! Du kan bättre. ");
}
else
{
    Console.WriteLine($"{name} vann! Bra jobbat!");
}

Console.WriteLine("Tryck på enter för att avsluta");
Console.ReadKey();