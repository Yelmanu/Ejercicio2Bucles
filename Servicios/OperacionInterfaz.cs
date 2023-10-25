using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bucles.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de realizar la operación con los numeros pedidos
    /// 251023 - MDN
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Método para realizar la potencia del número dado por el usuario al exponente también dado por el usuario
        /// 251023 - MDN
        /// </summary>
        /// <param name="exponente"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public double potenciaNumero(int exponente, double numero);
    }
}
