
namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenCorrectMax()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade('c');
            employee.AddGrade(100);
            employee.AddGrade(80);

            //act;
            var statistics = employee.GetStatistics();
            //assert;

            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void WhenCorrectMin()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade(27);
            employee.AddGrade('a');
            employee.AddGrade(6);

            //act;
            var statistics = employee.GetStatistics();
            //assert;

            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void WhenCorrectAverage()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade('d');
            employee.AddGrade(20);
            employee.AddGrade(60);

            //act;
            var statistics = employee.GetStatistics();
            //assert;

            Assert.AreEqual('C', statistics.AverageLetter);
        }

    }
}
