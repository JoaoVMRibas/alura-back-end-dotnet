using ConsoleApp.Models;

Dictionary<string, Artist> artists = [];
MenuManager menuManager = new MenuManager();
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
    menuOption = int.Parse(Console.ReadLine()!);

    switch(menuOption)
    {
        case 1:
            menuManager.RegisterArtist(artists);
            Console.Clear();
            break;
        case 2:
            menuManager.RegisterAlbum(artists);
            Console.Clear();
            break;
        case 3:
            menuManager.RegisterMusic(artists);
            Console.Clear();
            break;
        case 4:
            menuManager.ShowRegisteredArtists(artists);
            Console.Clear();
            break;
        case 5:
            menuManager.AddRatingToArtist(artists);
            Console.Clear();
            break;
        case 6:
            menuManager.ViewArtistDetails(artists);
            Console.Clear();
            break;
        default:
            Console.WriteLine("Invalid option.");
            Console.Clear();
            break;
    }
} while (menuOption != -1);