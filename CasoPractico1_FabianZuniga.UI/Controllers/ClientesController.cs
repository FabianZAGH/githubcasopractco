using ManejoDeInventario.Abstracciones.Interfaces.Clientes.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Clientes;
using ManejoDeInventario.LogicaDeNegocio.Clientes.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManejoDeInventario.UI.Controllers
{
    public class ClientesController : Controller
    {

        IListarClientesLN _listarClientes;

        public ClientesController ()
        {
            _listarClientes = new ListarClientesLN();

		}
		// GET: Clientes
		public ActionResult Index()
        {
            List<ClientesDto> laListaDeClientes = _listarClientes.Listar();
			return View(laListaDeClientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details()
        {
            ClientesDto elCliente = new ClientesDto {
				Correo = "correo@gmail.com",
				Estado = true,
				FechaDeModificacion = DateTime.Now,
				FechaDeRegistro = DateTime.Now,
				Identificación = "00-0000-0000",
				Nombre = "Nombre",
				PrimerApellido = "Apellido",
				SegundoApellido = "Apellido",
				Telefono = "88888888"
			};
            return View(elCliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit()
        {
			ClientesDto elCliente = new ClientesDto
			{
				Correo = "correo@gmail.com",
				Estado = true,
				FechaDeModificacion = DateTime.Now,
				FechaDeRegistro = DateTime.Now,
				Identificación = "00-0000-0000",
				Nombre = "Nombre",
				PrimerApellido = "Apellido",
				SegundoApellido = "Apellido",
				Telefono = "88888888"
			};
			return View(elCliente);
		}

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
