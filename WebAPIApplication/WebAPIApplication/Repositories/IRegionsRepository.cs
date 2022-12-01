using WebAPIApplication.Models.Domains;

namespace WebAPIApplication.Repositories
{
    public interface IRegionsRepository
    {
     Task<IEnumerable<Regions>> GetAllAsync();
    }
}
