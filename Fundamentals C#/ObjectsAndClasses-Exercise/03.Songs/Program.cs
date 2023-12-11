namespace _03.Songs
{
    class Song
    {
        public Song(string v1, string v2, string v3)
        {
            TypeList = v1;
            Name = v2;
            Time = v3;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> listOfSongs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Song currentSong = new Song(input[0], input[1], input[2]);
                listOfSongs.Add(currentSong);
            }
            string filter = Console.ReadLine();
            

            if (filter == "all")
            {
                foreach (Song song in listOfSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in listOfSongs)
                {
                    if(song.TypeList == filter)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            
        }
    }

    
}