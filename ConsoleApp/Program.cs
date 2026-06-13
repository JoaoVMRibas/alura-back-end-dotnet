using ConsoleApp.Models;

Artist artist = new Artist("Michael Jackson");

var music1 = new Music("Billie Jean", artist, 294, false);
var music2 = new Music("Beat It", artist, 258, true);
var music3 = new Music("Wanna Be Startin’ Somethin’", artist, 363, true);

var album1 = new Album("Thriller",artist);
album1.Musics.Add(music1);
album1.Musics.Add(music2);
album1.Musics.Add(music3);

music1.DisplayInformation();
artist.DisplayAlbumsInformation();
artist.DisplayMusicsInformation();
album1.DisplayInformation();

artist.AddRating(new Rating(5));
artist.AddRating(new Rating(5));
artist.AddRating(new Rating(4));


music1.AddRating(new Rating(5));
music1.AddRating(new Rating(4));
music1.AddRating(new Rating(4));


Console.WriteLine($"Average ratings for the artist {artist.Name}: {artist.GetAverageRating()}");
Console.WriteLine($"Average ratings for the song {music1.Name}: {music1.GetAverageRating()}");