using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWS
{
    public class RestaMod
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string RNC { get; set; }
        public string Telefono { get; set; }
        public string PersonaACargo { get; set; }
        public int CantidadEmpleados { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string TipoComida { get; set; }
        public double VentasMensuales { get; set; }
        public string GuidReg { get; set; }
    }
}