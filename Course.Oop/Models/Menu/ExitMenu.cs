using Course.Oop.Models;
using Course.Oop.Models.Menu;

internal class ExitMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        HeaderMenu("EXIT");
        Console.WriteLine("Thank you for using the ScreenSound app.");
        FinalizeMenu();
    }
}