using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lessons1.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class dasboardController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "values"};
        }
    
     }
 }

 