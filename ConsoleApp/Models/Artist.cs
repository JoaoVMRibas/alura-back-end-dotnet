using ConsoleApp.Interface;

namespace ConsoleApp.Models;

internal class Artist : IRateable
{
    public string Name { get; set; } = string.Empty;
    public List<Album> Albums { get; } = [];
    public List<Music> Musics { get; } = [];

    private List<int> _ratings = [];
    public IReadOnlyCollection<int> Ratings => _ratings.AsReadOnly();

    public Artist(string name) 
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void AddRating(int rating)
    {
        if (rating < 0 || rating > 5)
            throw new ArgumentOutOfRangeException(nameof(rating), "The rating should be between 1 and 5.");
    
        _ratings.Add(rating);
    }

    public double GetAverageRating()
    {
        return _ratings.Count() == 0 ? 0.0 : _ratings.Average();
    }

    public void DisplayAlbumsInformation()
    {
        Console.WriteLine($"--- Artist : {Name} ---");
        if (Albums.Count > 0)
        {
            Albums.ForEach(a => Console.WriteLine($"Album: {a.Name}"));
        }
        else 
        {
            Console.WriteLine("No albums found.");
        }
        Console.WriteLine();
    }

    public void DisplayMusicsInformation()
    {
        Console.WriteLine($"--- Artist : {Name} ---");
        if (Musics.Count > 0)
        {
            Musics.ForEach(m => Console.WriteLine($"Music: {m.Name}"));
        }
        else
        {
            Console.WriteLine("No songs found.");
        }
        Console.WriteLine();
    }
}
