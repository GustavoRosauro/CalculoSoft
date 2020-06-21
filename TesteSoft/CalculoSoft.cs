using CalculoSoft.Communs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSoft
{
    public class CalculoSoft
    {
        [Test]
        public void ValidaCalculo()
        {
            string calculo =  SoftRule.RetornaCalculo(100, 5,"", true, 0.01).Result;
            Assert.AreEqual(calculo,"105,10");
        }
    }
}
