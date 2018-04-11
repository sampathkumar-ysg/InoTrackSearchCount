using Api.InoTrackSearchCount.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.InfoTrackSearchCount.UnitTest.Mock
{
    public class MockSearchCountService : ISearchCountService
    {
        public Task<List<string>> GetSearchCount(string text, string url)
        {
            return Task.FromResult(new List<string> { "1", "2" });
        }
    }
}
