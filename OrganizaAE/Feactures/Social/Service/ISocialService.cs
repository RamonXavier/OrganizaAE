using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.Social.Dto;

namespace OrganizaAE.Feactures.Social.Service
{
    public interface ISocialService
    {
        Task<IEnumerable<SocialDto>> Get();
        Task<SocialDto> GetById(int id);
        Task<SocialDto> Create(SocialDto socialDto);
        Task<SocialDto> Update(SocialDto socialDto);
        Task Remove(int id);
    }
}
