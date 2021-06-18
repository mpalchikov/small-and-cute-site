using Catalog.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmallAndCute.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallAndCute.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IMediator _mediator;

        public CatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var catalog = new CatalogViewModel();

            var products = await _mediator.Send(new GetAllProductsQuery());

            catalog.Products = products;

            return View(catalog);
        }

        public async Task<IActionResult> Product(Guid id)
        {
            var product = await _mediator.Send(new GetProductQuery { Id = id });
            return View(new ProductViewModel
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price
            });
        }
    }
}
