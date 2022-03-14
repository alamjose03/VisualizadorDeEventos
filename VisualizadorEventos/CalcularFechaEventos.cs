using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizadorEventos
{
    internal class CalcularFechaEventos
    {
        public void calcularFechaEventos(List<string> nombresEventos, List<DateTime> fechasEventos)
        {
            //Console.WriteLine("desde calcular: {0}", fechasEventos.Count());
            DateTime fechaActual = DateTime.Now;

            for (int i = 0; i < fechasEventos.Count(); i++)
            {
                TimeSpan dates;

                if (fechasEventos[i] < fechaActual)
                {
                    dates = fechaActual - fechasEventos[i];
                    dates.ToString(@"dd\d\ hh\h\ mm\m\ ");
                    Console.WriteLine("{0} ocurrió hace {1}", nombresEventos[i], determinarTiempo(dates));
                }
                else
                {
                    dates = fechasEventos[i] - fechaActual;
                    dates.ToString(@"dd\d\ hh\h\ mm\m\ ");
                    Console.WriteLine("{0} ocurrirá en {1}", nombresEventos[i], determinarTiempo(dates));
                }
            }
        }

        private string determinarTiempo(TimeSpan fecha)
        {
            if (fecha.TotalDays > 30)
            {
                double mesesDouble = fecha.TotalDays / 30;
                int meses = (int)mesesDouble;
                return meses + " Meses";
            }
            else if (fecha.TotalHours >= 24 && fecha.TotalDays < 30)
            {
                return fecha.Days + " Dias";
            }
            else if (fecha.TotalMinutes > 60 && fecha.TotalHours < 24)
            {
                return fecha.Hours + " Horas";
            }
            else if (fecha.TotalMinutes < 60)
            {
                return fecha.TotalMinutes + " Minutos";
            }
            return "";
        }
    }
}
