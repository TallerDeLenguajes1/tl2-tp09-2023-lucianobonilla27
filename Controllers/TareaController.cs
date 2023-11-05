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
    public class TareaController : ControllerBase
    {
        private readonly ILogger<TareaController> _logger;
        private TareaRepository manejo;

        public TareaController(ILogger<TareaController> logger)
        {
            _logger = logger;
            manejo = new TareaRepository();
        }

    [HttpPost]
    [Route("CrearTareaEntablero")]
    public IActionResult CrearTareaEnTablero(int idTablero,Tarea t)
    {
        var tarea = manejo.CrearTareaEnTablero(idTablero,t);
        return Ok(tarea);
    }

    [HttpPut]
    [Route("ModificarNombreTarea")]
    public IActionResult ModificarNombreTarea(int id, string nombre)
    {
        manejo.ModificarNombreTarea(id,nombre);
        return Ok("Nombre de tarea modificado con éxito");
    }

    [HttpPut]
    [Route("ModificarEstadoTarea")]
    public IActionResult ModificarEstadoTarea(int id, int estado)
    {
        manejo.ModificarEstadoTarea(id,estado);
        return Ok("Estado de tarea modificado con éxito");
    }

    [HttpDelete]
    [Route("EliminarTarea")]
    public IActionResult EliminarTarea(int id)
    {
        manejo.EliminarTarea(id);
        return Ok("Tarea eliminada con éxito");
    }

    [HttpGet]
    [Route("CantidadDeTareasPorEstado")]
    public IActionResult CantidadTareasPorEstado(Tarea.Estado estado)
    {
        // Implementa la lógica para contar la cantidad de tareas en un estado
        int cantidad = 0; // Reemplaza con el valor real
        return Ok($"Cantidad de tareas en estado {estado}: {cantidad}");
    }

    [HttpGet]
    [Route("ListarTareasAsignadasAUsuario")]
    public IActionResult ListarTareasAsignadasAUsuario(int id)
    {
        var tareas = manejo.ListarPorUsuario(id);
        return Ok(tareas);
    }

    [HttpGet]
    [Route("ListarTareasDeTablero")]
    public IActionResult ListarTareasDeTablero(int id)
    {
        var tareas = manejo.ListarPorTablero(id);
        return Ok(tareas);
    }
        
    }
}