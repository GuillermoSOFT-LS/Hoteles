using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class CamaController : Controller
    {
        // GET: Cama
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListaCamas()
        {
            List<CE_Cama> lista = new List<CE_Cama>();
            lista = new CN_Cama().GetCamas();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FiltrarCamas(string nombre)
        {
            List<CE_Cama> lista = new List<CE_Cama>();
            lista = new CN_Cama().GetCamaSearch(nombre);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}