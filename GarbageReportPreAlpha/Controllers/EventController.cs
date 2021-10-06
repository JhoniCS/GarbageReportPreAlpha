using Microsoft.AspNetCore.Mvc;
using GarbageReportPreAlpha.Entities;
using System;
using System.Linq;

namespace GarbageReportPreAlpha.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        // En esta seccion es donde iran los métodos prealcionados con los eventos, aqui se podran dar de alta, de baja y editarse.
        public string Post (EventDTO evento)
        {
            string name = evento.Nombre.ToLower();
            
            return name;
        }
    }
}