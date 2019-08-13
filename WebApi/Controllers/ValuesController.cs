using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello";
        }
        // GET api/values/5
        [HttpGet("{getParams}")]
        public ActionResult<string> Get(string getParams)
        {
            return getParams == "Hello" ? "Hey" : "Hello";
        }

        
    }
}
