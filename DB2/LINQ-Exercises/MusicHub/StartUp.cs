using System.Text;

namespace MusicHub
{
    using System;

    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here

            //Console.WriteLine(ExportAlbumsInfo(context, 9));
            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumsInfo = context.Producers
                .Find(producerId)
                .Albums.Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer.Name,
                    songs = a.Songs.Select(s => new
                    {
                        SongName = s.Name,
                        SongPrice = s.Price,
                        Writer = s.Writer.Name
                    }).OrderByDescending(s => s.SongName)
                    .ThenBy(s => s.Writer),
                    TotalPrice = a.Price
                }).OrderByDescending(a => a.TotalPrice);

            StringBuilder sb = new StringBuilder();

            foreach (var a in albumsInfo)
            {
                sb.AppendLine($"-AlbumName: {a.AlbumName}");
                sb.AppendLine($"-ReleaseDate: {a.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {a.ProducerName}");
                sb.AppendLine($"-Songs:");
                int songsCount = 1;
                foreach (var s in a.songs)
                {
                    sb.AppendLine($"---#{songsCount}");
                    sb.AppendLine($"---SongName: {s.SongName}");
                    sb.AppendLine($"---Price: {s.SongPrice:f2}");
                    sb.AppendLine($"---Writer: {s.Writer}");
                    songsCount++;
                }

                sb.AppendLine($"-AlbumPrice: {a.TotalPrice:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songsInfo = context.Songs
                .AsEnumerable()
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    SongName = s.Name,
                    SongWriter = s.Writer.Name,
                    Performers = s.SongPerformers.Select(sp => new
                    {
                        FullName = $"{sp.Performer.FirstName} {sp.Performer.LastName}"
                    }).OrderBy(p => p.FullName),
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration
                }).OrderBy(s =>s.SongName)
                .ThenBy(s => s.SongWriter);

            StringBuilder sb = new();
            int songsCount = 1;
            foreach (var s in songsInfo)
            {
                sb.AppendLine($"-Song #{songsCount}");
                sb.AppendLine($"---SongName: {s.SongName}");
                sb.AppendLine($"---Writer: {s.SongWriter}");
                if (s.Performers.Any())
                {
                    foreach (var p in s.Performers)
                    {
                        sb.AppendLine($"---Performer: {p.FullName}");
                    }
                }

                sb.AppendLine($"---AlbumProducer: {s.AlbumProducer}");
                sb.AppendLine($"---Duration: {s.Duration}");
                songsCount++;
            }

            return sb.ToString().Trim();
        }
    }
}
