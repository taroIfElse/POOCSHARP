using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Paloma : Carnivoro
    {
        public int CantidadDePlumas { get; set; } 
        public void Volar()
        {
            Console.WriteLine("Volando");
        }
    }
}
