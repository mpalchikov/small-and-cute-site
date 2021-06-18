using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallAndCute.Web.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
