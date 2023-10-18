using ChallengeApp;

User user1 = new User("Robert ", "Kowalski ", "22 lata "); 
User user2 = new User("Paweł ", "Nowak ", "32 lata ");
User user3 = new User("Igor ", "Dudek ", "30 lat ");

user1.AddScore(7);
user1.AddScore(2);
user1.AddScore(9);

user2.AddScore(5);
user2.AddScore(7);
user2.AddScore(3);

user3.AddScore(4);
user3.AddScore(4);
user3.AddScore(7);

List<User> users = new List<User>()
    {
         user1, user2, user3
    };

int maxResult = 0;
User UserWithMaxResult = null;

foreach (var user in users)
{
    if(user.Result > maxResult)
    {
        UserWithMaxResult = user;
    }
}

Console.WriteLine(UserWithMaxResult.Name + UserWithMaxResult.Surname + UserWithMaxResult.Age +
    "Uzyskał najwyższą ocenę "+ UserWithMaxResult.Result);