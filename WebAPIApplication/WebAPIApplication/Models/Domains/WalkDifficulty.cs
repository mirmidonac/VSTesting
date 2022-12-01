using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebAPIApplication.Models.Domains
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Difficulty { get; set; }
        //Navigation EntityFramework
    }
}
