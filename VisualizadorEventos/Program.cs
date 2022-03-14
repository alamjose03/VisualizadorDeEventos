using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArchivoEventos archivoEventos = new ArchivoEventos();
            LeerArchivo leerArchivoEventos = new LeerArchivo();

            Console.WriteLine("Elige una de las siguientes opciones: ");
            Console.WriteLine("1: Para crear un nuevo evento.");
            Console.WriteLine("2: Para ver los eventos creados.\n");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    archivoEventos.crearArchivo();
                    break;
                case 2:
                    leerArchivoEventos.leerArchivo();
                    break;

            }
        }
    }
}
