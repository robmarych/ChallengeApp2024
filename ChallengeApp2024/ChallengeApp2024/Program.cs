string name = "Ewa";
int age = 30;
bool  isWomen =false;  ///false kobieta ,truue 

if(isWomen && age < 30 )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30 && isWomen)
{
    Console.WriteLine("Ewa ma 30 lat ");
}
else if (!isWomen && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna ");
}
else
{
    Console.WriteLine("Nie spełnione jest warunke");
}
