using ConsoleApp.Interface;

namespace ConsoleApp.Models;

internal class Album :  IDisplayable
{
    public string Name { get; set; } = string.Empty;
    public int Duration => Musics.Sum(m => m.Duration);
    public List<Music> Musics { get; } = [];

    public Album(string name)
    {
        Name = name;
    }

    public void DisplayInformation() 
    {
        Console.WriteLine($"--- Album : {Name} ---");
        var duration = TimeSpan.FromSeconds(Duration);
        Console.WriteLine($"Total album duration: {duration.Minutes} min {duration.Seconds} sec");
        Console.WriteLine();
    }
}
