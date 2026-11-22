int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
int sumaZlota = 0;
double sredniaIlosZlota = 0;
int iloscTurDuzoZlota= 0; //tury powyzej 10 sztuk zlota
int iloscTurDuzoZlota2= 0; //tury powyzej 10 sztuk zlota

Console.WriteLine($"Ilość tur: {zlotoWTurach.Length} ");

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Złoto w turze {i + 1}: {zlotoWTurach[i]}");
}
foreach (int zloto in zlotoWTurach)
{
    sumaZlota += zloto;
}
Console.WriteLine($"Łączna ilość zdobytego złota: {sumaZlota}");

sredniaIlosZlota= (double)sumaZlota/zlotoWTurach.Length;
Console.WriteLine($"Średnia ilość złota na turę: {sredniaIlosZlota}");

foreach (int duzoZlota in zlotoWTurach)
{
    if (duzoZlota > 10)
    {
        iloscTurDuzoZlota++;
    }
}
Console.WriteLine($"Tury w których ilość złota była więszka niż 10: {iloscTurDuzoZlota}");

for (int i = 0; i < zlotoWTurach.Length; i++)
{
    if (zlotoWTurach [i] > 10)
    {
        iloscTurDuzoZlota2++;
    }
}
Console.WriteLine($"Petla for: Tury w których ilość złota była więszka niż 10: {iloscTurDuzoZlota2}");

for (int i = zlotoWTurach.Length; i > 0; i--)
{
    Console.WriteLine($"Zloto w turze {i}: {i}");
}