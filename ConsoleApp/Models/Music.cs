using ConsoleApp.Interface;

namespace ConsoleApp.Models;

internal class Music : IRateable, IDisplayable
{
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public int Duration { get; set; }
    public bool IsAvailable { get; set; }

    private List<Rating> _ratings = [];
    public IReadOnlyCollection<Rating> Ratings => _ratings.AsReadOnly();

    public Music(string name, Artist artist, int duration, bool isAvailable)
    {
        Name = name;
        Artist = artist;
        Duration = duration;
        IsAvailable = isAvailable;

        Artist.Musics.Add(this);
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
        Console.WriteLine("Artist: " + Artist.Name);
        Console.WriteLine("Duration: " + Duration);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}
