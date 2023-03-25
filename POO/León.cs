using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class León : Carnivoro
    {
        public string? ColorCabello { get; set; }
        private int VelocidadDefecto = 50;
        public int Velocidad
        {
            get
            {
                return VelocidadDefecto;
            }
            set
            {
                VelocidadDefecto = value;
            }
        }
        public override string? GetNombre()
        {
            return $"Soy un leon llamado {Nombre}";
        }
        public León()
        {
            if (this.Nombre == null || this.Nombre.Equals(""))
            {
                this.Nombre = "Simba";
            }
        }
        public León(string Nombre, int Velocidad) : this()
        {
            this.Nombre = Nombre;
            this.VelocidadDefecto = Velocidad;
        }
        public void Correr()
        {
            Console.WriteLine($"Corriendo {VelocidadDefecto} por hora");
        }
        public void Correr(int Velocidad)
        {
            Console.WriteLine($"Corriendo a {Velocidad} por hora");
        }
    }
}
