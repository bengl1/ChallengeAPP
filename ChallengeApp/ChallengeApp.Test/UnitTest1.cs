namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenScoreSumThenCorrectResult()
        {
            //arrange;
            var student = new User("Piotr", "password", "2");
            student.AddScore(-2);
            student.AddScore(3);
            student.AddScore(-1);
            student.AddScore(8);
            student.AddScore(0);
            student.AddScore(6);
            student.AddScore(11);
            student.AddScore(7);
            //act;
            var result = student.Result;
            //assert;
            Assert.AreEqual(32, result);
        }
    }
}