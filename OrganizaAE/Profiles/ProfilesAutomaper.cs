using AutoMapper;
using OrganizaAE.Feactures.Social.Dto;
using OrganizaAE.Models.Social;
using OrganizaAE.Models.User;

namespace OrganizaAE.Profiles
{
    public class ProfilesAutomaper : Profile
    {
        public ProfilesAutomaper()
        {
            CreateMap<Social, SocialDto>().ReverseMap();
        }
    }
}
