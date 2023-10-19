using ChallengeApp;

Employee user1 = new Employee("Robert ", "Kowalski ", "22 lata "); 
Employee user2 = new Employee("Paweł ", "Nowak ", "32 lata ");
Employee user3 = new Employee("Igor ", "Dudek ", "30 lat ");

user1.AddScore(7);
user1.AddScore(2);
user1.AddScore(9);

user2.AddScore(5);
user2.AddScore(7);
user2.AddScore(3);

user3.AddScore(4);
user3.AddScore(4);
user3.AddScore(7);

List<Employee> users = new List<Employee>()
    {
         user1, user2, user3
    };

int maxResult = 0;
Employee UserWithMaxResult = null;

foreach (var user in users)
{
    if(user.Result > maxResult)
    {
        maxResult = user.Result;
        UserWithMaxResult = user;
    }
}

Console.WriteLine(UserWithMaxResult.Name + UserWithMaxResult.Surname + UserWithMaxResult.Age +
    "Uzyskał najwyższą ocenę "+ UserWithMaxResult.Result);