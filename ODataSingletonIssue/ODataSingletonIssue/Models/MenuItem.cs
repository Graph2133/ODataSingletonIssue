using System;
using System.ComponentModel.DataAnnotations;

namespace ODataSingletonIssue.Models
{
    /// <summary>
    ///  Dummy additional entity set.
    /// </summary>
    public class MenuItem
    {
        public int MenuItemId { get; set; }

        public string Title { get; set; }
    }
}
