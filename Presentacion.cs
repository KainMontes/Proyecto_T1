using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T1
{
    internal class Presentacion
    {
        public int Logo1()
        {
            int vc = 0;
            while (vc < 1 || vc > 10)
            {
                Console.WriteLine("\t\t BIENVENIDO AL PROGRAMA DE REGISTRO DE LA RENIEC ");
                Console.WriteLine("\t*********************************************+*******************");
                Console.WriteLine(" ");
                Console.WriteLine("\t [1] Registrar Persona al Incio"); 
                Console.WriteLine("\t [2] Eliminar Informe Personal");
                Console.WriteLine("\t [3] Limpiar Registro completo"); 
                Console.WriteLine("\t [4] Ordenar Ascendente"); 
                Console.WriteLine("\t [5] Ordenar Descendente"); 
                Console.WriteLine("\t [6] Buscar Persona (DNI)");
                Console.WriteLine("\t [7] Impresión del documento"); 
                Console.WriteLine("\t [8] salir");
                Console.WriteLine(" ");
                Console.Write("\tSeleccione una opción : ");
                vc = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            return vc;
        }
        //Líneas para elegir la dirección del proceso
        public int Direccion()
        {
            int opc = 0;
            while (opc < 1 || opc > 4)
            {
                Console.WriteLine("\n");
                Console.WriteLine(" \t\t   *~ Elija Dirección *~ ");
                Console.WriteLine("\t\t--------------------------");
                Console.WriteLine("");
                Console.WriteLine("\t [1] Al Inicio ");
                Console.WriteLine("\t [2] Según Posición ");
                Console.WriteLine("\t [3] Al Final");
                Console.WriteLine("");
                Console.Write("\tDigite la opción: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return opc;
        }
    }
}
