using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListaHabitaciones()
        {
            List<CE_Habitacion> lista = new List<CE_Habitacion>();

            lista = new CN_Habitacion().GetListHabitacion();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FiltrarHabitaciones(string nombre)
        {
            List<CE_Habitacion> lista = new List<CE_Habitacion>();
            lista = new CN_Habitacion().Filtrarhabitaciones(nombre);

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}