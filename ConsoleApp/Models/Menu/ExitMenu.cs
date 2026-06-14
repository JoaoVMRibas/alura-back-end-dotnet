using ConsoleApp.Models;
using ConsoleApp.Models.Menu;

internal class ExitMenu : MenuBase
{
    internal override void Execute(Dictionary<string, Artist> artists)
    {
        base.Execute(artists);
        Console.WriteLine("Thank you for using the ScreenSound app.");
        FinalizeMenu();
    }
}