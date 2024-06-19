using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    internal class AvisoTransito: IAviso
    {
        private string fecha;
        private string remitente;
        private string mensaje;

        public AvisoTransito()
        {
            remitente = "DIGESETT";
            mensaje = "Sanción cometida. Pague antes de 3 días y se le hara una reducción al pago de un 50%.";
            fecha = "18/06/2024";
        }
        public AvisoTransito(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public void MostrarAviso()
        {
            Console.WriteLine("Remitente: {0} \nMensaje: \n{1} \nFecha: {2}", remitente, mensaje, fecha);
        }
        public string Fecha()
        {
            return fecha;
        }

    }
}
