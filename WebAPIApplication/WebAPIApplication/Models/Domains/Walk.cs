namespace WebAPIApplication.Models.Domains
{
    public class Walk
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Double Lenght { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation EntityFramework
        public Regions Regions { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }

        public Person Person { get; set; }
    
    }
}
