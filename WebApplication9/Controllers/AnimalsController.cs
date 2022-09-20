using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("Animals")]
    public class AnimalsController : ODataController
    {
        [HttpPut]
        public IActionResult Put([FromRoute] long animalId, [FromBody] Animal animal)
        {
            return this.NoContent();
        }
    }
}
