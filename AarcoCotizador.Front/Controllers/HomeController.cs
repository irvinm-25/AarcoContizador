using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AarcoCotizador.Front.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            ViewBag.ListaMarcas = await new Negocio.AarcoCotizador_Neg().Obtener_Marcas();            
            return View();
        }
        public async Task<JsonResult> ObtenerSubmarcas(int Filtro)
        {
            var oResponse = await new Negocio.AarcoCotizador_Neg().Obtener_Submarcas(Filtro);
            return Json(oResponse);
        }
        public async Task<JsonResult> ObtenerModelos(int Filtro)
        {
            var oResponse = await new Negocio.AarcoCotizador_Neg().Obtener_Modelo(Filtro);
            return Json(oResponse);
        }
        public async Task<JsonResult> ObtenerDescripciones(int Filtro)
        {
            var oResponse = await new Negocio.AarcoCotizador_Neg().Obtener_DescripcionModelo(Filtro);
            return Json(oResponse);
        }
        public async Task<JsonResult> ObtenerDomicilio(int Filtro)
        {
            return Json(await new Negocio.AarcoCotizador_Neg().Obtener_Domicilio(Filtro));
        }
    }
}