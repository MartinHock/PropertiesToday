using AutoMapper;

namespace Application.MappingProfiles
{
    public class Mappings
    :
    Profile
    {
        public Mappings()
        {
            CreateMap<Application.Models.NewPropertyRequest, Domain.Property>();
        }
    }
}