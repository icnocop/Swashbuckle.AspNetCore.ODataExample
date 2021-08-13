using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication9.Models
{
    [SwaggerDiscriminator("@odata.type")]
    [SwaggerSubType(typeof(Dog))]
    [SwaggerSubType(typeof(Cat))]
    public abstract class Animal
    {
        public long AnimalId { get; set; }

        public string IgnoredOnEdm { get; set; }

        [JsonProperty("@odata.type")]
        public string ODataType { get; set; }
    }
}
