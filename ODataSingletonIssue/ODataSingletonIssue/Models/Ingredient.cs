using System;
using System.ComponentModel.DataAnnotations;

namespace ODataSingletonIssue.Models
{
    public class Ingredient
    {
        [Key]
        public Guid IngredientId { get; set; }

        public string Title { get; set; }
    }
}
