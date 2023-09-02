using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona lista = new Persona();
            lista = null;
            int var, opc;
            Presentacion r = new Presentacion();
            ProcesoRENIEC dm = new ProcesoRENIEC();
            bool llave = false;
            do
            {
                switch (var = r.Logo1())
                {
                    case 1:
                        switch (opc = r.Direccion())
                        {
                            case 1:
                                dm.RegistrarInicio(ref lista);
                                break;
                            case 2:
                                Console.WriteLine(" Digite la posición en la que se integrará: ");
                                int pos = int.Parse(Console.ReadLine());
                                dm.RegistrarPosicion(ref lista, pos);
                                break;
                            case 3:
                                dm.registrarFinal(ref lista);
                                break;
                        }
                        break;
                    case 2:
                        switch (opc = r.Direccion())
                        {
                            case 1:
                                dm.EliminarInicio(ref lista);
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.Write("\t\t Digite el DNI del dato a borrar: ");
                                int marca = int.Parse(Console.ReadLine());
                                dm.EliminarPosicion(marca);
                                break;
                            case 3:
                                dm.EliminarFinal(ref lista);
                                break;
                        }
                        break;
                    case 3:
                        dm.VaciarLista(ref lista);
                        break;
                    case 4:
                        dm.OrdenarAscen(ref lista);
                        break;
                    case 5:
                        dm.OrdenarDescen(ref lista);
                        break;
                    case 6:
                        Console.WriteLine("\n");
                        Console.WriteLine("");
                        Console.WriteLine("\t\t Digite el DNI de la persona a buscar: ");
                        int dni = int.Parse(Console.ReadLine());
                        dm.BuscaPersona(lista, dni);
                        break;
                    case 7:
                        dm.MostrarLista(lista);
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        llave = false;
                        break;
                }
                Console.WriteLine("\n");
                Console.WriteLine("\t\t   [1] SI  [2] NO");
                Console.WriteLine("");
                Console.Write("\t\t  ¿DESEA VOLVER AL MENÚ PRINCIPAL? : ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    llave = false;
                    Console.Clear();
                }
                else
                {
                    llave = true;
                }

            } while (llave == false);
           
           
            Console.ReadKey();
     
        }
    }
}
