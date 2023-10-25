using Ejercicio2Bucles.Servicios;

namespace Ejercicio2Bucles
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Declaramos las variables
            int exponente;
            double numero, total;

            //Instanciamos las clases donde se encuentran los métodos
            PedirNumeroInterfaz pni = new PedirNumeroImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();

            //Pedimos los números al usuario
            numero = pni.pedirNumeroDecimal();
            exponente = pni.pedirNumeroEntero();

            //Realizamos la operacion con los números dados por el usuario
            total = oi.potenciaNumero(exponente, numero);
        }
    }
}