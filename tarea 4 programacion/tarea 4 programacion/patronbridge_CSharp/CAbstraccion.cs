using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_4_programacion
{
    class CAbstraccion
    {
        Ibridge implementacion;
        Dictionary<string, double> productos;

        public CAbstraccion(Ibridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;
        }

        public CAbstraccion(int pTipo, Dictionary<string, double> pProd)
        {
            if (pTipo == 1)
                implementacion = new Cimplementacion1();
            if (pTipo == 2)
                implementacion = new Cimplementacion2();

            productos = pProd;



        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }

        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }

    }
}
