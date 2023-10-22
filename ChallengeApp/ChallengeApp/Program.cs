var name = "Ewa";
var plec = "kobieta";
int age = 33;

if (plec == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && plec == "kobieta" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (plec == "mezczyzna" && age > 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niepoprawne dane");
}
