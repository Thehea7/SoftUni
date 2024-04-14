using P01.Stream_Progress.Models;
using P01.Stream_Progress.Models.Interfaces;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStreamable file = new File("name", 4096, 1024);
                IStreamable music = new Music("test", "test", 4096, 2048);
            StreamProgressInfo streamInfo = new StreamProgressInfo(file);
            StreamProgressInfo streamInfo2 = new StreamProgressInfo(music);
        }
    }
}
