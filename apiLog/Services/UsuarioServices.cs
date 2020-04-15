using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilog.Data;
using apilog.Models;

namespace apilog.Services
{
    public class UsuarioServices : IUsuario
    {
        private readonly MyContext _Context;
        public UsuarioServices(MyContext Context)
        {
            _Context = Context;
        }
       

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
    }
}