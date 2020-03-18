using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using ODataSingletonIssue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.AspNet.OData.Query.AllowedQueryOptions;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace ODataSingletonIssue.Controllers
{
    /// <summary>
    /// Controller with actual issue.
    /// </summary>
    [ApiVersionNeutral]
    public class PizzaController : ODataController
    {
        public static Pizza Pizza;

        public PizzaController()
        {
            InitData();
        }

        /// <summary>
        /// Gets a single Pizza (Not working sample).
        /// </summary>
        /// <param name="key">The requested Pizza identifier.</param>
        /// <returns>The requested Pizza.</returns>
        /// <response code="200">The Pizza was successfully retrieved.</response>
        [Produces("application/json")]
        [ProducesResponseType(typeof(Pizza), Status200OK)]
        [EnableQuery(AllowedQueryOptions = Select | Expand)]
        [ODataRoute("Pizza")]
        public SingleResult<Pizza> GetOne(ODataQueryOptions<Pizza> options)
        {
            return SingleResult.Create(new[] { Pizza }.AsQueryable());
        }



        /// <summary>
        /// Gets a single Pizza (working one).
        /// </summary>
        /// <param name="key">The requested Pizza identifier.</param>
        /// <returns>The requested Pizza.</returns>
        /// <response code="200">The Pizza was successfully retrieved.</response>
        ////[Produces("application/json")]
        ////[ProducesResponseType(typeof(Pizza), Status200OK)]
        ////[EnableQuery(AllowedQueryOptions = Select | Expand)]
        ////[ODataRoute("Pizza")]
        ////public SingleResult<Pizza> GetOne()
        ////    => SingleResult.Create(new[] { Pizza }.AsQueryable());


        private static void InitData()
        {
            Pizza = new Pizza()
            {
                PizzaId = 1,
                Title = "Test",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient
                    {
                        IngredientId = Guid.NewGuid(),
                        Title ="Ham"
                    }
                }
            };
        }
    }
}
