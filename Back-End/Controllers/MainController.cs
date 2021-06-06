using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace QRExpresso.API.Controllers
{
    public abstract class MainController : ControllerBase
    {
        protected ActionResult Resposta(bool success, object result)
        {
            return Ok(new
            {
                Success = success,
                Data = result
            });
        }
    }
}