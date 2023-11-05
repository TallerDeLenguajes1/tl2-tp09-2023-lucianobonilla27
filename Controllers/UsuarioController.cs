using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tl2_tp09_2023_lucianobonilla27.Models;

namespace tl2_tp09_2023_lucianobonilla27.Controller
{
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private UsuarioRepository manejo;

       public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
            manejo = new UsuarioRepository();
        }

    [HttpPost]
    [Route("CrearUsuario")] 
    public IActionResult CrearUsuario(Usuario u) 
     {
        manejo.CrearUsuario(u);
        return Ok("Usuario creado con éxito");
    }

    [HttpGet]
    [Route("ListarUsuarios")]
    public IActionResult ListarUsuarios(){
        var usuarios = manejo.ListarUsuarios();
        return Ok(usuarios);
    }

      
    }
}