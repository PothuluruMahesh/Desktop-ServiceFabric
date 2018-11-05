using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : Controller
    {
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Mahesh", "Pothuluru","HelloWorld" };
        }
    }
}