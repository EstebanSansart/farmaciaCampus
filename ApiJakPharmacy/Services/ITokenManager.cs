using System.Security.Claims;
using ApiJakPharmacy.Dtos;
using Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace ApiJakPharmacy.Services;
public interface ITokenManager{
    string CreateAccessToken(User user);
    string CreateRefreshToken();
    User CreateUser(UserSignup model);
    bool ValidatePassword(User user, string password);
}
