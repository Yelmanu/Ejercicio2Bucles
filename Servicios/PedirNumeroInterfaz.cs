using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bucles.Servicios
{
    /// <summary>
    /// Interfaz para pedir los números necesarios para la aplicación
    /// 251023 - MDN
    /// </summary>
    internal interface PedirNumeroInterfaz
    {
        /// <summary>
        /// Método para pedir el número de veces que se multiplicara el número decimal
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumeroEntero();

        /// <summary>
        /// Método para pedir el número decimal al usuario por consola
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public double pedirNumeroDecimal();
    }
}
