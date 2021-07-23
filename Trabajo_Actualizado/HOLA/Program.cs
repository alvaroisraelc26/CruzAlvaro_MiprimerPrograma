using System;

namespace MisPrimerosPasos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais ="Ecuador";
            Pais  = new Pais();

            Pais pais1;
            var pais2;

            var pais = new Pais();
            pais.Nombre = "Ecuador";
            pais.Provincia = new List<string>();
            pais.Provincia.Add("Pichincha");
            pais.Provincia.Add("Galapagos");
            pais.Provincia.Add("Loja");

        }
    }   
}