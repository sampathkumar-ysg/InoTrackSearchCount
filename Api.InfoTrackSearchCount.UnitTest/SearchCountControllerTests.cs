using Api.InfoTrackSearchCount.UnitTest.Mock;
using Api.InoTrackSearchCount.Controllers;
using Api.InoTrackSearchCount.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.InfoTrackSearchCount.UnitTest
{
    [TestClass]
    public class SearchCountControllerTests
    {
        private SearchCountController _searchCountController;
        private ISearchCountService _searchCountService;

        [TestMethod]
        public async void TestMethod1()
        {
            _searchCountService = new MockSearchCountService();
            _searchCountController = new SearchCountController(_searchCountService);

            var response = await _searchCountController.GetSearchCount("1", "2");

            Assert.IsNotNull(response);
        }
    }
}
