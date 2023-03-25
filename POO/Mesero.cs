using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Mesero : Persona
    {
        public Mesero(String Nombre) : base(Nombre)
        {
        }
        public override void Action()
        {
            Console.WriteLine("Que le sirvo?");
        }
    }
}
