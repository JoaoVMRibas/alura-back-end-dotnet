using Course.OOP.Interface;

namespace Course.OOP.Models;

internal class Music : IRateable, IDisplayable
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public bool IsAvailable { get; set; }

    private List<Rating> _ratings = [];

    public Music(string name, int duration, bool isAvailable)
    {
        Name = name;
        Duration = duration;
        IsAvailable = isAvailable;
    }

    public void AddRating(Rating rating)
    {
        _ratings.Add(rating);
    }

    public double GetAverageRating()
    {
        return _ratings.Count() == 0 ? 0.0 : _ratings.Average(r => r.Value);
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"--- Music ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Rating: " + GetAverageRating());
        Console.WriteLine("Duration: " + Duration);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}
