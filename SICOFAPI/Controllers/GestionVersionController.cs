using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SICOFBusiness.Interface;
using SICOFModels.Model;

namespace SICOFAPI.Controllers
{


    /// <summary>
    /// Comunicacion por POST 
    /// </summary>
    //[Route("api/SICOF/Version")] 
    //[ApiController]

    [Route("api/[controller]")]
    public class GestionVersionController : ControllerBase
    {
        private readonly ILogger _logger;
        private IGestionVersionBusiness _gestionVersionBusiness;



        /// <summary>
        /// Inyección de dependencias comunicación con la capa de Business
        /// </summary>
        /// <param name="gestionVersionBusiness">GestionVesion from Business</param>
        /// <param name="logger">Log4nET</param>
        public GestionVersionController(IGestionVersionBusiness gestionVersionBusiness, ILogger<GestionVersionController> logger)
        {
            _gestionVersionBusiness = gestionVersionBusiness;
            _logger = logger;
        }




        /// <summary>
        /// 
        /// </summary>
        [HttpPost]
        [Route("ConsultarVersionSICOF")] //Averiguar parametro
        public ActionResult ConsultarVersionSICOF()
        {
            try
            {
                //Ini Log
                _logger.LogInformation("Se inicia el metodo ConsultarVersionSICOF");

                VersionDTO ultimaVerion = _gestionVersionBusiness.ConsultarVersionSICOF();

                _logger.LogInformation("Se Finaliza el metodo ConsultarVersionSICOF");
                return Ok(ultimaVerion);
                                
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        
        }
    }
}
