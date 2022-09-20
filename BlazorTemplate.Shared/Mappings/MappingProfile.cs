namespace BlazorTemplate.Shared.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterViewModel, ApplicationUser>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(source => source.PhoneNumber))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.FirstName))
            .ForMember(dest => dest.Family, opt => opt.MapFrom(source => source.LastName));

        CreateMap<RoleViewModel, ApplicationRole>()
            .ReverseMap();
    }
}