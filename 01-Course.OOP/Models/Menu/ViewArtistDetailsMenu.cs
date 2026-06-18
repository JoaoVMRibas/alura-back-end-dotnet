namespace Course.OOP.Models.Menu;

internal class ViewArtistDetailsMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Artist Details");
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (artists.ContainsKey(name))
        {
            artists[name].DisplayInformation();
        }
        else
        {
            Console.WriteLine("Artist not found among those registered.");
        }
        FinalizeMenu();
    }
}