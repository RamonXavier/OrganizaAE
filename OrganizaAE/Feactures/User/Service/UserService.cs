using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OrganizaAE.Feactures.User.Dto;
using OrganizaAE.Infrastructure.User;

namespace OrganizaAE.Feactures.User.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> Get()
        {
            var usersList = await _userRepository.GetAllAsync();
            var usersMapped = _mapper.Map<IEnumerable<UserDto>>(usersList);

            return usersMapped;
        }

        public async Task<UserDto> GetById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null) throw new Exception("Usuário não encontrado");
            var userMapped = _mapper.Map<UserDto>(user);

            return userMapped;
        }

        public async Task Login(UserLoginDto userDto)
        {
            var usuarioValido = await UserIsValid(userDto);
            if (!usuarioValido) throw new KeyNotFoundException("Usuário Não Encontrado");
        }

        private async Task<bool> UserIsValid(UserLoginDto userDto)
        {
            userDto.Password = CreateHashPasword(userDto.Password);
            var user = await _userRepository.GetAsync(x => x.Password == userDto.Password && x.Email == userDto.Email);

            return user.Count > 0;
        }

        public async Task<UserDto> Create(UserDto userDto)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var userMapped = _mapper.Map<Models.User.User>(userDto);

            var base64String = CreateHashPasword(userMapped.Password);
            userMapped.Password = base64String;

            await _userRepository.AddAndSaveAsync(userMapped);

            return _mapper.Map<UserDto>(userMapped);
        }

        private static string CreateHashPasword(string password)
        {
            var passwordHashed = Encoding.ASCII.GetBytes(password);
            var base64String = Convert.ToBase64String(passwordHashed);
            return base64String;
        }

        public async Task<UserDto> Update(UserDto userDto)
        {
            var userMapped = _mapper.Map<Models.User.User>(userDto);
            userMapped.Password = CreateHashPasword(userMapped.Password);

            await _userRepository.UpdateAsync(userMapped);
            await _userRepository.Save();

            return _mapper.Map<UserDto>(userMapped);
        }

        public async Task Remove(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if(user == null) throw new Exception("Usuário não encontrado");

            await _userRepository.DeleteAsync(user);
            await _userRepository.Save();
        }
    }
}
