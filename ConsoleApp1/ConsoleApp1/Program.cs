//zadanie domowe dzień 4

string name = "Ewa";
int age = 33;
bool woman = true;

if (age == 33 && name == "Ewa" && woman == true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 30 && !(name == "Ewa") && woman == true)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && !(name == "Ewa") && woman == false) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
      