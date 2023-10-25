using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Bucles.Servicios
{
    /// <summary>
    /// Implementación de la interfaz para las operaciones
    /// 251023 - MDN
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public double potenciaNumero(int exponente, double numero)
        {
            double total = 0;
            double numeroAnterior = numero;
            for (int i = 0; i < exponente; i++)
            {
                total = numeroAnterior * numero;
            }
            Console.WriteLine("El resultado de elevar {0} a {1} es: {2}",numero,exponente,total);

            return total;
        }
    }
}
