using ConsoleApp.Models;

Music music1 = new Music("Billie Jean", "Michael Jackson", 294, false);
Music music2 = new Music("Beat It", "Michael Jackson", 258, true);
Music music3 = new Music("Wanna Be Startin’ Somethin’", "Michael Jackson", 363, true);

Album album1 = new Album("Thriller");
album1.Musics.Add(music1);
album1.Musics.Add(music2);
album1.Musics.Add(music3);

album1.DisplayAlbumInformation();
