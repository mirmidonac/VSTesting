using WebAPIApplication.Data;
using WebAPIApplication.Models.Domains;

namespace WebAPIApplication.Repositories
{
    public class RegionsRepository : IRegionsRepository
    {
        public readonly WebAPIDBContext webAPIDBContext;

        public RegionsRepository(WebAPIDBContext webAPIDBContext)
        { 
        this.webAPIDBContext = webAPIDBContext;
        }
        public IEnumerable<Regions> GetAll()
        {
            return webAPIDBContext.Regions.ToList();
        }
    }
}
