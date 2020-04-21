using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class OtrosTests
    {
        /*
        [SetUp]
        public void Setup()
        {
           
        }*/

        [Test]
        public void ElMetodoDebeConvertirBarrasDeFechaEnGuiones()
        {
            //Arrange
            OtroFormato date1 = new OtroFormato();

            //Act
            date1.ConvertirSeparadores("02/01/2020");
            
            //Assert
            Assert.AreEqual("02-01-2020", date1.Valor);
        }
    }
}
