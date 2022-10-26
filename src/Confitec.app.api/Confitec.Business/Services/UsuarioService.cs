using Confitec.Business.Interfaces;
using Confitec.Business.Models;
using System;
using System.Threading.Tasks;

namespace Confitec.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task Adicionar(Usuarios usuario)
        {
           await _usuarioRepository.Adicionar(usuario);
        }

        public async Task Atualizar(Usuarios usuario)
        {
            await _usuarioRepository.Atualizar(usuario);
        }

        public async Task Remover(int id)
        {
            await _usuarioRepository.Remover(id);
        }

        public void Dispose()
        {
            _usuarioRepository?.Dispose();
        }
    }
}
