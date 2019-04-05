using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;
using CRUDOperationUsinAngularjsinMVC.Data;
namespace CRUDOperationUsinAngularjsinMVC.Controllers
{
    public class EmpleadoController : Controller
    {
        private RHNOMEntities db = new RHNOMEntities();
      
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ObtenerEmpleado()
        {

            //List<Empleado> ListaDeEmpleados = new List<Empleado>();
            var ListaDeEmpleados = db.tb_msc_expediente
                   .Select(c => new { nom1 = c.nom1, nom2 = c.nom2, apellido1 = c.apellido1, apellido2 = c.apellido2, cedula = c.cedula,sexo=c.sexo, lugar_nacimiento = c.lugar_nacimiento, direccion = c.direccion })
                   .ToList(); db.tb_msc_expediente.ToList().ToList();
            return Json(ListaDeEmpleados, JsonRequestBehavior.AllowGet);
        }
    }
}