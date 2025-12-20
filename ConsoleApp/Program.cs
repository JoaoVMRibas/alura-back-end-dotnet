using ConsoleApp.Models;

Artist artist = new Artist("Michael Jackson");

Music music1 = new Music("Billie Jean", artist, 294, false);
Music music2 = new Music("Beat It", artist, 258, true);
Music music3 = new Music("Wanna Be Startin’ Somethin’", artist, 363, true);

Album album1 = new Album("Thriller",artist);
album1.Musics.Add(music1);
album1.Musics.Add(music2);
album1.Musics.Add(music3);

music1.DisplayInformation();
artist.DisplayAlbumsInformation();
artist.DisplayMusicsInformation();
album1.DisplayInformation();