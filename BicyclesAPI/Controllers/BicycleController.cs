using System.Threading.Tasks;
using BicyclesBLL.Interfaces;
using BicyclesBLL.Views;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BicyclesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BicycleController : Controller
    {
        private readonly IBicycleService _bicycleService;
        public BicycleController(IBicycleService bicycleService)
        {
            _bicycleService = bicycleService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddBicycleView model)
        {
                await _bicycleService.Add(model);
                return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] UpdateBicycleView bicycle)
        {
            await _bicycleService.Update(bicycle);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _bicycleService.Delete(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bikes = await _bicycleService.GetAll();
            return Ok(bikes);
        }
    }
}
