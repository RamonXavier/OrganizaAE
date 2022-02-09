using System;
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

        public async Task<IEnumerable<SocialDto>> Get()
        {
            var socials = await _socialRepository.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<SocialDto>>(socials);
            return listDto;
        }

        public async Task<SocialDto> GetById(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);

            if (social == null) throw new Exception("Social não encontrada");

            var dto = _mapper.Map<SocialDto>(social);
            return dto;
        }

        public async Task<SocialDto> Create(SocialDto socialDto)
        {
            var socialMapped = _mapper.Map<Models.Social.Social>(socialDto);
            await _socialRepository.AddAndSaveAsync(socialMapped);
            return _mapper.Map<SocialDto>(socialMapped);
        }

        public async Task<SocialDto> Update(SocialDto socialDto)
        {
            var socialMapped = _mapper.Map<Models.Social.Social>(socialDto);
            await _socialRepository.UpdateAsync(socialMapped);
            await _socialRepository.Save();
            return _mapper.Map<SocialDto>(socialMapped);
        }

        public async Task Remove(int id)
        {
            var social = await _socialRepository.GetByIdAsync(id);
            await _socialRepository.DeleteAsync(social);
            await _socialRepository.Save();
        }
    }
}
