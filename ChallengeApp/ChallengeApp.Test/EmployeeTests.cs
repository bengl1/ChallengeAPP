
namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenCorrectMax()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act;
            var statistics = employee.GetStatistics;
            //assert;

            Assert.AreEqual(6, statistics().Max);
        }
        [Test]
        public void WhenCorrectMin()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act;
            var statistics = employee.GetStatistics;
            //assert;

            Assert.AreEqual(2, statistics().Min);
        }
        [Test]
        public void WhenCorrectAverage()
        {
            //arrange;
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act;
            var statistics = employee.GetStatistics;
            //assert;

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics().Average, 2));
        }

    }
}
