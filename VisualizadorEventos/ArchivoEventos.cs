using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventos
{
    internal class ArchivoEventos
    {
        public void crearArchivo()
        {
            StreamWriter archivo = new StreamWriter("eventos.txt", true);
            ingresarEventos(archivo);
        }

        private void ingresarEventos(StreamWriter archivo)
        {
            Console.WriteLine("Ingrese el evento junto con la fecha que desee agregar al archivo: ");
            string evento = Console.ReadLine();
            int caracteres = evento.Count();

            if (caracteres <= 50)
            {
                archivo.WriteLine(evento);
                archivo.Close();
            }
            else
            {
                Console.WriteLine("Lo siento, su evento no puede tener más de 50 caracteres");
            }
            //archivo = Regex.Replace(archivo AS, "\n$", "");
        }
    }
}
