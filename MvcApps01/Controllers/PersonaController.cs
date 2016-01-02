using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcApps01.Models;

namespace MvcApps01.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new  List<Persona>();
            Persona per1 = new Persona();            
            per1.codigo = 1;
            per1.nombre = "Guillermo";
            per1.apapat = "Rodriguez";
            per1.apamat = "Pineda";
            lista.Add(per1);

            Persona per2 = new Persona();
            per2.codigo = 2;
            per2.nombre = "Jackeline";
            per2.apapat = "Atme";
            per2.apamat = "Mendoza";
            lista.Add(per2);

            Persona per3 = new Persona();
            per3.codigo = 2;
            per3.nombre = "Mayra";
            per3.apapat = "Lurquin";
            per3.apamat = "Nuñez";
            lista.Add(per3);

            return View(lista);
        }
    }
}