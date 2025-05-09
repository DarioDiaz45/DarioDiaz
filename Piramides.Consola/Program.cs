﻿using Piramide.Entidades;

using System.ComponentModel.DataAnnotations;

internal class Program
{

   
    private static void Main(string[] args)
    {
        Console.WriteLine(" Registro de Pirámides Cuadradas");

        do
        {
            int lado = LeerEntero("Ingrese el valor del lado de la base: ");
            int altura = LeerEntero("Ingrese la altura de la pirámide: ");

            var piramide = new PiramideCuadradas(lado, altura);
            var context = new ValidationContext(piramide);
            var errores = new List<ValidationResult>();

            bool esValida = Validator.TryValidateObject(piramide, context, errores, true);

            if (esValida)
            {
                Console.WriteLine(" Pirámide creada correctamente:");
                Console.WriteLine(piramide);

                
                
            }
            else
            {
                Console.WriteLine(" Errores de validación:");
                foreach (var error in errores)
                {
                    Console.WriteLine($" {error.ErrorMessage}");
                }
            }

        } while (PreguntarContinuar("¿Desea cargar otra pirámide?"));

        Console.WriteLine(" Se guardaron las pirámides en el archivo: " );
    }

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
        Console.Write($"{mensaje} : ");
        var resp = Console.ReadLine().Trim().ToUpper();
        return resp == "SI";
    }

    
}
    
