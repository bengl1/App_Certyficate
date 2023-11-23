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


            public abstract void AddGrade(double grade);


            public abstract void AddGrade(char grade);


            public abstract void AddGrade(int grade);


            public abstract void AddGrade(string grade);


            public abstract Statistics GetStatistics();
        
    }

}
