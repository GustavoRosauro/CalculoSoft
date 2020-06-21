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
            string calculo =  SoftRule.RetornaCalculo(200, 9,"", true, 0.01).Result;
            Assert.AreEqual(calculo,"218,73");
        }
    }
}
