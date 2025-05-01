using ShopIt.Data;
using ShopIt.DTOs;
using ShopIt.Models.ValueObject;
using ShopIt.Models;

namespace ShopIt.Services
{
    public class RegistrationService
    {
        private readonly ApplicationDbContext _dbContext;

        public RegistrationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> RegisterAsync(RegisterDTO registerDTO)
        { 
            if (_dbContext.Set<ApplicationUser>().Any(u => u.Email == registerDTO.Email))
                throw new Exception("Email already in use.");

            var user = new ApplicationUser
            {
                Username = registerDTO.Username,
                Email = registerDTO.Email,
                PasswordHash = registerDTO.Password,
                ShippingAddress = new Address
                {
                    Street = registerDTO.ShippingAddress.Street,
                    City = registerDTO.ShippingAddress.City,
                    State = registerDTO.ShippingAddress.State,
                    ZipCode = registerDTO.ShippingAddress.ZipCode,
                    Country = registerDTO.ShippingAddress.Country
                }
            };

            _dbContext.Set<ApplicationUser>().Add(user);
            await _dbContext.SaveChangesAsync();

            return "User registered successfully";
        }
    }
}
