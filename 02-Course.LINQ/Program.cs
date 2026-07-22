using Course.LINQ.Filters;
using Course.LINQ.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Song>>(response) ?? [];

        var playlist = new Playlist("Random Songs");
        playlist.AddSong(songs[31]);
        playlist.AddSong(songs[79]);
        playlist.AddSong(songs[286]);
        playlist.AddSong(songs[1092]);
        playlist.AddSong(songs[1859]);
        playlist.DisplayPlaylistSongs();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error in GET request: {ex.Message}");
    }
}