using Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallAndCute.Web.Models
{
    public class CatalogViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
