using System.IO;
using System.Text;

namespace Api.InoTrackSearchCount.Services
{
    public interface IIOService
    {
        string ReadStream(Stream stream);
    }

    public class IOService : IIOService
    {
        public string ReadStream(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream, Encoding.ASCII))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
