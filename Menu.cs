using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Menu
    {
        public Menu(int seleccion, int numero1, int numero2)
        {
            if (seleccion < 1 || seleccion > 4)
            {
                Console.WriteLine("No existe esa opción");
            }
            else
            {
                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine($"Resultado de la suma: {numero1 + numero2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado de la resta: {numero1 - numero2}");
                        break;
                    case 3:
                        if (numero2 != 0)
                        {
                            Console.WriteLine($"Resultado de la división: {numero1 / (double)numero2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}