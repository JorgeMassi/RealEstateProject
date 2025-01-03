using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Dtos.Properties;
using RealEstate.Application.Interfaces.Properties;

namespace RealEstate.WebApi.Controllers
{
    public class PropertyController : Controller
    {
       
    
            private readonly IPropertyService _service;

            private readonly ILogger _logger;


            public PropertyController(IPropertyService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                return Ok(await _service.GetAll());
            }

            [HttpGet("{id:guid}")]
            public async Task<IActionResult> GetById(Guid id)
            {
                return Ok(await _service.GetById(id));
            }

            [HttpPost]
            public async Task<IActionResult> Create(PropertyRequestDto property)
            {
                return Ok(await _service.Create(property));
            }

            [HttpPut]
            public async Task<IActionResult> Update(PropertyRequestDto property)
            {
                return Ok(await _service.Update(property));
            }

            [HttpDelete]
            public async Task<IActionResult> Delete(PropertyDeleteRequestDto property)
            {
                return Ok(await _service.Delete(property));
            }

            [HttpDelete("{id:guid}")]
            public async Task<IActionResult> Delete(Guid id)
            {
                return Ok(await _service.Delete(id));
            }
        }
    }
    }
}
