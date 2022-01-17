using AutoMapper;
using OrganizaAE.Feactures.Mounth.Dto;
using OrganizaAE.Feactures.Payment.Dto;
using OrganizaAE.Feactures.Social.Dto;
using OrganizaAE.Feactures.User.Dto;
using OrganizaAE.Models.Mounth;
using OrganizaAE.Models.Payment;
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
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Payment, PaymentCompleteDto>()
                .ForMember(dest => dest.IdSocial, forn => forn.MapFrom(src => src.Social.Id))
                .ForMember(dest => dest.NameSocial, forn => forn.MapFrom(src => src.Social.Name))
                .ForMember(dest => dest.Email, forn => forn.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.IdUser, forn => forn.MapFrom(src => src.User.Id))
                .ForMember(dest => dest.NameUser, forn => forn.MapFrom(src => src.User.Name))
                .ForMember(dest => dest.Id, forn => forn.MapFrom(src => src.Id))
                .ForMember(dest => dest.NameMounth, forn => forn.MapFrom(src => src.Mounth.Name))
                .ForMember(dest => dest.NumberMounth, forn => forn.MapFrom(src => src.Mounth.Number))
                .ForMember(dest => dest.Year, forn => forn.MapFrom(src => src.Year))
                .ForMember(dest => dest.Status, forn => forn.MapFrom(src => src.Status));
        }
    }
}
