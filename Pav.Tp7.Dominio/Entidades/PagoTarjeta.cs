using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.Entidades
{
    class PagoTarjeta : Pago
    {
        public DateTime FechaAprovacion { get; set; }

        public string DNISolicitante { get; set; }

        public Tarjeta TarjetaPrestador { get; set; }

        public string NumeroTarjeta { get; set; }

        public Mes MesVencimiento { get; set; }

        public string AnioVencimiento { get; set; }
    }

    public enum Mes
    {
        ENERO,
        FEBRERO,
        MARZO,
        ABRIL,
        MAYO,
        JUNIO,
        JULIO,
        AGOSTO,
        SEPTIEMBRE,
        OCTUBRE,
        NOVIEMBRE,
        DICIEMBRE
    }

    public enum Tarjeta
    {
        MASTERCARD,
        VISA,
        AMERICANEXPRESS,
        NARANJA,
        NATIVA,
        OTRA
    }
}
