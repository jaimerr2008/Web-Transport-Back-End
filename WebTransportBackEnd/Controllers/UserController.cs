
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTransportBackEnd.Context;
using WebTransportBackEnd.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
namespace WebTransportBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly string secreckey;

        public UserController(AppDbContext context,IConfiguration config)
        {
            _context = context;

            secreckey = config.GetSection("settings").GetSection("secretkey").ToString();
        }




        [HttpPost]
        public async Task<ActionResult<User>> Login(LoginUser Login)
        {
            
            var user = await _context.Users.FirstOrDefaultAsync(u => u.user == Login.user && u.password== Login.password );
            if (user == null)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { token = "" });
            }
            var keyBytes = Encoding.ASCII.GetBytes(secreckey);
            var claims = new ClaimsIdentity();
                claims.AddClaim(new Claim(ClaimTypes.NameIdentifier,Login.user));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject=claims,
                Expires=DateTime.UtcNow.AddMinutes(120),
                SigningCredentials= new SigningCredentials(new SymmetricSecurityKey(keyBytes),SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

            string tokencreado = tokenHandler.WriteToken(tokenConfig);
                return StatusCode(StatusCodes.Status200OK,new {token=tokencreado});
        }


    }
}