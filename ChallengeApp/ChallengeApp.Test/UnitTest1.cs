namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenScoreSumThenCorrectResult()
        {
            //arrange;
            var user = new User("Piotr", "password", "2");
            user.AddScore(5);
            user.AddScore(6);
            //act;
            var result = user.Result;
            //assert;
            Assert.AreEqual(11, result);
        }
    }
}