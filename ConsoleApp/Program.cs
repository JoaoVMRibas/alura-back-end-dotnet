using ConsoleApp.Models;

//Artist artist = new Artist("Michael Jackson");

//var music1 = new Music("Billie Jean", artist, 294, false);
//var music2 = new Music("Beat It", artist, 258, true);
//var music3 = new Music("Wanna Be Startin’ Somethin’", artist, 363, true);

//var album1 = new Album("Thriller",artist);
//album1.Musics.Add(music1);
//album1.Musics.Add(music2);
//album1.Musics.Add(music3);

//music1.DisplayInformation();
//artist.DisplayAlbumsInformation();
//artist.DisplayMusicsInformation();
//album1.DisplayInformation();

//artist.AddRating(new Rating(5));
//artist.AddRating(new Rating(5));
//artist.AddRating(new Rating(4));


//music1.AddRating(new Rating(5));
//music1.AddRating(new Rating(4));
//music1.AddRating(new Rating(4));


//Console.WriteLine($"Average ratings for the artist {artist.Name}: {artist.GetAverageRating()}");
//Console.WriteLine($"Average ratings for the song {music1.Name}: {music1.GetAverageRating()}");

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
            break;
        case 2:
            menuManager.RegisterAlbum();
            break;
        case 3:
            menuManager.RegisterMusic();
            break;
        case 4:
            menuManager.ShowRegisteredArtists();
            break;
        case 5:
            menuManager.AddRatingToArtist();
            break;
        case 6:
            menuManager.AddRatingToMusic();
            break;
        case 7:
            menuManager.ViewArtistDetails();
            break;
        default:
            Console.WriteLine("Invalid option.");
            Console.Clear();
            break;
    }
} while (menuOption != -1);