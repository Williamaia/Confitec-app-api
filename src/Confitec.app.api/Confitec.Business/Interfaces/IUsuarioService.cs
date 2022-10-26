using Confitec.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Business.Interfaces
{
    public interface IUsuarioService : IDisposable
    {
        Task<bool> Adicionar(Usuarios usuario);
        Task<bool> Atualizar(Usuarios usuario);
        Task<bool> Remover(int id);

    }
}
