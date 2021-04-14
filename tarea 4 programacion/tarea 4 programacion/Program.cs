using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_4_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ////////Patron Decorador/////////////////
            
            Icomponentes micasa = new Casa("330 metros", "4 habitaciones", 3000000);

            Console.WriteLine(micasa);

            ((Casa)micasa).venta(true);

            Console.WriteLine("--------------------");

            micasa = new pisos(micasa);

            Console.WriteLine(micasa.costo());
            Console.WriteLine(micasa.funciona());
            Console.WriteLine(micasa);

            Console.WriteLine("--------------------");


            micasa = new Piscina(micasa);

            Console.WriteLine(micasa.costo());
            Console.WriteLine(micasa.funciona());
            Console.WriteLine(micasa);

            Console.WriteLine("--------------------");

            ////////Patron bridge///////

            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M101", 56.32);
            productos.Add("M234", 28.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            CAbstraccion bridge = new CAbstraccion(new Cimplementacion2(), productos);

            bridge.MostrarTotales();
            bridge.Listar();

            //////Patron Flyweight/////

            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carne = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flwf = new CFlyweightFactory();

            i = flwf.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carne.Add(i);
            Rapida.Add(i);

            i = flwf.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flwf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flwf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flwf.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carne.Add(i);
            Rapida.Add(i);

            i = flwf.Adiciona("Sancocho");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flwf.Adiciona("Ensalada Verde");
            Mexicana.Add(i);
            Rapida.Add(i);

            i = flwf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);


            foreach (int n in Rapida)
            {
                CRecetas receta = (CRecetas)flwf[n];
                receta.CalcularCosto();
                receta.Mostar();

            }

            Console.WriteLine("---------------");


            foreach (int n in Americana)
            {
                CRecetas receta = (CRecetas)flwf[n];
                receta.CalcularCosto();
                receta.Mostar();

            }

            Console.WriteLine("---------------");

            i = flwf.Adiciona("Pizza");

            Console.WriteLine("---------------");

            foreach (int n in Ensaladas)
            {
                CRecetas receta = (CRecetas)flwf[n];
                receta.CalcularCosto();
                receta.Mostar();

            }

            Console.WriteLine("---------------");


            int m = 0;

            for (m = 0; m < flwf.Conteo; m++)
            {
                CRecetas recetas = (CRecetas)flwf[m];
                recetas.Mostar();
            }





        }
    }
}
