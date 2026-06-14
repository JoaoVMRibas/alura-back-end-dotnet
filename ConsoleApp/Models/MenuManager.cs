namespace ConsoleApp.Models;

internal class MenuManager
{
    internal void AddRatingToArtist(Dictionary<string, Artist> artists)
    {
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        Console.Write("Rating: ");
        var rating = int.Parse(Console.ReadLine() ?? "");

        if (artists.ContainsKey(name))
        {
            artists[name].AddRating(new Rating(rating));
        }
        else
        {
            Console.WriteLine("Artist not found among those registered.");
        }
        FinalizeMethod();
    }

    internal void RegisterAlbum(Dictionary<string, Artist> artists)
    {
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            Console.WriteLine("No registered artists with this name.");
            FinalizeMethod();
            return;
        }

        Console.Write("Album's name: ");
        var albumName = Console.ReadLine() ?? "";
       
        artists[name].AddAlbum(new Album(albumName));
        FinalizeMethod();
    }

    internal void RegisterArtist(Dictionary<string, Artist> artists)
    {
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            artists.Add(name,new Artist(name));
        }
        else
        {
            Console.WriteLine("This artist has already been added.");
        }
        FinalizeMethod();
    }

    internal void RegisterMusic(Dictionary<string, Artist> artists)
    {
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if (!artists.ContainsKey(name))
        {
            Console.WriteLine("No registered artists with this name.");
            FinalizeMethod();
            return;
        }

        Console.Write("Song's name: ");
        var albumName = Console.ReadLine() ?? "";

        artists[name].AddMusic(new Music(albumName,250,true));
        FinalizeMethod();
    }

    internal void ShowRegisteredArtists(Dictionary<string, Artist> artists)
    {
        if(artists == null || artists.Count == 0)
        {
            Console.WriteLine("No registered artists.");
        }
        else
        {
            Console.Write("\nList of registered artists:\n");
            foreach (var artist in artists)
            {
                Console.WriteLine($"Artist: {artist.Value.Name}.");
            }
        }
        FinalizeMethod();
    }

    internal void ViewArtistDetails(Dictionary<string, Artist> artists)
    {
        Console.Write("Artist's name: ");
        var name = Console.ReadLine() ?? "";

        if(artists.ContainsKey(name))
        {
            artists[name].DisplayInformation();
        }
        else
        {
            Console.WriteLine("Artist not found among those registered.");
        }
        FinalizeMethod();
    }

    private void FinalizeMethod()
    {
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
