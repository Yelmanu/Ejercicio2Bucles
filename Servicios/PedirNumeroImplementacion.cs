using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bucles.Servicios
{
    /// <summary>
    /// Implementacion de la interfaz para pedir los números necesarios
    /// 251023 - MDN
    /// </summary>
    internal class PedirNumeroImplementacion : PedirNumeroInterfaz
    {
        /// <summary>
        /// Método para pedir el número decimal al usuario por consola
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public double pedirNumeroDecimal()
        {
            Console.WriteLine("Introduzca un número décimal (Recuerda que se usa la coma no el punto): ");
            double numero = Convert.ToDouble(Console.ReadLine());
            return numero;
        }

        /// <summary>
        /// Método para pedir el número de veces que se multiplicara el número decimal
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumeroEntero()
        {
            Console.WriteLine("Introduzca el número de veces que se va a multiplicar el numero décimal por si mismo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
