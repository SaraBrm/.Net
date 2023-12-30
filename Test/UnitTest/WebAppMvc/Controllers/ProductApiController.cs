using Microsoft.AspNetCore.Mvc;
using WebAppMvc.Models.Entites;
using WebAppMvc.Models.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductApiController(IProductService service)
        {
            _service = service;
        }

        // GET: api/<ProductApiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET api/<ProductApiController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _service.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductApiController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            var result = _service.Add(value);
            return CreatedAtAction("Get", new { id = result.Id });
        }


        // DELETE api/<ProductApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _service.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            _service.Remove(id);
            return Ok(true);
        }
    }
}
