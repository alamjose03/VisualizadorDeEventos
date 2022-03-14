using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventos
{
    internal class LeerArchivo
    {
        public void leerArchivo()
        {
            StreamReader leerArchivo = new StreamReader("eventos.txt");
            CrearListaEventos crearListaEventos = new CrearListaEventos();
            crearListaEventos.crearListaEventos(leerArchivo);
            leerArchivo.Close();
        }

    }
}
