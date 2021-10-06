using Microsoft.AspNetCore.Mvc;
using GarbageReportPreAlpha.Entities;

namespace GarbageReportPreAlpha.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        // En esta seccion es donde iran los métodos relacionados con los usuarios, aqui se podran dar de alta, de baja y editarse.
        //permitira el acceso a la base de datos para el sistema deinicio de sesion
         public string Post (PersonDTO persona)
        {
            string name = persona.Nombre;
            
            return name;
        }
    }
}