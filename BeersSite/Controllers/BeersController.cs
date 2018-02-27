using System.Web.Mvc;
using BeersSite.Logic;

namespace BeersSite.Controllers
{
    public class BeersController : Controller
    {
        // GET: Beers
        public ActionResult Index()
        {
            var beers = JsonRequest.GetBeers();

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