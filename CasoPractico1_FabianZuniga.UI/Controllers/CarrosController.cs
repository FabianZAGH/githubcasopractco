using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Crear;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Eliminar;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Listar;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.ObtenerPorId;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.LogicaDeNegocio.Inventario.Actualizar;
using ManejoDeInventario.LogicaDeNegocio.Inventario.Crear;
using ManejoDeInventario.LogicaDeNegocio.Inventario.Eliminar;
using ManejoDeInventario.LogicaDeNegocio.Inventario.Listar;
using ManejoDeInventario.LogicaDeNegocio.Inventario.ObtenerPorId;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ManejoDeInventario.UI.Controllers
{
	public class CarrosController : Controller
    {
        IListarRepuestosLN _listarRepuestosLN;
        ICrearRepuestoLN _crearRepuestoLN;
        IObtenerPorIdLN _obtenerRepuestoPorIdLN;
        IActualizarInventarioLN _actualizarInventarioLN;
        IEliminarInventarioLN _eliminarInventarioLN;
		public CarrosController ()
        {
            _listarRepuestosLN = new ListarCarrosLN();
            _crearRepuestoLN = new CrearCarrosLN();
			_obtenerRepuestoPorIdLN = new ObtenerPorIdLN();
			_actualizarInventarioLN = new ActualizarCarrosLN();
            _eliminarInventarioLN = new EliminarCarrosLN();

		}
		// GET: Inventario
		public ActionResult Index()
        {
            ViewBag.Title = "LaListaDeInventario";
            List<CarrosDTO> laListaDeRepuestos = _listarRepuestosLN.Listar();
			return View(laListaDeRepuestos);
        }

        // GET: Inventario/Details/5
        public ActionResult Details(int Id)
        {
            CarrosDTO elRepuesto = _obtenerRepuestoPorIdLN.Obtener(Id);
            return View(elRepuesto);
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public async Task<ActionResult> Create(CarrosDTO repuesto)
        {
            try
            {
				// TODO: Add insert logic here
				repuesto.Path = Server.MapPath("~/Archivos/");
				repuesto.NombreDeArchivo = Path.GetFileName(repuesto.Archivo.FileName);
				await _crearRepuestoLN.Guardar(repuesto);
				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            CarrosDTO elRepuesto = _obtenerRepuestoPorIdLN.Obtener(id);
			return View(elRepuesto);
		}

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult Edit(CarrosDTO elRepuesto)
        {
            try
            {
                // TODO: Add update logic here
                int cantidadDeRepuestosActualizados = _actualizarInventarioLN.Actualizar(elRepuesto);
				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.CantidadDeRepuestosActualizados = 1;
			CarrosDTO elRepuesto = _obtenerRepuestoPorIdLN.Obtener(id);
			return View(elRepuesto);
		}

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult Delete(CarrosDTO elRepuesto)
        {
            try
            {
                // TODO: Add delete logic here
                int cantidadDeElementosEliminados = _eliminarInventarioLN.Eliminar(elRepuesto.Id);
                if(cantidadDeElementosEliminados == 0)
                {
					CarrosDTO elRepuestoConsultado = _obtenerRepuestoPorIdLN.Obtener(elRepuesto.Id);
					ViewBag.CantidadDeRepuestosActualizados = cantidadDeElementosEliminados;
					return View(elRepuestoConsultado);
				}
				return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult VistaParcial()
        {

            return PartialView();
        }

        [Route("ObtenerListaDeRepuestos")]
        public JsonResult ObtenerListaDeRepuestos()
		{
			List<CarrosDTO> laListaDeRepuestos = _listarRepuestosLN.Listar();
            return Json(laListaDeRepuestos);
		}
    }
}
