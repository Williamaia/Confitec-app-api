using Confitec.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Business.Interfaces
{
    public interface IUsuarioService : IDisposable
    {
        Task Adicionar(Usuarios usuario);
        Task Atualizar(Usuarios usuario);
        Task Remover(int id);

    }
}
