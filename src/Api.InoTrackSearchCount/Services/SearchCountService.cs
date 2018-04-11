using Api.InoTrackSearchCount.Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace Api.InoTrackSearchCount.Services
{
    public interface ISearchCountService
    {
        Task<List<string>> GetSearchCount(string text, string url);
    }

    public class SearchCountService : ISearchCountService
    {
        private readonly IIOService _iOService;

        public SearchCountService(IIOService iOService)
        {
            _iOService = iOService;
        }

        public async Task<List<string>> GetSearchCount(string text, string url)
        {
            Uri newUri = new Uri(url);
            string raw = "http://www.google.com/search?num=39&q={0}&btnG=Search";
            string search = string.Format(raw, HttpUtility.UrlEncode(text));

            HttpWebRequest request = HttpWebRequestWrapper.CreateHttpWebRequest(search);

            using (HttpWebResponse response = HttpWebResponseWrapper.GetHttpWebResponse(request))
            {
                string html = _iOService.ReadStream(response.GetResponseStream());
                return Helpers.FindAllHrefMatches(html, newUri);
            }
        }
    }
}
