using Course.LINQ.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var songs = JsonSerializer.Deserialize<List<Music>>(response) ?? [];

        songs[0].DisplayInformation();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error in GET request: {ex.Message}");
    }
}