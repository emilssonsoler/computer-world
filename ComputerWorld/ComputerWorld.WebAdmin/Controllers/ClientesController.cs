﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComputerWorld.BL;

namespace ComputerWorld.WebAdmin.Controllers
{
    public class ClientesController : Controller
    {
       
        ClientesBL _clientesBL;

        public ClientesController()
        {
            _clientesBL = new ClientesBL();
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var listadeClientes = _clientesBL.ObtenerClientes();

            return View(listadeClientes);
        }

        // Get crear
        public ActionResult Crear()
        {
            var nuevoCliente = new Cliente();

            return View(nuevoCliente);
        }

        [HttpPost]
        public ActionResult Crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }


        // Get editar
        public ActionResult Editar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // Get detalle
        public ActionResult Detalle(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }


        // Get eliminar
        public ActionResult Eliminar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Eliminar(Cliente cliente)
        {
            _clientesBL.EliminarCliente(cliente.Id);

            return RedirectToAction("Index");
        }
    }
}