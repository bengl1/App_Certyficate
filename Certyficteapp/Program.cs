using CertyficateApp;

Console.WriteLine("######################################################");
Console.WriteLine();
Console.WriteLine(" Witam w programie w którym wyznaczę oceny hotelu.");
Console.WriteLine();
Console.WriteLine("######################################################");

Console.WriteLine("Gdzie zapisać oceny: ");
Console.WriteLine("1 - w pamięci");
Console.WriteLine("2 - w pliku");
var choice = Console.ReadLine();

switch(choice)
{
    case "1":
        var hotelInMemory = new HotelInMemory("Novotel", "Kraków");
        AddRating(hotelInMemory);
        break;


    case "2":
        var hotelInFile = new HotelInFile("Novotel", "Kraków");
        AddRating(hotelInFile);
        break;
}

static void AddRating(IHotel hotel)
 { 
    hotel.GradeAdded += HotelGradeAdded;
    EnterGrade(hotel);
    ShowStatistics(hotel); 
 }

static void HotelGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę.");
}
static void EnterGrade(IHotel hotel)
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Podaj kolejną ocenę hotelu (w procentach 0-100) lub (jako litera z zakresu a-e): ");
        Console.WriteLine("Jeśli chcesz zobaczyć statystyki naciśnij q");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            hotel.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"exception catche: {e.Message}");
        }
    }
}
static void ShowStatistics(IHotel hotel)
{
    var statistics = hotel.GetStatistics();
    Console.WriteLine($"Hotel:{hotel.Name} w miejscowości {hotel.Town} otrzymał oceny:");
    Console.WriteLine($"average: {statistics.Average}");
    Console.WriteLine($"max: {statistics.Max}");
    Console.WriteLine($"min: {statistics.Min}");
    Console.WriteLine($"star rating: {statistics.AverageLetter}");
}