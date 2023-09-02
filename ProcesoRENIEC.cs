using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T1
{
    internal class ProcesoRENIEC
    {
        public Persona lista;
        public ProcesoRENIEC()
        {
            lista = null;
        }
        //Métodos para el registro de personas
        public void RegistrarInicio(ref Persona nodo)
        {
            Random codi = new Random();
            int rgs, i;

            Console.WriteLine("\n");
            Console.Write("\t\t   Ingrese la cantidad de Registros ha realizar : ");
            rgs = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t ------------------------------------------------------");
            for (i = 0; i < rgs; i++)
            {
                Persona q = new Persona();
                q.cod = codi.Next(9999999,99999999);
                Console.WriteLine("\n");
                Console.WriteLine("\t\t   PERSONA #{0}",i+1);
                Console.WriteLine("");
                Console.Write("\t\t Ingrese N° DNI (8 números)   :");
                q.dni = int.Parse(Console.ReadLine());
                Console.Write("\t\t Ingrese Nombre               :");
                q.name = Console.ReadLine();
                Console.Write("\t\t Ingrese Apellido             :");
                q.lstname = Console.ReadLine();
                Console.Write("\t\t Ingrese Género               :");
                q.gender = Console.ReadLine();
                Console.Write("\t\t Ingrese Fecha de Nacimiento  :");
                q.fchnaci = DateTime.Parse(Console.ReadLine());
                Console.Write("\t\t Ingrese Provincia            :");
                q.prov = Console.ReadLine();
                Console.Write("\t\t Ingrese Estado civil         :");
                q.stdciv = Console.ReadLine();

                if (nodo == null)
                {
                    nodo = q;
                }
                else
                {
                    q.sgte = nodo;
                    nodo = q;
                }
            }
        }
        public void RegistrarPosicion(ref Persona nodo, int pos)
        {
            Random codi = new Random();
            Persona q, t;
            int i;
            q = new Persona();

            q.cod = codi.Next(9999999, 99999999);
            Console.WriteLine("\n");
            Console.WriteLine("");
            Console.Write("\t\t Ingrese N° DNI               :");
            q.dni = int.Parse(Console.ReadLine());
            Console.Write("\t\t Ingrese Nombre               :");
            q.name = Console.ReadLine();
            Console.Write("\t\t Ingrese Apellido             :");
            q.lstname = Console.ReadLine();
            Console.Write("\t\t Ingrese Género               :");
            q.gender = Console.ReadLine();
            Console.Write("\t\t Ingrese Fecha de Nacimiento  :");
            q.fchnaci = DateTime.Parse(Console.ReadLine());
            Console.Write("\t\t Ingrese Provincia            :");
            q.prov = Console.ReadLine();
            Console.Write("\t\t Ingrese Estado civil         :");
            q.stdciv = Console.ReadLine();
            t = new Persona();

            if (pos == 1)
            {
                q.sgte = nodo;
                nodo = q;
            }
            else
            {
                t = nodo;
                for (i = 1; t != null; i++)
                {
                    if (i == pos - 1)
                    {
                        q.Sgte = t.Sgte;
                        t.Sgte = q;
                        return;
                    }
                    t = t.Sgte;
                }
            }
            if (t == null)
                Console.WriteLine("\t\t Error... Posicion equivocada");
        }
        public void registrarFinal(ref Persona nodo)
        {
            Random codi = new Random();
            int rgs, i;

            Console.WriteLine("\n");
            Console.Write("\t\t   Ingrese la cantidad de Registros ha realizar : ");
            rgs = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t ------------------------------------------------------");

            for (i = 0; i < rgs; i++)
            {
                Persona q = new Persona();
                Persona t;

                q.cod = codi.Next(9999999, 99999999);
                Console.WriteLine("\n");
                Console.WriteLine("\t\t   PERSONA #{0}", i + 1);
                Console.WriteLine("");
                Console.Write("\t\t Ingrese N° DNI               :");
                q.dni = int.Parse(Console.ReadLine());
                Console.Write("\t\t Ingrese Nombre               :");
                q.name = Console.ReadLine();
                Console.Write("\t\t Ingrese Apellido             :");
                q.lstname = Console.ReadLine();
                Console.Write("\t\t Ingrese Género               :");
                q.gender = Console.ReadLine();
                Console.Write("\t\t Ingrese Fecha de Nacimiento  :");
                q.fchnaci = DateTime.Parse(Console.ReadLine());
                Console.Write("\t\t Ingrese Provincia            :");
                q.prov = Console.ReadLine();
                Console.Write("\t\t Ingrese Estado civil         :");
                q.stdciv = Console.ReadLine();

                if (nodo == null)
                {
                    nodo = q;
                }
                else
                {
                    t = nodo;
                    while (t.Sgte != null)
                    {
                        t = t.Sgte;
                    }
                    t.Sgte = q;
                }
            }
        }

        //Métodos para eliminar los datos de una persona
        public void EliminarInicio(ref Persona nodo)
        {
            if (nodo != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t   PERSONA A ELIMINAR");
                Console.WriteLine("\t\t ----------------------------");
                Console.WriteLine("");
                Console.WriteLine("\t N° DNI              : {0}", nodo.dni);
                Console.WriteLine("\t Nombre              : {0}", nodo.name);
                Console.WriteLine("\t Apellido            : {0}", nodo.lstname);
                Console.WriteLine("\t Género              : {0}", nodo.gender);
                Console.WriteLine("\t Fecha de Nacimiento : {0}", nodo.fchnaci);
                Console.WriteLine("\t Provincia           : {0}", nodo.prov);
                Console.WriteLine("\t Estado civil        : {0}", nodo.stdciv);
                Console.WriteLine("");

                Console.Write("\n\t\t ¿Desea eliminar esta persona? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    Persona q = nodo;
                    nodo = nodo.sgte;
                    q = null;
                    Console.WriteLine("\n\t\t Persona eliminada correctamente.");
                }
            }
            else
            {
                Console.WriteLine(" \t\t Lista esta vacia ");
            }
        }
        public void EliminarPosicion(int dato)
        {
            Persona q = lista;
            Persona ant = null;
            while (q != null)
            {
                if (q.dni == dato)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t\t   PERSONA A ELIMINAR");
                    Console.WriteLine("\t\t ----------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("\t\t N° DNI              : {0}", q.dni);
                    Console.WriteLine("\t\t Nombre              : {0}", q.name);
                    Console.WriteLine("\t\t Apellido            : {0}", q.lstname);
                    Console.WriteLine("\t\t Género              : {0}", q.gender);
                    Console.WriteLine("\t\t Fecha de Nacimiento : {0}", q.fchnaci);
                    Console.WriteLine("\t\t Provincia           : {0}", q.prov);
                    Console.WriteLine("\t\t Estado civil        : {0}", q.stdciv);
                    Console.WriteLine("");

                    Console.Write("\n\t\t ¿Desea eliminar esta persona? (s/n): ");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "s")
                    {
                        if (ant == null)
                        {
                            lista = q.sgte;
                        }
                        else
                        {
                            ant.sgte = q.sgte;
                        }
                        q = null;
                        Console.WriteLine("\n\t\t Persona eliminada correctamente.");
                        return;
                    }
                }
                ant = q;
                q = q.sgte;
            }
            Console.WriteLine("\n\t\t El DNI ingresado no se encuentra en la lista.");

        }
        public void EliminarFinal(ref Persona nodo)
        {
            if(nodo != null)
            {
                Persona q = nodo;
                Persona ant = null;
                while (q.sgte != null)
                {
                    ant = q;
                    q = q.sgte;
                }

                Console.WriteLine("\n");
                Console.WriteLine("\t\t   PERSONA A ELIMINAR");
                Console.WriteLine("\t\t ----------------------------");
                Console.WriteLine("");
                Console.WriteLine("\t N° DNI              : {0}", q.dni);
                Console.WriteLine("\t Nombre              : {0}", q.name);
                Console.WriteLine("\t Apellido            : {0}", q.lstname);
                Console.WriteLine("\t Género              : {0}", q.gender);
                Console.WriteLine("\t Fecha de Nacimiento : {0}", q.fchnaci);
                Console.WriteLine("\t Provincia           : {0}", q.prov);
                Console.WriteLine("\t Estado civil        : {0}", q.stdciv);

                Console.Write("\n\t\t ¿Desea eliminar esta persona? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    if (ant == null)
                    {
                        nodo = null;
                    }
                    else
                    {
                        ant.sgte = null;
                    }
                    q = null;
                    Console.WriteLine("\n\t\t Persona eliminada correctamente.");
                }
            }
            else
            {
                Console.WriteLine(" Lista esta vacia ");
            }
        }

        //Método para vaciar el código por completo
        public void VaciarLista(ref Persona nodo)
        {
            nodo = null;
        }

        //Método para Ordenar de manera ascendente
        public void OrdenarAscen(ref Persona nodo)
        {
            if (nodo == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  Lista esta Vacia...!");
                return;
            }
            else if(nodo.sgte == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  La lista solo tiene un único elemento ");
                return;
            }
            bool cambio;
            do
            {
                cambio = false;
                Persona actual = nodo;
                Persona anterior = null;
                while (actual != null && actual.sgte != null)
                {
                    if (actual.dni > actual.sgte.dni)
                    {
                        if (anterior == null)
                        {
                            Persona temp = actual.sgte;
                            actual.sgte = temp.sgte;
                            temp.sgte = actual;
                            nodo = temp;
                        }
                        else
                        {
                            Persona temp = actual.sgte;
                            anterior.sgte = temp;
                            actual.sgte = temp.sgte;
                            temp.sgte = actual;
                        }
                        cambio = true;
                    }
                    anterior = actual;
                    actual = actual.sgte;
                }
            } while (cambio);
        }

        //Método para Ordenar de manera descendente
        public void OrdenarDescen(ref Persona nodo)
        {
            if (nodo == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  Lista esta Vacia...!");
                return;
            }
            else if (nodo.sgte == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  La lista solo tiene un único elemento ");
                return;
            }
            bool cambio;
            do
            {
                cambio = false;
                Persona actual = nodo;
                Persona anterior = null;
                while (actual != null && actual.sgte != null)
                {
                    if (actual.dni < actual.sgte.dni)
                    {
                        if (anterior == null)
                        {
                            Persona temp = actual.sgte;
                            actual.sgte = temp.sgte;
                            temp.sgte = actual;
                            nodo = temp;
                        }
                        else
                        {
                            Persona temp = actual.sgte;
                            anterior.sgte = temp;
                            actual.sgte = temp.sgte;
                            temp.sgte = actual;
                        }
                        cambio = true;
                    }
                    anterior = actual;
                    actual = actual.sgte;
                }
            } while (cambio);
        }

        //Método para Buscar persona mediante DNI
        public void BuscaPersona(Persona nodo, int valor)
        {
            int i = 0;
            Persona q;
            q = new Persona();
            q = nodo;
            while ((q != null) && (q.dni != valor))
            {
                i++;
                q = q.sgte;
            }
            if (q == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  El elemento no se encuentra en la bsae de datos");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t El elemento si se encuentra en la bsae de datos");
                Console.WriteLine("\t\t Su pocisión es: {0}", i);
            }


        }

        //Metodo para mostrar lista
        public void MostrarLista(Persona nodo)
        {
            Console.WriteLine("\t----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t  *~ REGISTRO NACIONAL DE IDENTIFICACIÓN Y ESTADO CIVIL ~* ");
            Console.WriteLine("\t----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.Write("\t   N° Tramite" + "\t DNI".PadRight(8,' ') + "\t Nombre" + "\t Apellido" + "\tGénero" + "\t Nacimiento" + "\t Provincia" + "\t Estado Civil");
            Console.WriteLine("");
            Console.WriteLine("\t----------------------------------------------------------------------------------------------------------------");
            if (nodo == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  Lista esta Vacia...!");
                return;
            }

            Persona actual = nodo;
            while (actual != null)
            {
                string fechaSinHora = actual.fchnaci.ToShortDateString();

                Console.WriteLine("");
                Console.Write("\t {0}", actual.cod.ToString().PadLeft(11, ' '));
                Console.Write("\t {0,-8}", actual.dni.ToString().PadLeft(8, ' '));
                Console.Write("\t {0}", actual.name.ToString().PadLeft(11, ' '));
                Console.Write("\t {0}", actual.lstname.ToString().PadLeft(11, ' '));
                Console.Write("\t {0}", actual.gender.ToString().PadLeft(11, ' '));
                Console.Write("\t {0}", fechaSinHora.ToString().PadLeft(11, ' '));
                Console.Write("\t {0}", actual.prov.ToString().PadLeft(11, ' '));
                Console.Write("\t {0}", actual.stdciv.ToString().PadLeft(11, ' '));
                Console.WriteLine();
                actual = actual.Sgte;
            }
        }
        public void MostraLista(Persona nodo)
        {
            Console.WriteLine("\t---------------------------------------------------------------");
            Console.WriteLine("\t\t\t*~ REGISTRO NACIONAL DE IDENTIFICACIÓN ~* ");
            Console.WriteLine("\t---------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine(" N° Trámite |   DNI   |    Nombre    |  Apellido  | Género | Fecha de Nacimiento |  Provincia  | Estado Civil");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            if (nodo == null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t  ¡La lista está vacía...!");
                return;
            }

            Persona actual = nodo;
            while (actual != null)
            {
                Console.WriteLine("{0,-12} | {1,-8} | {2,-12} | {3,-10} | {4,-6} | {5,-19} | {6,-12} | {7,-12}",
                    actual.dni, actual.name, actual.lstname, actual.gender, actual.fchnaci.Date.ToShortDateString(),
                    actual.prov, actual.stdciv);
                actual = actual.Sgte;
            }
        }

    }


}
