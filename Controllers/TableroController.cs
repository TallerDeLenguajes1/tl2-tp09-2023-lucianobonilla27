using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tl2_tp09_2023_lucianobonilla27.Models;

namespace tl2_tp09_2023_lucianobonilla27.Controllers
{
    [Route("[controller]")]
    public class TableroController : ControllerBase
    {
        private readonly ILogger<TableroController> _logger;
        private TableroRepository manejo;

        public TableroController(ILogger<TableroController> logger)
        {
            _logger = logger;
            manejo = new TableroRepository();
        }

    [HttpPost]
    [Route("CrearTablero")] 
    public IActionResult CrearTablero(Tablero t)    
     {
        manejo.CrearTablero(t);
        return Ok("Tablero creado con éxito");
    }

    [HttpGet]
    [Route("ListarTableros")]
    public IActionResult ListarTableros(){
        var tableros = manejo.ListarTableros();
        return Ok(tableros);
    }
    }
}