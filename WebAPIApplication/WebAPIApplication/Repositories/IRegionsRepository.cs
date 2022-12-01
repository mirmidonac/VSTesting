using WebAPIApplication.Models.Domains;

namespace WebAPIApplication.Repositories
{
    public interface IRegionsRepository
    {
      IEnumerable<Regions> GetAll();
    }
}
