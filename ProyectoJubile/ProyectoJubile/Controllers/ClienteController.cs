using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoJubile.DAL;
using ProyectoJubile.Models;

namespace ProyectoJubile.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly MyAppDbContext _context;

        public ClienteController(MyAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var client = _context.Cliente.ToList();
                if (client.Count == 0)
                {
                    return NotFound("Cliente No Disponible");
                }
                return Ok(client);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var client = _context.Cliente.Find(id);
                if (client == null)
                {
                    return NotFound($"El listado de los clientes no ha sido encontrado del id {id}");
                }
                return Ok(client);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
        public IActionResult Post(Cliente model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok("El Cliente ha sido creado exitosamente.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Cliente model)
        {
            if (model == null || model.idCliente == 0)
            {
                if (model == null)
                {
                    return BadRequest("Cliente es invalido");
                }
                else if (model.idCliente == 0)
                {
                    return BadRequest($"Cliente id {model.idCliente} es invalido.");
                }
            }
            var client = _context.Cliente.Find(model.idCliente);
            if (client == null)
            {
                return NotFound($"Cliente no encontrado por el id {model.idCliente}");
            }

            try
            {
                client.idCliente = model.idCliente;
                client.NombreCliente = model.NombreCliente;
                client.ApellidoCliente = model.ApellidoCliente;
                client.RutCliente = model.RutCliente;
                client.NacCliente = model.NacCliente;
                client.FecCliente = model.FecCliente;
                client.AFP = model.AFP;
                client.UF = model.UF;
                client.TelefonoCliente = model.TelefonoCliente;
                client.DireccionCLiente = model.DireccionCLiente;
                client.CuidadCliente = model.CuidadCliente;
                client.Cargo = model.Cargo;
                client.Email = model.Email;
                client.Observaciones = model.Observaciones;
                _context.SaveChanges();
                return Ok("El Cliente ha sido Actualizado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var client = _context.Cliente.Find(id);
                if (client == null)
                {
                    return NotFound($"Cliente no encontrado por el id {id}");
                }
                _context.Cliente.Remove(client);
                _context.SaveChanges();
                return Ok("El cliente ha sido Eliminado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
