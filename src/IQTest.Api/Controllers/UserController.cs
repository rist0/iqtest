using IQTest.Api.Helpers;
using IQTest.Api.Models.User;
using IQTest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IQTest.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtSettingsOptions _jwtSettings;

        public UserController(IUnitOfWork unitOfWork, IOptions<JwtSettingsOptions> jwtSettingsOptions)
        {
            _unitOfWork = unitOfWork;
            _jwtSettings = jwtSettingsOptions.Value;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateUserModel authenticationUserModel)
        {
            var user = _unitOfWork.Users.Authenticate(authenticationUserModel.Username, authenticationUserModel.Password);

            if (user == null)
            {
                return BadRequest(new { Message = "Username or password is incorrect." });
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationTimeInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                EmailAddress = user.EmailAddress,
                Token = tokenString
            });
        }
    }
}
