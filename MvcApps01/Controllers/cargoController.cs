using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApps01.Models;

namespace MvcApps01.Controllers
{
    public class cargoController : Controller
    {
        bd_escuelaEntities entidad = new bd_escuelaEntities();
        // GET: cargo
        public ActionResult Index()
        {
            var listacarga = entidad.cargo;
            return View(listacarga.ToList());
        }

        public ActionResult ListaMaestroCargos()
        {
            var listacarga = entidad.cargo;
            return View(listacarga.ToList());

        }

        public ActionResult UsuarioxCargo(string cargo)
        {
            // Uso de Linq
            var modelo = from p in entidad.usuario
                         where p.cargo.cas_des == cargo
                         select p;
            return View(modelo.ToList());
        }
        public ActionResult ListadoUsuariosconDescripcionCargo()
        {
            var modelo = from p in entidad.usuario
                         join c in entidad.cargo

                         on p.car_cod equals c.car_cod
                         select new ElUsuario
                         {
                             codigo = p.usu_cod,
                             nombre = p.usu_nom,
                             cargo = c.cas_des
                         };
            return View(modelo.ToList());
        }
    }
}