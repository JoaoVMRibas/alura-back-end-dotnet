using ConsoleApp.Interface;

namespace ConsoleApp.Models;

internal class Artist : IRateable, IDisplayable
{
    public string Name { get; set; } = string.Empty;
    public List<Album> Albums { get; } = [];
    public List<Music> Musics { get; } = [];

    private List<Rating> _ratings = [];
    public IReadOnlyCollection<Rating> Ratings => _ratings.AsReadOnly();

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
        Console.WriteLine($"\n--- Artist : {Name} ---");
        Console.WriteLine($"Rating: {GetAverageRating()}");

        DisplayAlbumsInformation();
        DisplayMusicsInformation();
        Console.WriteLine();
    }

    private void DisplayAlbumsInformation()
    {
        Console.WriteLine($"\n--- Albums ---");
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

    private void DisplayMusicsInformation()
    {
        Console.WriteLine($"--- Songs ---");
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
