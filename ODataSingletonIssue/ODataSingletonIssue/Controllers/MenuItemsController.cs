using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using ODataSingletonIssue.Models;
using System.Linq;
using static Microsoft.AspNet.OData.Query.AllowedQueryOptions;
using static Microsoft.AspNetCore.Http.StatusCodes;


namespace ODataSingletonIssue.Controllers
{
    /// <summary>
    /// Dummy controller for testing.
    /// </summary>
    [ApiVersionNeutral]
    public class MenuItemsController : ODataController
    {
        /// <summary>
        /// Gets a single Menu Item.
        /// </summary>
        /// <param name="key">The requested Menu Item identifier.</param>
        /// <returns>The requested Menu Item.</returns>
        /// <response code="200">The Menu Item was successfully retrieved.</response>
        [Produces("application/json")]
        [ProducesResponseType(typeof(MenuItem), Status200OK)]
        [EnableQuery(AllowedQueryOptions = Select)]
        public SingleResult<MenuItem> Get(int key, ODataQueryOptions<Pizza> options)
            => SingleResult.Create(new[] { new MenuItem() { MenuItemId = key, Title = "Test" } }.AsQueryable());
    }
}
