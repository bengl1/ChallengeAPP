
var name = "Ewa";
var age = 33;
char gender = 'k';
if( age == 33 && name == "Ewa" && gender == 'k')
{
    Console.WriteLine(name+ ", lat "+age );
}
else if( age < 30 && gender == 'k')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(age < 18 && gender != 'k')
{
    Console.WriteLine("Mężczyzna niepełnoletni ");
}