using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventos
{
    public class CrearListaEventos
    {
        public void crearListaEventos(StreamReader leerArchivo)
        {
            string[] generalEventos = { };
            List<String> nombreEventos = new List<String>();
            List<DateTime> fechaEventos = new List<DateTime>();

            CalcularFechaEventos calcularFechaEventos = new CalcularFechaEventos();
            List<String> lista = new List<String>();
            while (!leerArchivo.EndOfStream)
            {
                string line = leerArchivo.ReadLine();
                generalEventos = line.Split(',');

                for (int i = 0; i < generalEventos.Length; i++)
                {
                    DateTime dateTime = Convert.ToDateTime(generalEventos[1]);
                    dateTime.ToString("dd/mm/yyyy HH:mm");
                    switch (i)
                    {
                        case 0:
                            nombreEventos.Add(generalEventos[i]);
                            break;
                        case 1:
                            fechaEventos.Add(dateTime);
                            break;


                    }
                }
            }
            // hacer que retorne la lista con los tiempos y almacenarlo en algun lugar para imprimirlo
            calcularFechaEventos.calcularFechaEventos(nombreEventos, fechaEventos);
        }
    }
}
