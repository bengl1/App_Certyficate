Console.WriteLine("######################################################");
Console.WriteLine();
Console.WriteLine(" Witam w programie w którym wyznaczę oceny hotelu.");
Console.WriteLine();
Console.WriteLine("######################################################");

Console.WriteLine("Czy zapisać oceny w pliku? n/y ");
var choice = Console.ReadLine();

if (choice == "n")
{
    var hotel = new HotelInMemory("Novotel", "Kraków");

    void HotelGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano nową ocenę.");
    }

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
    var statistics = hotel.GetStatistics();
    Console.WriteLine($"Hotel:{hotel.Name} w miejscowości {hotel.Town} otrzymał oceny:");
    Console.WriteLine($"average: {statistics.Average}");
    Console.WriteLine($"max: {statistics.Max}");
    Console.WriteLine($"min: {statistics.Min}");
    Console.WriteLine($"star rating: {statistics.AverageLetter}");
}
else
{
    var hotel = new HotelInFile("Novotel", "Kraków");
    
    void HotelGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano nową ocenę.");
    }

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
    hotel.GradeAdded += HotelGradeAdded;
    var statistics = hotel.GetStatistics();
    Console.WriteLine($"Hotel:{hotel.Name} w miejscowości {hotel.Town} otrzymał oceny:");
    Console.WriteLine($"average: {statistics.Average}");
    Console.WriteLine($"max: {statistics.Max}");
    Console.WriteLine($"min: {statistics.Min}");
    Console.WriteLine($"star rating: {statistics.AverageLetter}");
}