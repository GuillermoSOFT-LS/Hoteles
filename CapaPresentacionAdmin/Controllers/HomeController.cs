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

        public ActionResult Usuarios()
        {
            return View();
        }

        public JsonResult ListarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();

            lista = new CN_Usuarios().GetLista();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}