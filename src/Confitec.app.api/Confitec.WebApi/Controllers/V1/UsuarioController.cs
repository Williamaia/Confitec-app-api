using AutoMapper;
using Confitec.Business.Interfaces;
using Confitec.Business.Models;
using Confitec.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Confitec.WebApi.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<UsuarioViewModel>> ObterTodos()
        {
            var usuarios = _mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodos());

            return usuarios;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> ObterPorId(int id)
        {
            var usuario = await _usuarioRepository.ObterPorId(id);

            if (usuario == null) return NotFound();

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioViewModel>> Adicionar(UsuarioViewModel usuarioViewModel)
        {
            //if (!ModelState.IsValid) return BadRequest(ModelState);

            await _usuarioService.Adicionar(_mapper.Map<Usuarios>(usuarioViewModel));

            return Created("", usuarioViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Atualizar(int id, UsuarioViewModel usuarioViewModel)
        {
            if (id != usuarioViewModel.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _usuarioService.Atualizar(_mapper.Map<Usuarios>(usuarioViewModel));

            return Created("", usuarioViewModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Excluir(int id)
        {
            var usuario = await _usuarioRepository.ObterPorId(id);

            if (usuario == null) return NotFound();

            await _usuarioService.Remover(id);

            return NoContent();
        }
    }
}
