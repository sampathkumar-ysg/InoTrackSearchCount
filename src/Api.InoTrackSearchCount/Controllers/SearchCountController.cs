using Api.InoTrackSearchCount.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.InoTrackSearchCount.Controllers
{
    [Route("api.inotrack")]
    public class SearchCountController : Controller
    {
        private readonly ISearchCountService _searchCountService;

        public SearchCountController(ISearchCountService searchCountService)
        {
            _searchCountService = searchCountService;
        }

        [HttpGet("searchcount")]
        public async Task<IActionResult> GetSearchCount([FromQuery] string text, [FromQuery] string domain)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(domain))
            {
                return BadRequest();
            }

            return Ok( await _searchCountService.GetSearchCount(text, $"https://{domain}/"));
        }
    }
}
