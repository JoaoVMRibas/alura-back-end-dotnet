namespace ConsoleApp.Models
{
    internal class Album
    {
        public string Name { get; set; } = string.Empty;
        public int Duration => Musics.Sum(m => m.Duration);
        public List<Music> Musics { get; set; }

        public Album(string name)
        {
            Name = name;
            Musics = new List<Music>();
        }

        public void DisplayAlbumInformation() 
        {
            Console.WriteLine($"--- Album : {Name} ---");
            Musics.ForEach(m => Console.WriteLine($"Music: {m.Name} - {m.Artist}"));
        }
    }
}
