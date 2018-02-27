using System.Collections.Generic;

namespace BeersSite.Models.JsonObjects
{
    public class BeerMultipleRootObject
    {
        public int currentPage { get; set; }
        public int numberOfPages { get; set; }
        public int totalResults { get; set; }
        public string message { get; set; }
        public List<BeerDatum> data { get; set; }
        public string status { get; set; }
    }
}