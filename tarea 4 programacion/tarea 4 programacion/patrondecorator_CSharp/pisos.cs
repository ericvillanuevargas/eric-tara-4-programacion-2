using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class pisos:Icomponentes
    {
        private Icomponentes decorardorA;

        public pisos(Icomponentes pComponente)
        {
            decorardorA = pComponente;


        }

        public override string ToString()
        {
            return "Piso de ceramica \r\n" + decorardorA.ToString();
        }


        public double costo()
        {

            return decorardorA.costo() + 20000;
        }


        public string funciona()
        {
            return decorardorA.funciona() + "Piso puesto";

        }

        public void UsaP()
        {
            Console.WriteLine("Piso agregado");

        }

    }
}
