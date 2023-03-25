using System;
namespace POO
{
    class Program
    {
        static void Main(String[] args)
        {
            //León oLeón = new León();
            //oLeón.Nombre = "Simba";
            //Console.WriteLine(oLeón.GetNombre());
            //oLeón.Correr();
            //Console.WriteLine(oLeón.Velocidad);
            //Paloma oPaloma = new Paloma();
            //oPaloma.Nombre = "Fazt";
            //oPaloma.Volar();

            Bar oBar = new Bar();
            Persona oMesero = new Mesero("El hijo de Moe");
            Persona oCantinero = new Cantinero("Moe");
            Persona oCliente = new Cliente("Martin");

            oBar.Entrar(oMesero);
            oBar.Entrar(oCliente);
            oBar.Entrar(oCantinero);


        }
    }

}
