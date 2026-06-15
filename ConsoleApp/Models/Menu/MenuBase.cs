namespace ConsoleApp.Models.Menu;

internal class MenuBase
{
    internal virtual void Execute(Dictionary<string, Artist> artists) 
    {
        Console.Clear();
    }

    protected void HeaderMenu(string title)
    {
        int qt = title.Length;
        var symbol = string.Empty.PadLeft(qt,'#');
        Console.WriteLine(symbol);
        Console.WriteLine(title);
        Console.WriteLine(symbol);
        Console.WriteLine();
    }

    protected void FinalizeMenu()
    {
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
