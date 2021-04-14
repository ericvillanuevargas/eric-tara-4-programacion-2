using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class Piscina:Icomponentes
    {
        private Icomponentes decoradorA;

        public Piscina(Icomponentes pComponentes)
        {
            decoradorA = pComponentes;

        }


        public override string ToString()
        {
            return "Piscina de 20 metros\r\n" + decoradorA.ToString();
        }


        public double costo()
        {
            return decoradorA.costo() + 50000;


        }

        public string funciona()
        {
            return decoradorA.funciona() + ", piscina construida";

        }



    }
}
