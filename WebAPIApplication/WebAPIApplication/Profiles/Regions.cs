using AutoMapper;

namespace WebAPIApplication.Profiles
{
    public class RegionsProfile:Profile
    {
        public RegionsProfile() 
        {
            CreateMap<Models.Domains.Regions, Models.DTO.Regions>();
            //if the names are not same from Domains to DTO than we need to map that out by hand using ForMember() method or ReverseMap () from DTO to Domain
        }
    }
}
