using APIdeAtividades.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIdeAtividades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<ProfessorModel>> BuscarProfessores()
        {
            return Ok();
        }
    }
}
