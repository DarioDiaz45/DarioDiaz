using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Piramide.Entidades
{
    public class PiramideCuadradas : IValidatableObject
    {
        private int lado;
        private int altura;

        public PiramideCuadradas(int lado, int altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public int Lado => lado;
        public int Altura => altura;

        public double GetApotema()
        {
            return Math.Sqrt(Math.Pow(lado / 2.0, 2) + Math.Pow(altura, 2));
        }

        public double GetArea()
        {
            double areaBase = Math.Pow(lado, 2);
            double areaLateral = 2 * lado * GetApotema();
            return areaBase + areaLateral;
        }

        public double GetVolumen()
        {
            return (Math.Pow(lado, 2) * altura) / 3.0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pirámide Cuadrada de lado: {lado}");
            sb.AppendLine($"Altura...................: {altura}");
            sb.AppendLine($"Apotema..................: {GetApotema():F2}");
            sb.AppendLine($"Área.....................: {GetArea():F2}");
            sb.AppendLine($"Volumen..................: {GetVolumen():F2}");
            return sb.ToString();
        }

        public string MostrarInfo()
        {
            return $"Piramide Cuadrada de Lado: {lado} Altura: {altura}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (lado <= 0)
            {
                yield return new ValidationResult("El lado debe ser positivo");
            }
            if (altura <= 0)
            {
                yield return new ValidationResult("La altura debe ser positiva");
            }
        }
    }
}

