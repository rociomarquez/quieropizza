using Quieropizza.web.Models;
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
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamon y queso";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        } 
    }  
}