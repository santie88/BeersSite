namespace BeersSite.Models.JsonObjects
{
    public class BeerDatum
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameDisplay { get; set; }
        public string description { get; set; }
        public string abv { get; set; }
        public int glasswareId { get; set; }
        public int srmId { get; set; }
        public int styleId { get; set; }
        public string isOrganic { get; set; }
        public string status { get; set; }
        public string statusDisplay { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public BeerGlass glass { get; set; }
        public BeerSrm srm { get; set; }
        public BeerStyle style { get; set; }
        public string ibu { get; set; }
        public int? availableId { get; set; }
        public BeerAvailable available { get; set; }
        public BeerLabels labels { get; set; }
        public string originalGravity { get; set; }
        public string servingTemperature { get; set; }
        public string servingTemperatureDisplay { get; set; }
    }
}