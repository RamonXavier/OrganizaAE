using System.Collections.Generic;
using System.Threading.Tasks;
using OrganizaAE.Feactures.User.Dto;

namespace OrganizaAE.Feactures.User.Service
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> Get();
        Task<UserDto> Create(UserDto userDto);
        Task Login(UserLoginDto userDto);
        Task<UserDto> Update(UserDto userDto);
        Task Remove(int id);
    }
}
