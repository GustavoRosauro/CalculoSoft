using NUnit.Framework;
using TaxaSoft.Controllers;

namespace TesteSoft
{
    public class TaxaSoft
    {
       
        [Test]
        public void ValidaTaxa()
        {
            double taxa = new TaxaJurosController().Taxa();
            Assert.AreEqual(0.01,taxa);
        }
    }
}