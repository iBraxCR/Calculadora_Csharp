using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Imprime las opciones del menú en la consola
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. División");
            Console.WriteLine("4. Salir");

            // Lee la entrada del usuario desde la consola
            string input = Console.ReadLine();
            int seleccion;

            // Intenta convertir la entrada del usuario a un entero
            if (int.TryParse(input, out seleccion) && seleccion >= 1 && seleccion <= 4)
            {
                if (seleccion == 4)
                {
                    Console.WriteLine("Saliendo del programa...");
                    return;
                }

                // Solicita el primer número
                Console.WriteLine("Por favor ingrese el primer número");
                string input2 = Console.ReadLine();
                int numero1;

                if (int.TryParse(input2, out numero1))
                {
                    // Solicita el segundo número
                    Console.WriteLine("Por favor ingrese el segundo número");
                    string input3 = Console.ReadLine();
                    int numero2;

                    if (int.TryParse(input3, out numero2))
                    {
                        // Si las conversiones son exitosas, crea una instancia de la clase Menu pasando la selección del usuario y los dos números
                        Menu menu = new Menu(seleccion, numero1, numero2);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para el segundo número. Por favor, ingrese un número.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida para el primer número. Por favor, ingrese un número.");
                }
            }
            else
            {
                // Si la conversión falla o la selección está fuera de rango, informa al usuario que la entrada no es válida
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 4.");
            }
        }
    }
}