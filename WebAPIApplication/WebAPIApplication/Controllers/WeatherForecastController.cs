using AutoMapper;
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

        private readonly IMapper mapper;
        public RegionsController(IRegionsRepository regionsRepository, IMapper mapper)
        {
        this.regionsRepository = regionsRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult>  GetAllRegions() {
           var regions =  await regionsRepository.GetAllAsync();
            var regionsDTO = mapper.Map<List<Models.DTO.Regions>>(regions);

            return Ok(regionsDTO);

        }
    }
}