namespace ConsoleApp.Models.Menu;

internal class MenuBase
{
    internal virtual void Execute(Dictionary<string, Artist> artists) 
    {
        Console.Clear();
    }

    protected void FinalizeMenu()
    {
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
