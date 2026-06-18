using ScreenSound.Interface;

namespace ScreenSound.Models;

internal class Album :  IRateable, IDisplayable
{
    public string Name { get; set; } = string.Empty;
    public int Duration => Musics.Sum(m => m.Duration);
    public List<Music> Musics { get; } = [];

    private List<Rating> _ratings = [];

    public Album(string name)
    {
        Name = name;
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
        Console.WriteLine($"--- Album ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Rating: " + GetAverageRating());
        var duration = TimeSpan.FromSeconds(Duration);
        Console.WriteLine($"Total album duration: {duration.Minutes} min {duration.Seconds} sec");
        Console.WriteLine();
    }
}
