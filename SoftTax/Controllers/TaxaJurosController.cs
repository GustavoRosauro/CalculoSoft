using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaxaSoft.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Endpoint com taxa fixa será consumido em outra api
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public  double Taxa()
        { 
            return 0.01;
        }
    }
}