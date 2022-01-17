using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OrganizaAE.Feactures.Mounth.Dto;
using OrganizaAE.Infrastructure.Mounth;

namespace OrganizaAE.Feactures.Mounth.Service
{
    public class MounthService : IMounthService
    {
        private readonly IMounthRepository _mounthRepository;
        private readonly IMapper _mapper;

        public MounthService(IMounthRepository mounthRepository, IMapper mapper)
        {
            _mounthRepository = mounthRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MounthDto>> Get()
        {
            var mounths = await _mounthRepository.GetAllAsync();
            var listMounthsMapped = _mapper.Map<IEnumerable<MounthDto>>(mounths);
            return listMounthsMapped;
        }

        public async Task<MounthDto> Create(MounthDto mounthDto)
        {
            var mounthMapped = _mapper.Map<Models.Mounth.Mounth>(mounthDto);
            await _mounthRepository.AddAndSaveAsync(mounthMapped);

            return _mapper.Map<MounthDto>(mounthMapped);
        }

        public async Task<MounthDto> Update(MounthDto mounthDto)
        {
            var mounthMapped = _mapper.Map<Models.Mounth.Mounth>(mounthDto);
            await _mounthRepository.UpdateAsync(mounthMapped);
            await _mounthRepository.Save();

            return _mapper.Map<MounthDto>(mounthMapped);
        }

        public async Task Remove(int id)
        {
            var mounth = await _mounthRepository.GetByIdAsync(id);
            await _mounthRepository.DeleteAsync(mounth);
            await _mounthRepository.Save();
        }
    }
}
