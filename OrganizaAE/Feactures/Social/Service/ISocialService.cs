using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.Social.Dto;

namespace OrganizaAE.Feactures.Social.Service
{
    public interface ISocialService
    {
        Task<IEnumerable<SocialDto>> Buscar();
    }
}
