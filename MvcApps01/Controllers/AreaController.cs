using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcApps01.Models;

namespace MvcApps01.Controllers
{
    public class AreaController : Controller
    {
        // GET: Area
        public AreaModel model = new AreaModel();
        public ActionResult Index()
        {
            return View(model.ListaAreas());
        }
        public ActionResult Details(int id)
        {
            var area = model.BuscarArea(id);
            return View(area);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(area a)
        {
            try
            {
                if (model.InsertarArea(a).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch (Exception)
            {
                
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var area = model.BuscarArea(id);
            return View(area);
        }
        [HttpPost]
        public ActionResult Edit(int id, area a)
        {
            try
            {
                area area = new area();
                area.are_cod = id;
                area.are_des = a.are_des;
                if (model.ActualizarArea(area).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            catch (Exception)
            {

                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var area = model.BuscarArea(id);
            return View(area);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (model.EliminarArea(id).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else {
                    return RedirectToAction("Delete");
                }
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}