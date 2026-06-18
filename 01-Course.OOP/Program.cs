using Course.OOP.Models;
using Course.OOP.Models.Menu;

Dictionary<int, MenuBase> menuOptions = new()
{
    { 1, new RegisterArtistMenu() },
    { 2, new RegisterAlbumMenu() },
    { 3, new RegisterMusicMenu() },
    { 4, new RatingArtistMenu() },
    { 5, new RatingAlbumMenu() },
    { 6, new RatingMusicMenu() },
    { 7, new ShowRegisteredArtistsMenu() },
    { 8, new ViewArtistDetailsMenu() },
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
    Console.WriteLine("4 - Rate Artist");
    Console.WriteLine("5 - Rate Album");
    Console.WriteLine("6 - Rate Music");
    Console.WriteLine("7 - Show Registered Artists");
    Console.WriteLine("8 - View Artist Details");
    Console.WriteLine("-1 - Exit");

    Console.Write("\nEnter the desired option: ");
    var text = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(text)) { menuOption = 0; }
    else { menuOption = int.Parse(text); }

    if (menuOptions.ContainsKey(menuOption))
    {
        menuOptions[menuOption].Execute(artists);
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
    Console.Clear();
} while (menuOption != -1);