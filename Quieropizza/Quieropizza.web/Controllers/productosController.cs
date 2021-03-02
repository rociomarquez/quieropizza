using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quieropizza.web.Controllers
{
    public class productosController : Controller
    {
        // GET: productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var Listadeproductos = productosBL.ObtenerProductos();
        


            return View(Listadeproductos);
        } 
    }  
}