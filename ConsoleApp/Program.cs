using ConsoleApp.Models;
using ConsoleApp.Models.Menu;

Dictionary<int, MenuBase> menuOptions = new()
{
    { 1, new RegisterArtistMenu() },
    { 2, new RegisterAlbumMenu() },
    { 3, new RegisterMusicMenu() },
    { 4, new ShowRegisteredArtistsMenu() },
    { 5, new RatingMenu() },
    { 6, new ViewArtistDetailsMenu() },
    { -1, new ExitMenu() }
};

Dictionary<string, Artist> artists = [];
int menuOption = 0;
do
{
    Console.WriteLine("ScreenSound:");
    Console.WriteLine("1 - Register Artist");
    Console.WriteLine("2 - Register Album");
    Console.WriteLine("3 - Register Music");
    Console.WriteLine("4 - Show Registered Artists");
    Console.WriteLine("5 - Rate Artist");
    Console.WriteLine("6 - View Artist Details");
    Console.WriteLine("-1 - Exit");

    Console.Write("\nEnter the desired option: ");
    menuOption = int.Parse(Console.ReadLine() ?? "0");

    if(menuOptions.ContainsKey(menuOption))
    {
        menuOptions[menuOption].Execute(artists);
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
    Console.Clear();
} while (menuOption != -1);