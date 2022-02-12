using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.Mounth.Dto;

namespace OrganizaAE.Feactures.Mounth.Service
{
    public interface IMounthService
    {
        Task<IEnumerable<MounthDto>> Get();
        Task<MounthDto> GetById(int id);
        Task<MounthDto> Create(MounthDto mounthDto);
        Task<MounthDto> Update(MounthDto mounthDto);
        Task Delete(int id);
    }
}
