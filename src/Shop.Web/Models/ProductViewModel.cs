using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class ProductViewModel //model do dodawania produktów
    {
        [Required(ErrorMessage = "Nazwa musi zostać podana.")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Range(1,100000)]
        public decimal Price { get; set; }

        public List<SelectListItem> Categories { get; } = new List<SelectListItem> // lista kategorii
        {
            new SelectListItem {Text="Electronics", Value = "Electronics"},
            new SelectListItem {Text="Tools", Value = "Tools"},
            new SelectListItem {Text="Trousers", Value = "Trousers"}
        };
    }
}
