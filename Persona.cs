using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_T1
{
    class Persona
    {
        public int cod;
        public int dni;
        public string name;
        public string lstname;
        public string gender;
        public DateTime fchnaci;
        public string prov;
        public string stdciv;
        public Persona sgte;

        public int Cod { get { return cod; } set { cod = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Lstname { get { return lstname; } set { lstname = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public DateTime Fchnaci { get { return fchnaci; } set { fchnaci = value; } }
        public string Prov { get { return prov; } set { prov = value; } }
        public string Stdciv { get { return stdciv; } set { stdciv = value; } }
        public Persona Sgte { get { return sgte; } set { sgte = value; } }
        
    }
}
