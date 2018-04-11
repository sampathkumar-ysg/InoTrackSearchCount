using System.Net;

namespace Api.InoTrackSearchCount.Services
{
    public class HttpWebRequestWrapper
    {
        public static HttpWebRequest CreateHttpWebRequest(string uri)
        {
            return (HttpWebRequest)WebRequest.Create(uri);
        }
    }

    public class HttpWebResponseWrapper
    {
        public static HttpWebResponse GetHttpWebResponse(HttpWebRequest httpWebRequest)
        {
            return (HttpWebResponse)httpWebRequest.GetResponse();
        }
    }
}
