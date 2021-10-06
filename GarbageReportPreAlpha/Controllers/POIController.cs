using Microsoft.AspNetCore.Mvc;
using GarbageReportPreAlpha.Entities;

namespace GarbageReportPreAlpha.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class POIController : ControllerBase
    {

        // En esta seccion es donde iran los métodos relacionados con los puntos de interes/denuncias, aqui se podran dar de alta, de baja y editarse. de igual manera se
        //irán los metodos de filtrado
         public string Post (POIDTO punto)
        {
            string name = punto.Motivo;
            
            return name;
        }
    }
}