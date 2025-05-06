

namespace Piramides.Entidades
{
    public class ExtensionesConsola
    {
        public static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Error. Reingrese: ");
            }
            return valor;
        }

        public static bool PreguntarContinuar(string mensaje)
        {
            Console.Write($"{mensaje} SI/NO: ");
            var resp = Console.ReadLine().Trim().ToUpper();
            return resp == "S";
        }
    }
}
