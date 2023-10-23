var name = "Ewa";
var sex = "kobieta";
var age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "kobieta" && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Złe dane");
}
