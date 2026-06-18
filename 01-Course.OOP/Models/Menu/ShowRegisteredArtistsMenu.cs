namespace Course.OOP.Models.Menu;

internal class ShowRegisteredArtistsMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Registered Artists");
        if (artists == null || artists.Count == 0)
        {
            Console.WriteLine("No registered artists.");
        }
        else
        {
            Console.Write("\nList of registered artists:\n");
            foreach (var artist in artists)
            {
                Console.WriteLine($"Artist: {artist.Value.Name}.");
            }
        }
        FinalizeMenu();
    }
}