using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Configuration
{
    public class ModelConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string routePrefix)
        {
            builder.EntitySet<Animal>("Animals");

            EntityTypeConfiguration<Animal> animal = builder.EntityType<Animal>();
            animal.Namespace = "Animals";
            animal.Ignore(x => x.IgnoredOnEdm);
            animal.Abstract();

            EntityTypeConfiguration<Dog> dog = builder.EntityType<Dog>();
            dog.Namespace = "Animals";
            dog.DerivesFrom<Animal>();

            EntityTypeConfiguration<Cat> cat = builder.EntityType<Cat>();
            cat.Namespace = "Animals";
            cat.DerivesFrom<Animal>();
        }
    }
}
