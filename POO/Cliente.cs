using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cliente : Persona
    {
        public Cliente(String Nombre) : base(Nombre)
        {

        }
        public override void Action()
        {
            Console.WriteLine("Buenas, que tienen para tomar?");
        }
    }
}
