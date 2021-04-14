using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class Casa:Icomponentes
    {
        private string metros;
        private string habitaciones;
        public double Costo;

        public Casa(string pMetros, string pHabitaciones, double pCosto)
        {
            metros = pMetros;
            habitaciones = pHabitaciones;
            Costo = pCosto;

        }

        public void venta(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Casa vendida");

            //else (pEstado) 
            //       Console.WriteLine("Casa en venta");



        }

        public override string ToString()
        {
            return string.Format("metro {0}, {1} /r/n", metros, habitaciones);
        }
        public double costo()
        {
            return Costo;
        }
        public string funciona()
        {
            return "Vendi la casa";
        }

    }
}
