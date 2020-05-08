using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using apilog.Data;
using apilog.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace apilog.Services
{
    public class UsuarioServices : IUsuario
    {
        private readonly MyContext _Context;
        public UsuarioServices(MyContext Context, IConfiguration configuration)
        {
            _Context = Context;
             Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public IEnumerable<Usuario> GetAll()
        {
            return _Context.Usuarios.ToList();
        }

        public async Task<Usuario> GetUserbyId(Guid Id)
        {             
            return await _Context.Usuarios.FindAsync(Id);
        }
        public async Task Add(Usuario usuario)
        {
            _Context.Usuarios.Add(usuario);
            await Savechanges();
        }

        public async Task Remove(Guid Id)
        {
           var user = await _Context.Usuarios.FindAsync(Id);
           _Context.Usuarios.Remove(user);
           await Savechanges();
        }

        public async Task Update(Usuario usuario)
        {            
            _Context.Usuarios.Update(usuario);
            await Savechanges();
        }
         public async Task<int> Savechanges()
        {
            return await _Context.SaveChangesAsync();
        } 

        public Usuario Authenticate(string Email, string password)
        {
            var user = _Context.Usuarios.Where(x => x.Email == Email && x.Password == password).FirstOrDefault();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration["SecurentKey"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Email)
                   
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Email = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }
    }
}