using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Bar
    {
        List<Persona> listPersonas = new List<Persona>();
        public void Entrar(Persona oPersona)
        {
            listPersonas.Add(oPersona);
            oPersona.Action();
        }
    }
}
