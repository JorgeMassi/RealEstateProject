using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Interfaces.Properties;
using RealEstate.Domain.Properties;

namespace RealEstate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _propertyService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _propertyService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Property property)
        {
            return Ok(await _propertyService.Create(property));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Property property)
        {
            return Ok(await _propertyService.Update(property));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Property property)
        {
            return Ok(await _propertyService.Delete(property));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _propertyService.Delete(id));
        }
    }
}
