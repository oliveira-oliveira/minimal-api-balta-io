using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Usuario;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private static List<Usuarios> listaUsuarios = new List<Usuarios>();

        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok(listaUsuarios);
        }

        [HttpGet("/{id:Guid}")]
        public IActionResult GetById([FromHeader] Guid id)
        {
            var usuario = listaUsuarios.FirstOrDefault(x => x.Id == id);
            return Ok(usuario);
            
            //return BadRequest("Id inválido");
            
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] Usuarios usuarios)
        {
            if (usuarios == null)
            {
                return BadRequest("Usuário inválido.");
            }

            usuarios.Id = Guid.NewGuid();
            listaUsuarios.Add(usuarios);

            return CreatedAtAction(nameof(Get), new { id = usuarios.Id }, usuarios);
        }
        
        [HttpPut("/{id:Guid}")]
        public IActionResult Put([FromRoute] Guid id, Usuarios usuarios)
        {
            if (id == null)
            {
                return BadRequest("Usuário inválido.");
            }

            var update = listaUsuarios.FirstOrDefault(x => x.Id == id);
            update.Nome = usuarios.Nome;

            return Ok(update);
        }
        
        [HttpDelete("/{id:Guid}")]
        public IActionResult Delete([FromRoute] Guid id, Usuarios usuarios)
        {
            if (usuarios == null)
            {
                return BadRequest("Usuário inválido.");
            }

            var delete = listaUsuarios.FirstOrDefault(x => x.Id == id);
            listaUsuarios.Remove(delete);

            return Ok();
        }
        
    }
}
