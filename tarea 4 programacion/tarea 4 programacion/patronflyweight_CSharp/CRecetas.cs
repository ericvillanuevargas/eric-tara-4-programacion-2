using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class CRecetas:Iflyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        public void ColocarNombre(string pNombre)
        {
            nombre = pNombre;


        }

        public void CalcularCosto()
        {
            foreach (char letra in nombre)
                costo += (int)letra;

            venta = costo * 1.30;

        }

        public void Mostar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        public string ObtenerNombre()
        {
            return nombre;
        }


    }
}
