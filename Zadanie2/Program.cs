Dictionary<string, int> cennik = new Dictionary<string, int>
{
    {"Miecz", 100 },
    {"Tarcza", 75},
    {"Mikstura", 20}
};

Console.WriteLine("Ceny dostępnych przedmiotów: ");
foreach (KeyValuePair<string, int> item in cennik)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

string? nowyPrzedmiot;
while (true)
{
    Console.WriteLine("Podaj nazwe przedmiotu który chcesz dodać do oferty: ");
    nowyPrzedmiot = Console.ReadLine();

    if (int.TryParse(nowyPrzedmiot, out _))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być liczbą.");
        continue;
    }

    if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być pusta :C");
        continue;
    }
    if (cennik.ContainsKey(nowyPrzedmiot))
    {
        Console.WriteLine("Ten przedmiot już jest w naszej ofercie, podaj inną nazwe");
        continue;
    }
    break;
}

int nowaCena;
while (true)
{
    Console.WriteLine("Podaj cene przedmiotu który chcesz dodać do oferty (Od 1 do 100): ");
    bool correctNowaCena = int.TryParse(Console.ReadLine(), out nowaCena);
    if (!correctNowaCena)
    {
        Console.WriteLine("Podaj liczbę, nie tekst, nie liczbę po przecinku");
        continue;
    }
    if (nowaCena < 1 || nowaCena > 100)
    {
        Console.WriteLine("Podaj cene w przedziale 1 - 100");
        continue;
    }
    break;
}
cennik.Add(nowyPrzedmiot, nowaCena);

string? przedmiotWOfercie;
while (true)
{
Console.WriteLine("Podaj nazwe przedmiotu by sprawdzić, czy jest w ofercie: ");
przedmiotWOfercie = Console.ReadLine();

    if (int.TryParse(przedmiotWOfercie, out _))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być liczbą.");
        continue;
    }
    if (string.IsNullOrWhiteSpace(przedmiotWOfercie))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być pusta :C");
        continue;
    }
    if (cennik.ContainsKey(przedmiotWOfercie))
    {
        Console.WriteLine($"Cena {przedmiotWOfercie}: {cennik[przedmiotWOfercie]} sztuk złota");
    }
    else
    {
        Console.WriteLine("Nie mamy takiego przedmiotu w ofercie");
    }
break;
}


Console.WriteLine("Ceny dostępnych przedmiotów: ");
foreach (KeyValuePair<string, int> item in cennik)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}