using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculoSoft.Communs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoSoft.Controllers
{
    [Route("")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// Endpoint que calcula os juros levando em consideração a taxa nossa api TaxaSoft
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<double> CalculaJuros(double valorinicial, double meses)
        {
            //retorna calculo Valor Inicial * (1 + juros)^tempo
            return await SoftRule.RetornaCalculo(valorinicial, meses);
        }
        /// <summary>
        /// Retorna HTML para clicar e redirecionar para o GIT
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public ContentResult ShowmeTheCode()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)System.Net.HttpStatusCode.OK,
                Content = "<html><body><h1><a href='https://github.com/GustavoRosauro/CalculoSoft/'>GIT HUB</a></h1><h1><a href='https://hub.docker.com/repository/docker/gustavorosauro/calculosoft'>Docker CalculoSoft</a></h1><h1><a href='https://hub.docker.com/repository/docker/gustavorosauro/taxasoft'>Docker TaxaSoft</a></h1></body></html>"
            };
        }
    }
}