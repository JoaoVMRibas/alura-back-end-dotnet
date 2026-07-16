using Course.LINQ.Models;

namespace Course.LINQ.Filters;

internal class MusicFilter
{
    public static List<string?> FilterAllDistinctMusicalGenres(List<Music> musics)
    {
        return musics.Select(music => music.Genre)
            .Distinct()
            .ToList();
    }

    public static List<string?> FilterAllArtistNamesInAscendingOrder(List<Music> musics)
    {
        return musics.Select(music => music.Artist)
            .Distinct()
            .OrderBy(artist => artist)
            .ToList();
    }

    public static List<string?> FilterAllArtistNamesInDescendingOrder(List<Music> musics)
    {
        return musics.Select(music => music.Artist)
            .Distinct()
            .OrderByDescending(artist => artist)
            .ToList();
    }

    public static List<string?> FilterArtistsByMusicalGenre(List<Music> musics, string genre)
    {
        return musics.Where(music => music.Genre != null && music.Genre.Contains(genre))
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
    }

    public static List<Music> FilterMusicsByArtist(List<Music> musics, string artist)
    {
        return musics.Where(music => string.Equals(music.Artist, artist, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
