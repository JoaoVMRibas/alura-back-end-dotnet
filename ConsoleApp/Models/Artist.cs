namespace ConsoleApp.Models
{
    internal class Artist
    {
        public string Name { get; set; } = string.Empty;
        public List<Album> Albums { get; } = [];
        public List<Music> Musics { get; } = [];


        public Artist(string name) 
        {
            Name = name;
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void AddMusic(Music music)
        {
            Musics.Add(music);
        }

        public void DisplayAlbumsInformation()
        {
            Console.WriteLine($"--- Artist : {Name} ---");
            if (Albums.Count > 0)
            {
                Albums.ForEach(a => Console.WriteLine($"Album: {a.Name}"));
            }
            else 
            {
                Console.WriteLine("No albums found.");
            }
            Console.WriteLine();
        }

        public void DisplayMusicsInformation()
        {
            Console.WriteLine($"--- Artist : {Name} ---");
            if (Musics.Count > 0)
            {
                Musics.ForEach(m => Console.WriteLine($"Music: {m.Name}"));
            }
            else
            {
                Console.WriteLine("No songs found.");
            }
            Console.WriteLine();
        }
    }
}
