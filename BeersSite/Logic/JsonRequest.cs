using System.Collections.Generic;
using System.Net.Http;
using BeersSite.Models.JsonObjects;
using Newtonsoft.Json;

namespace BeersSite.Logic
{
    public class JsonRequest
    {
        private const string ApiTargetSite = "http://api.brewerydb.com/v2";
        private const string ApiKey = "ee8a1a84bc76fd7d7ae6dd0dc45583e3";

        private static string urlBuilder(string requestObject)
        {
            return string.Format("{0}/{1}/?key={2}", ApiTargetSite, requestObject, ApiKey);
        }

        private static string urlBuilder(string requestObject, string id)
        {
            return string.Format("{0}/{1}/{2}/?key={3}", ApiTargetSite, requestObject, id, ApiKey);
        }

        public static BeerDatum GetBeer(string id)
        {
            var beer = new BeerDatum();

            string url = urlBuilder("beer", id);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;

                        var model = JsonConvert.DeserializeObject<BeerSingleRootObject>(json);

                        return model.data;
                    }
                }
            }
        }

        public static IEnumerable<BeerDatum> GetBeers()
        {
            var oLstBeers = new List<BeerDatum>();

            string url = urlBuilder("beers");

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;

                        var model = JsonConvert.DeserializeObject<BeerMultipleRootObject>(json);

                        foreach (var beersDatum in model.data)
                        {
                            oLstBeers.Add(beersDatum);
                        }
                    }
                }
            }

            return oLstBeers;
        }
    }
}