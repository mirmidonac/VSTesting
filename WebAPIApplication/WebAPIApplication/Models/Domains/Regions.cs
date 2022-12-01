namespace WebAPIApplication.Models.Domains
{
    public class Regions
    {
        public Guid ID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Double Area { get; set; }
        public Double Long { get; set; }
        public Double Lat { get; set; }
        public long Population { get; set; }

        //Navigation via EntityFramework
        public IEnumerable <Walk> Walk { get; set; }

                   
    }
}
