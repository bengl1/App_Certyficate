using static CertyficateApp.HotelBase;

namespace CertyficateApp
{
    public interface IHotel
    {
        string Name { get; }
        string Town { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(int grade);
        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
