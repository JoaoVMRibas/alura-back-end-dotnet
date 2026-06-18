namespace ScreenSound.Models.Menu;

internal class RatingMusicMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Album Rating");

        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";
        if (!artists.ContainsKey(name))
        {
            Console.WriteLine("Artist not found among those registered.");
            return;
        }

        Console.Write("Music's name: ");
        var albumName = Console.ReadLine() ?? "";
        if (artists[name].Musics.Any(m => m.Name.Equals(albumName)))
        {
            var album = artists[name].Albums.First(m => m.Name.Equals(albumName));

            Console.Write("Music Rating: ");
            var rating = int.Parse(Console.ReadLine() ?? "");
            album.AddRating(new Rating(rating));
        }
        else
        {
            Console.WriteLine("Music not found.");
        }
        FinalizeMenu();
    }
}