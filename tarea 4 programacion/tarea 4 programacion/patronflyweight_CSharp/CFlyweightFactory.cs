using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class CFlyweightFactory
    {
        private List<Iflyweight> flyweight = new List<Iflyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {

            bool existe = false;
            foreach (Iflyweight f in flyweight)
            {
                if (f.ObtenerNombre() == pNombre)
                    existe = true;


            }
            if (existe)
            {

                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CRecetas Mireceta = new CRecetas();
                Mireceta.ColocarNombre(pNombre);
                flyweight.Add(Mireceta);
                conteo = flyweight.Count;
                return conteo - 1;
            }


        }

        public Iflyweight this[int index]
        {
            get { return flyweight[index]; }

        }



    }
}
