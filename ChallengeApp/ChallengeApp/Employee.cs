namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string Name, string Surname, string Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
