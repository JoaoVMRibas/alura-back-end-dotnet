namespace Course.OOP.Models.Menu;

internal class RatingAlbumMenu : MenuBase
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

        Console.Write("Album's name: ");
        var albumName = Console.ReadLine() ?? "";
        if (artists[name].Albums.Any(a => a.Name.Equals(albumName)))
        {
            var album = artists[name].Albums.First(a => a.Name.Equals(albumName));

            Console.Write("Album Rating: ");
            var rating = int.Parse(Console.ReadLine() ?? "");
            album.AddRating(new Rating(rating));
        }
        else
        {
            Console.WriteLine("Album not found.");            
        }
        FinalizeMenu();
    }
}