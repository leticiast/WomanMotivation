using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WomanMotivation_.Models;
using System;

namespace WomanMotivation_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WomanController : ControllerBase
    {
        static int count = -1;
        static DateTime diaAnterior;
        static List<FraseMotivacional> lista = Frases.lista;

        [EnableCors("Policy1")]
        [HttpGet]
        public FraseMotivacional RetornaFraseDia()
        {
            var diaAtual = DateTime.Today;
            var result = diaAtual.CompareTo(diaAnterior);
            if (result == 1)
            {
                diaAnterior = diaAtual;
                count++;
            }
            return lista[count];
        }

    }
}
