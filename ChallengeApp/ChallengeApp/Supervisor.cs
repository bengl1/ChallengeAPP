namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name,string surname)
            { 
            this.Name = name;
            this.Surname = surname;            
            }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(double grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
        }


        public void AddGrade(int grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            
        }
        public void AddGrade(string grade)
        {
            switch(grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-"or"-6":
                    this.AddGrade(95);
                    break;
                case "5+" or "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-" or "-5":
                    this.AddGrade(75);
                    break;
                case "4+" or "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-" or "-4":
                    this.AddGrade(55);
                    break;
                case "3+" or "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-" or "-3":
                    this.AddGrade(35);
                    break;
                case "2+" or "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-" or "-2":
                    this.AddGrade(15);
                    break;
                case "1+" or "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;

            }
        }

        public void AddGrade(char grade)
        {
            grade = char.ToUpper(grade);
            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }

        public Statistics GetStatistics()
        {
            return new Statistics ();
        }
    }
}
