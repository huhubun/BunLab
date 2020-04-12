using BunLab.Shared.Models.Informations;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BunLab.Server.Controllers
{
    [Route("api/informations")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        [HttpGet(template: "")]
        public IActionResult GetServerInformation()
        {
            var assemblyName  = Assembly.GetExecutingAssembly().GetName();

            return Ok(new ServerInformationModel
            {
                Name = assemblyName.Name,
                Version = assemblyName.Version.ToString(),
                RuntimeFramework = RuntimeInformation.FrameworkDescription,
                OS = RuntimeInformation.OSDescription
            });
        }
    }
}