using BeersSite.Models.JsonObjects;

namespace BeersSite.Models
{
    public class BeerViewModel
    {
        public int currentPage { get; set; }
        public int numberOfPages { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}