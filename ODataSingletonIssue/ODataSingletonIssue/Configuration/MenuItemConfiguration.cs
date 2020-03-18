using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;
using ODataSingletonIssue.Models;

namespace ODataSingletonIssue.Configuration
{
    public class MenuItemConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            builder
                .EntitySet<MenuItem>("MenuItems")
                .EntityType
                .HasKey(p => p.MenuItemId)
                .Select()
                .Filter();
        }
    }
}
