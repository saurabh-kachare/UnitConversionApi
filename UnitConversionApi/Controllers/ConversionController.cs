using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services;

namespace UnitConversionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly ConversionService _service;

        public ConversionController(ConversionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            try
            {
                var result = _service.Convert(
                    request.Category,
                    request.FromUnit,
                    request.ToUnit,
                    request.Value);

                return Ok(new ConversionResponse
                {
                    InputValue = request.Value,
                    FromUnit = request.FromUnit,
                    ToUnit = request.ToUnit,
                    Result = Math.Round(result, 2)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}