namespace Course.Oop.Models.Menu;

internal class RatingArtistMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Artist Rating");
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        Console.Write("Rating: ");
        var rating = int.Parse(Console.ReadLine() ?? "");

        if (artists.ContainsKey(name))
        {
            artists[name].AddRating(new Rating(rating));
        }
        else
        {
            Console.WriteLine("Artist not found among those registered.");
        }
        FinalizeMenu();
    }
}