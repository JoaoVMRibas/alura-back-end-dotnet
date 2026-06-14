namespace ConsoleApp.Models.Menu;

internal class RegisterAlbumMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            Console.WriteLine("No registered artists with this name.");
            FinalizeMenu();
            return;
        }

        Console.Write("Album's name: ");
        var albumName = Console.ReadLine() ?? "";

        artists[name].AddAlbum(new Album(albumName));
        FinalizeMenu();
    }
}