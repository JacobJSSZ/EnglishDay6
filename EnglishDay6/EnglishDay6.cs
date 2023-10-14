namespace EnglishDay6
{
    public class Drudger
    {
        private List<int> result = new List<int>();

        public Drudger(string name, string surname, string years)
        {
            this.Name = name;
            this.Surname = surname;
            this.Years = years;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Years { get; private set; }

        public int Ultimate_Solution
        {
            get
            {
                return this.result.Sum();
            }
        }
        public int Ultimate_Solution2
        {
            get
            {
                return this.result.Sum();
            }
        }
        public int Ultimate_Solution3
        {
            get
            {
                return this.result.Sum();
            }
        }
        public void AddScore(int result)
        {
            this.result.Add(result);
        }
    }
}
