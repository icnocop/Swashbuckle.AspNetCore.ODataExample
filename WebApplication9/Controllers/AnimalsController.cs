using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [ODataRoutePrefix("Animals")]
    public class AnimalsController : ODataController
    {
        [HttpPut]
        public IActionResult Put([FromRoute] long animalId, [FromBody] Animal animal)
        {
            return this.NoContent();
        }
    }
}
