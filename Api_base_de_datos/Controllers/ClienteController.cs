using Api_base_de_datos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_base_de_datos.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : Controller
    {
        private readonly BaseDeDatosContext _context;
        public ClienteController(BaseDeDatosContext ctx)
        {
            _context = ctx;
        }

    [HttpGet("ListarUsuarios")]
    public ActionResult<List<Cliente>> ListarCliente()
        {
            return _context.Clientes.ToList();
        }
        [HttpGet("ObtenerUsuario/{id}")]
        public ActionResult<Cliente> ObtenerUsuario(int id)
        {
            return _context.Clientes.FirstOrDefault(e => e.IdCliente == id);
        }
    }
}
