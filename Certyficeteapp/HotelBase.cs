namespace CertyficateApp
{
    public abstract class HotelBase : IHotel
    {

            public delegate void GradeAddedDelegate(object sender, EventArgs args);

            public abstract event GradeAddedDelegate GradeAdded;


            public HotelBase(string name, string town)

            {
                this.Name = name;
                this.Town = town;
            }

            public string Name { get; private set; }

            public string Town { get; private set; }

            public abstract void AddGrade(float grade);


        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
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


        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }



        public  void AddGrade(string grade)
        {
                 if (float.TryParse(grade, out float result))
                 {
                this.AddGrade(result);
                 }
                 else if (grade.Length == 1)
                 {
                char gradelet = char.Parse(grade);
                AddGrade(gradelet);
                 }
                 else
                 {
                throw new Exception("String is not float");
                 }
        }


        public abstract Statistics GetStatistics();

            public void metoda()
        {

        }

        
    }

}
