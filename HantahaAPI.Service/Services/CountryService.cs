using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using System.Text.RegularExpressions;

namespace HantahaAPI.Service.Services
{
    public class CountryService : BaseService<User>, IUserService
    {
        private readonly IPasswordService _passwordService;
        private readonly IUserRepository _userRepository;

        public CountryService(IGenericRepository<Country> repository, IUnitOfWork unitOfWork,
            IPasswordService passwordService,IUserRepository userRepository
            ) : base(repository, unitOfWork)
        {
            _passwordService = passwordService;
            _userRepository = userRepository;
        }

        public override Task<User> AddAsync(User entity)
        {
            entity.Password = _passwordService.EncryptPassword(entity.Password, out string vectorIV);
            entity.LastIV = vectorIV;
            entity.CreatedOn = DateTime.Now.ToUniversalTime();
            entity.IsActive = true;

            entity.UserRoles = new List<UserRole>();
            entity.UserRoles.Add(new UserRole { RoleId=2,User=entity,IsActive = true });

            return base.AddAsync(entity);
        }

        public async Task<User> CheckPassAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByUsername(loginDto.Username);

            if (user == null)
                return user;
            else if (!_passwordService.
                CompareEncrytedAndUnencryptedPassword(user.Password, user.LastIV, loginDto.Password))
                return null;
            return user;
        }


        public bool ValidateUserPassword(UserDto userDto, out string errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(userDto.Password) || string.IsNullOrWhiteSpace(userDto.RePassword))
            {
                errorMessage = "Şifre alanları boş olamaz.";
                return false;
            }

            if (userDto.Password != userDto.RePassword)
            {
                errorMessage = "Şifreler uyuşmuyor.";
                return false;
            }

            if (userDto.Password.Length < 12)
            {
                errorMessage = "Şifre en az 12 karakter uzunluğunda olmalıdır.";
                return false;
            }

            if (!ContainsRequiredCharacters(userDto.Password))
            {
                errorMessage = "Şifre büyük harf, küçük harf, rakam ve sembol içermelidir.";
                return false;
            }


            return true;
        }

        private static bool ContainsRequiredCharacters(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$");
        }
    }
}

