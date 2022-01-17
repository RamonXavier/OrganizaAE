using AutoMapper;
using OrganizaAE.Feactures.Mounth.Dto;
using OrganizaAE.Feactures.Social.Dto;
using OrganizaAE.Models.Mounth;
using OrganizaAE.Models.Social;
using OrganizaAE.Models.User;

namespace OrganizaAE.Profiles
{
    public class ProfilesAutomaper : Profile
    {
        public ProfilesAutomaper()
        {
            CreateMap<Social, SocialDto>().ReverseMap();
            CreateMap<Mounth, MounthDto>().ReverseMap();
        }
    }
}
