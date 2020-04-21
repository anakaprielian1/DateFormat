using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class Tests
    {
        private Format fecha1;
        string fechaTest;
        

        [SetUp]
        public void Setup()
        {
            fecha1 = new Format();
            fechaTest = "09/02/2020";
            
        }

        [Test]
        public void TestChangeFormatModificaFormatoCorrectamente()
        {
            Assert.AreEqual("2020-02-09", fecha1.ChangeFormat("09/02/2020"));
        }

        [Test]
        public void TestLargoDeFechaCorrectoIgualA10()
        
        {
            Assert.AreEqual(10, fecha1.ChangeFormat(fechaTest).Length, "formato aceptado dd/mm/aaaa");
        }

        [Test]
        public void TestVerificacionMesEntre1y12()
        {
            string[] arrayMeses = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"};
            string[] mes = new string[] {fecha1.ChangeFormat(fechaTest).Substring(5,2)};

            Assert.That(mes, Is.SubsetOf(arrayMeses));
        }

        [Test]
        public void TestAnioValorPositivo()
        {
            string anio = fecha1.ChangeFormat(fechaTest).Substring(0,4);
            int numAnio = int.Parse(anio);

            Assert.IsTrue(numAnio > 0);
        }

        [Test]
        public void TestVerificacionDiaEntre1y31()
        {
            string dia = fecha1.ChangeFormat(fechaTest).Substring(8);
            int numDia = int.Parse(dia);

            Assert.IsTrue(numDia >0 && numDia < 32);
        }


    }
}