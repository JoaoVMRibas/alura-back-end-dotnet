using Course.LINQ.Filters;
using Course.LINQ.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Music>>(response) ?? [];

        // Displays all distinct musical genres in the music list
        var genres = MusicFilter.FilterAllDistinctMusicalGenres(songs) ?? [];
        foreach (var genre in genres)
        {
            //Console.WriteLine($"- {genre}");
        }

        // Displays all distinct artists in the music list in ascending order
        var artistsAsc = MusicFilter.FilterAllArtistNamesInAscendingOrder(songs) ?? [];
        foreach (var artist in artistsAsc)
        {
            //Console.WriteLine($"- {artist}");
        }

        // Displays all distinct artists in the music list in descending order
        var artistsDes = MusicFilter.FilterAllArtistNamesInDescendingOrder(songs) ?? [];
        foreach (var artist in artistsDes)
        {
            //Console.WriteLine($"- {artist}");
        }

        // Displays all artists by the selected musical genre
        var artistsByGenre = MusicFilter.FilterArtistsByMusicalGenre(songs, "rock") ?? [];
        foreach (var artist in artistsByGenre)
        {
            //Console.WriteLine($"- {artist}");
        }

        // Displays all songs by the artist
        var songsByArtist = MusicFilter.FilterMusicsByArtist(songs, "Michael Jackson") ?? [];
        foreach (var song in songsByArtist)
        {
            //song.DisplayInformation();
            //Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error in GET request: {ex.Message}");
    }
}