using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Contact")]
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] ContactPostRequestModel model)
        {
            return Ok(new
            {
                DateTime = DateTime.Now,
                Model = model
            });

        }

        public class ContactPostRequestModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }

        }


    }
}