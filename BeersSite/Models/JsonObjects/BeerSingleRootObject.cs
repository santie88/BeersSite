namespace BeersSite.Models.JsonObjects
{
    public class BeerSingleRootObject
    {
        public string message { get; set; }
        public BeerDatum data { get; set; }
        public string status { get; set; }
    }
}