using P01.Stream_Progress.Models.Interfaces;

namespace P01.Stream_Progress.Models
{
    public class StreamProgressInfo
    {
        private IStreamable stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable stream)
        {
            this.stream = stream;
        }

        public int CalculateCurrentPercent()
        {
            return stream.BytesSent * 100 / stream.Length;
        }
    }
}
