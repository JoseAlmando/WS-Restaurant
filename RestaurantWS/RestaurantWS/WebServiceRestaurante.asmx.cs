using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantWS
{
    /// <summary>
    /// Descripción breve de WebServiceRestaurante
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceRestaurante : System.Web.Services.WebService
    {
        [WebMethod]
        public List<restaurant> getAllRestaurant()
        {
            using (RestauranteEntities1 db = new RestauranteEntities1())
            {
                var list = db.restaurant.ToList();
                return list;
            }
        }

        [WebMethod] 
        public restaurant getRestaurant(int id)
        {
            using (RestauranteEntities1 db = new RestauranteEntities1())
            {
                var list = db.restaurant.Where(x => x.ID == id).FirstOrDefault();
                return list;
            }
        }

        [WebMethod]
        public string deleteRestaurant(int id)
        {
            using (RestauranteEntities1 db = new RestauranteEntities1())
            {
                var reliminar = db.restaurant.Find(id);
                db.restaurant.Remove(reliminar);
                db.SaveChanges();
                return "Eliminado con exito";
            }
        }


        [WebMethod]
        public string postRestaurant(string Nombre, string Direccion, string RNC, 
            string Telefono, string PersonaACargo, int CantidadEmpleados, string TipoComida, 
            double VentasMensuales)
        {
            using (RestauranteEntities1 db = new RestauranteEntities1())
            {
                var restaurante = new restaurant();
                restaurante.Nombre = Nombre;
                restaurante.Direccion = Direccion;
                restaurante.RNC = RNC;
                restaurante.Telefono = Telefono;
                restaurante.PersonaACargo = PersonaACargo;
                restaurante.CantidadEmpleados = CantidadEmpleados;
                restaurante.FechaCreacion = DateTime.Now.Date;
                restaurante.FechaModificacion = DateTime.Now.Date;
                restaurante.TipoComida = TipoComida;
                restaurante.VentasMensuales = VentasMensuales;
                restaurante.GuidReg = Guid.NewGuid().ToString();

                db.restaurant.Add(restaurante);
                db.SaveChanges();

                return "Creado con exito";
            }
        }

        [WebMethod]
        public string putRestaurant(int id, string Nombre, string Direccion, string RNC,
            string Telefono, string PersonaACargo, int CantidadEmpleados, string TipoComida,
            double VentasMensuales)
        {
            using (RestauranteEntities1 db = new RestauranteEntities1())
            {
                var restaurante = db.restaurant.Find(id);
                restaurante.Nombre = Nombre;
                restaurante.Direccion = Direccion;
                restaurante.RNC = RNC;
                restaurante.Telefono = Telefono;
                restaurante.PersonaACargo = PersonaACargo;
                restaurante.CantidadEmpleados = CantidadEmpleados;
                restaurante.FechaModificacion = DateTime.Now.Date;
                restaurante.TipoComida = TipoComida;
                restaurante.VentasMensuales = VentasMensuales;

                db.Entry(restaurante).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return "Actualizado con exito";
            }
        }

    }

}