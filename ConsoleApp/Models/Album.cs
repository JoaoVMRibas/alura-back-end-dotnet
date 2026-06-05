namespace ConsoleApp.Models;

internal class Album
{
    public string Name { get; set; } = string.Empty;
    public int Duration => Musics.Sum(m => m.Duration);
    public Artist Artist { get; set; }
    public List<Music> Musics { get; } = [];

    public Album(string name, Artist artist)
    {
        Name = name;
        Artist = artist;

        Artist.Albums.Add(this);
    }

    public void DisplayInformation() 
    {
        Console.WriteLine($"--- Album : {Name} ---");
        Musics.ForEach(m => Console.WriteLine($"Music: {m.Name} - {m.Artist.Name}"));
        var duration = TimeSpan.FromSeconds(Duration);
        Console.WriteLine($"Total album duration: {duration.Minutes} min {duration.Seconds} sec");
        Console.WriteLine();
    }
}
