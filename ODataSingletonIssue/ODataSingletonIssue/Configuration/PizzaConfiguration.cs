using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using ODataSingletonIssue.Models;

namespace ODataSingletonIssue.Configuration
{
    public class PizzaConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            builder.Singleton<Pizza>(nameof(Pizza));

            builder
                .EntityType<Pizza>()
                .HasKey(p => p.PizzaId)
                .Select()
                .Expand(nameof(Pizza.Ingredients));
        }
    }
}
