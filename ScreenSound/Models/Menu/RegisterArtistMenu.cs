namespace ScreenSound.Models.Menu;

internal class RegisterArtistMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Register Artist");
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            artists.Add(name, new Artist(name));
        }
        else
        {
            Console.WriteLine("This artist has already been added.");
        }
        FinalizeMenu();
    }
}