using Piramide.Entidades;
using System.ComponentModel.DataAnnotations;
namespace Piramide.Test
{
    [TestClass]
    public sealed class Piramide
    {
        [TestMethod]
        public void PruebaMetodoApotemaOK()
        {
            
            int lado = 4;
            int altura = 3;
            var piramide = new PiramideCuadradas(lado, altura);

            
            var apotema = piramide.GetApotema();

            
            Assert.AreEqual(3.61, apotema, 0.01);

        }
        public void PruebaMetodoAreaOK()
        {
            int lado = 4;
            int altura = 3;
            var piramide = new PiramideCuadradas(lado, altura);
            var area = piramide.GetArea();
            Assert.AreEqual(32.0, area, 0.01);
        }
        public void PruebaMetodoVolumenOK()
        {
            int lado = 4;
            int altura = 3;
            var piramide = new PiramideCuadradas(lado, altura);
            var volumen = piramide.GetVolumen();
            Assert.AreEqual(16.0, volumen, 0.01);
        }
        public void PruebaValidacionDatosInvalidos()
        {
            
            int lado = 0;
            int altura = -5;
            var piramide = new PiramideCuadradas(lado, altura);
            var context = new ValidationContext(piramide);
            var results = new List<ValidationResult>();

            
            var isValid = Validator.TryValidateObject(piramide, context, results, true);

            
            Assert.IsFalse(isValid);
            Assert.AreEqual(2, results.Count);
            Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains("lado")));
            Assert.IsTrue(results.Exists(r => r.ErrorMessage.Contains("altura")));
        }
    }
}
