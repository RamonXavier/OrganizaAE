using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OrganizaAE.Feactures.Social.Dto;
using OrganizaAE.Infrastructure.Social;

namespace OrganizaAE.Feactures.Social.Service
{
    public class SocialService : ISocialService
    {
        private readonly ISocialRepository _socialRepository;
        private readonly IMapper _mapper;

        public SocialService(ISocialRepository socialRepository, IMapper mapper)
        {
            _socialRepository = socialRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SocialDto>> Buscar()
        {
            var sociais = await _socialRepository.GetAllAsync();
            var listaDto = _mapper.Map<IEnumerable<SocialDto>>(sociais);
            return listaDto;
        }
    }
}
