using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using System.Text.RegularExpressions;

namespace HantahaAPI.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IPasswordService _passwordService;
        private readonly IUserRepository _userRepository;

        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork,
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
            entity.IsAdmin = false;
            entity.IsActive = true;

            return base.AddAsync(entity);
        }

        public async Task<List<UserListDto>> GetUserList()
        {
            return await _userRepository.GetUserList();
        }

        public async Task<bool> CheckPassAndGetUserAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByEmail(loginDto.Email);

            if (user == null)
                return false;
            else if (!_passwordService.
                CompareEncrytedAndUnencryptedPassword(user.Password, user.LastIV, loginDto.Password))
                return false;
            return true;
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _userRepository.GetByEmail(email);
        }


        public bool ValidateUserPassword(UserCreateDto userCreateDto, out string errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(userCreateDto.Password) || string.IsNullOrWhiteSpace(userCreateDto.RePassword))
            {
                errorMessage = "Şifre alanları boş olamaz.";
                return false;
            }

            if (userCreateDto.Password != userCreateDto.RePassword)
            {
                errorMessage = "Şifreler uyuşmuyor.";
                return false;
            }

            if (userCreateDto.Password.Length < 12)
            {
                errorMessage = "Şifre en az 12 karakter uzunluğunda olmalıdır.";
                return false;
            }

            if (!ContainsRequiredCharacters(userCreateDto.Password))
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

        public async Task UpdateAsync(UserUpdateDto updateDto,int updatedBy)
        {
            var user =await _userRepository.GetByIdAsync(updateDto.Id);

            user.UpdatedOn = DateTime.UtcNow;
            user.UpdatedBy = updatedBy;
            user.UpdatedOn = DateTime.Now;
            user.IsActive = updateDto.IsActive;
            user.IsAdmin = updateDto.IsAdmin;

            _userRepository.Update(user);
        }
    }
}

