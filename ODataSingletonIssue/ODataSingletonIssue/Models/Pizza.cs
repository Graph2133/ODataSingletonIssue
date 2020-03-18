using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataSingletonIssue.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string Title { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
    }
}
