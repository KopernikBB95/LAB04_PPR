List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Mapa"};

Console.WriteLine("Lista przedmiotów: ");
foreach (string item in plecak)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"Liczba przedmiotów w plecaku: {plecak.Count}");

string nowyPrzedmiot;
while (true)
{
    Console.WriteLine("Podaj nazwe przedmiotu który chcesz dodać do plecaka: ");
    nowyPrzedmiot = Console.ReadLine();
    if (int.TryParse(nowyPrzedmiot, out _))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być liczbą.");
        continue;
    }
    if (string.IsNullOrWhiteSpace(nowyPrzedmiot))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być pusta.");
        continue;
    }
    break;
}
plecak.Add(nowyPrzedmiot);

Console.WriteLine("Lista przedmiotów: ");
foreach (string item in plecak)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"Liczba przedmiotów w plecaku: {plecak.Count}");

string usunPrzedmiot;
while (true)
{
    Console.WriteLine("Podaj nazwe przedmiotu który chcesz usunąć z plecaka: ");
    usunPrzedmiot = Console.ReadLine();
    if (int.TryParse(usunPrzedmiot, out _))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być liczbą.");
        continue;
    }
    if (string.IsNullOrWhiteSpace(usunPrzedmiot))
    {
        Console.WriteLine("Nazwa przedmiotu nie może być pusta.");
        continue;
    }
    if (!plecak.Contains(usunPrzedmiot))
    {
        Console.WriteLine("Nie ma takiego przedmiotu w plecaku");
        continue;
    }
    break;
}
bool usunieto = plecak.Remove(usunPrzedmiot);
if (usunieto)
{
    Console.WriteLine($"Usunięto przedmiot {usunPrzedmiot} z plecaka");
}

Console.WriteLine("Lista przedmiotów: ");
foreach (string item in plecak)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine($"Liczba przedmiotów w plecaku: {plecak.Count}");