using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using apilog.Models;

namespace apilog.Services
{
    public interface IUsuario
    {
        IEnumerable<Usuario> GetAll();
        Task<Usuario> GetUserbyId(Guid Id);
        Task Add(Usuario usuario);
        Task Update(Usuario usuario);
        Task Remove(Guid Id);
       

    }
}