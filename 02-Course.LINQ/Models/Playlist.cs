namespace Course.LINQ.Models;

internal class Playlist
{
    public string Name { get; set; } = string.Empty;
    public List<Song> Songs { get; } = [];

    public Playlist(string name)
    {
        Name = name.Trim();
        Songs = [];
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public void RemoveSong(Song song)
    {
        Songs.Remove(song);
    }

    public void DisplayPlaylistSongs()
    {
        Console.WriteLine($"Playlist: {Name}");
        foreach (var song in Songs)
        {
            song.DisplayInformation();
            Console.WriteLine();
        }
    }
}
