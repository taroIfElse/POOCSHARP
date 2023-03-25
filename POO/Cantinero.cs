using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cantinero : Persona
    {
        public Cantinero(String Nombre) : base(Nombre) { }
        public override void Action()
        {
            Console.WriteLine("Tenemos GinTonic");   
        }
    }
}
