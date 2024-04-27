using Microsoft.AspNetCore.Mvc;
using PolygonApp.Models;
using PolygonApp.Services;

namespace PolygonApp.Controllers
{
    [Controller]
    [Route("/map")]
    public class PolygonController: Controller
    {
        private readonly PolygonService _polygonService;
        public PolygonController(PolygonService polygonService)
        {
            this._polygonService = polygonService;
        }

        [HttpGet]
        public async Task<List<Polygon>> findAll() {
            return await _polygonService.GetAsync();
        }

        [HttpPost]
        public async Task<IActionResult> postMap([FromBody] Polygon polygon) {
            await _polygonService.CreateAsync(polygon);
            return CreatedAtAction(nameof(findAll), new { id = polygon.Id }, polygon);
        }
    }
}
