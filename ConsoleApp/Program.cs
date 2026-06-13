using ConsoleApp.Models;

Dictionary<string, Artist> artists = [];
MenuManager menuManager = new MenuManager();
int menuOption = 0;

do
{
    Console.WriteLine("Enter the desired option:");
    Console.WriteLine("1 - Register Artist");
    Console.WriteLine("2 - Register Album");
    Console.WriteLine("3 - Register Music");
    Console.WriteLine("4 - Show Registered Artists");
    Console.WriteLine("5 - Rate Artist");
    Console.WriteLine("6 - Rate Music");
    Console.WriteLine("7 - View Artist Details");
    Console.WriteLine("-1 - Exit");

    menuOption = int.Parse(Console.ReadLine()!);

    switch(menuOption)
    {
        case 1:
            menuManager.RegisterArtist();
            Console.Clear();
            break;
        case 2:
            menuManager.RegisterAlbum();
            Console.Clear();
            break;
        case 3:
            menuManager.RegisterMusic();
            Console.Clear();
            break;
        case 4:
            menuManager.ShowRegisteredArtists();
            Console.Clear();
            break;
        case 5:
            menuManager.AddRatingToArtist();
            Console.Clear();
            break;
        case 6:
            menuManager.AddRatingToMusic();
            Console.Clear();
            break;
        case 7:
            menuManager.ViewArtistDetails();
            Console.Clear();
            break;
        default:
            Console.WriteLine("Invalid option.");
            Console.Clear();
            break;
    }
} while (menuOption != -1);