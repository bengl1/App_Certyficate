namespace CertyficateApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }

        }
        public string AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return "*";
                    case var average when average >= 60:
                        return "* *";
                    case var average when average >= 40:
                        return "* * *";
                    case var average when average >= 20:
                        return "* * * *";
                    default:
                        return "* * * * *";
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;

        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(this.Max, grade);
            this.Min = Math.Min(this.Min, grade);
        }
    }
}
