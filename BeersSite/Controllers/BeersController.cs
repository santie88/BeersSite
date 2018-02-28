using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BeersSite.Logic;

namespace BeersSite.Controllers
{
    public class BeersController : Controller
    {
        // GET: Beers
        public ActionResult Index(string pageNumber, string name, string year)
        {
            var oLstFilters = new List<string>();

            if(pageNumber != null) oLstFilters.Add($"p={pageNumber}");
            if(name != null) oLstFilters.Add($"name={name}");
            if(year != null) oLstFilters.Add($"year={year}");

            var beers = oLstFilters.Count == 0
                ? JsonRequest.GetBeers()
                : JsonRequest.GetBeers(oLstFilters);

            return View(beers);
        }

        // GET: Beer/id
        public ActionResult Details(string id)
        {
            var beer = JsonRequest.GetBeer(id);

            if (beer == null)
            {
                return HttpNotFound();
            }

            return View(beer);
        }
    }
}