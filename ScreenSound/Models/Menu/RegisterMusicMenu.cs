namespace ScreenSound.Models.Menu;

internal class RegisterMusicMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("Register Music");
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            Console.WriteLine("No registered artists with this name.");
            FinalizeMenu();
            return;
        }

        Console.Write("Song's name: ");
        var albumName = Console.ReadLine() ?? "";

        artists[name].AddMusic(new Music(albumName, 250, true));
        FinalizeMenu();
    }
}