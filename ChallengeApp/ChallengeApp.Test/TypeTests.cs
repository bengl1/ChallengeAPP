namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void TestFloatEqual()
        {
            //arrange;
            float number1 = 12211;
            float number2 = 1551151555;

            //act;

            //assert;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestDoubleEqual()
        {
            //arrange;
            double number1 = 11.3;
            double number2 = 18.2;

            //act;

            //assert;

            Assert.AreNotEqual(number1, number2);
        }
        
        [Test]
        public void TestIntEqual()
        {
            //arrange;
            int number1 = 1;
            int number2 = 2;
            
            //act;

            //assert;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange;
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //act;

            //assert;


            Assert.AreNotEqual(user1, user2);
        }
        private User GetUser(string name) 
        {
            return new User(name);
        }
    }
}
