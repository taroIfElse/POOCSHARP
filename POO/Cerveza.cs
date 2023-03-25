using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cerveza
    {
        public int Amargor { get; set; }
        public decimal Alcohol { get; set; }
        public int TiempoFermentación { get; set; }
        public Cerveza(int Amargor, decimal Alcohol, int TiempoFermentación)
        {
            this.Amargor = Amargor;
            this.Alcohol = Alcohol;
            this.TiempoFermentación = TiempoFermentación;
        }

        public void Fermentar()
        {
            for (int i = 0; i < TiempoFermentación; i++)
            {
                Console.WriteLine("Fermentando");
            }
            Console.WriteLine("Se Fermentó");
        }

    }
}
