using Course.LINQ.Models;

namespace Course.LINQ.Filters;

internal class MusicFilter
{
    public static List<string?> FilterAllDistinctMusicalGenres(List<Song> songs)
    {
        return songs.Select(song => song.Genre)
            .Distinct()
            .ToList();
    }

    public static List<string?> FilterAllArtistNamesInAscendingOrder(List<Song> songs)
    {
        return songs.Select(song => song.Artist)
            .Distinct()
            .OrderBy(artist => artist)
            .ToList();
    }

    public static List<string?> FilterAllArtistNamesInDescendingOrder(List<Song> songs)
    {
        return songs.Select(song => song.Artist)
            .Distinct()
            .OrderByDescending(artist => artist)
            .ToList();
    }

    public static List<string?> FilterArtistsByMusicalGenre(List<Song> songs, string genre)
    {
        return songs.Where(song => song.Genre != null && song.Genre.Contains(genre))
            .Select(song => song.Artist)
            .Distinct()
            .ToList();
    }

    public static List<Song> FilterSongsByArtist(List<Song> songs, string artist)
    {
        return songs.Where(song => string.Equals(song.Artist, artist, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public static List<string?> FilterSongsNameByKey(List<Song> songs, string key)
    {
        return songs.Where(song => song.Key.Equals(key))
            .Select(s => s.Name)
            .ToList();
    }
}
