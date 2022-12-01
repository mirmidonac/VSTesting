using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Models.Domains;
using WebAPIApplication.Repositories;

namespace WebAPIApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionsRepository regionsRepository;
        public RegionsController(IRegionsRepository regionsRepository)
        {
        this.regionsRepository = regionsRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegions() {
           var regions =  regionsRepository.GetAll();
            
            return Ok(regions);

        }
    }
}