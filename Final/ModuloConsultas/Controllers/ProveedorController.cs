using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloConsultas.Connection;
using ModuloConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloConsultas.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly ILogger<ProveedorController> _logger;
        private readonly Conn _context;

        public ProveedorController(Conn context)
        {
            _context = context;
        }
        public IActionResult Proveedores()
        {
            return View();
        }
        public async Task<IActionResult> IndexP()
        {
            return View(await _context.Proveedores.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Proveedores([Bind("CodigoProveedor, NombreProveedor, Nit, Dirección")] ProveedorModel proveedormodel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proveedormodel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexP));
            }
            return View(proveedormodel);
        }
        [HttpGet]
        public async Task<IActionResult> ConsultaProveedor(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Datos = await _context.Proveedores
                .FirstOrDefaultAsync(a => a.CodigoProveedor == int.Parse(id));
            return View(Datos);
        }
        public async Task<IActionResult> ActualizarProveedor(string id)
        {
            int nCodigoProveedor;
            if (id == null)
            {
                return NotFound();
            }
            nCodigoProveedor = int.Parse(id);
            var Datos = await _context.Proveedores.FindAsync(nCodigoProveedor);

            if (Datos == null)
            {
                return NotFound();
            }
            return View(Datos);
        }
        [HttpPost]
        public async Task<IActionResult> ActualizarProveedor(string id, [Bind("CodigoProveedor, NombreProveedor, Nit, Dirección")] ProveedorModel proveedormodel)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
                try
                {
                    _context.Update(proveedormodel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuscaProveedor(proveedormodel.CodigoProveedor.ToString()))
                    {
                        return NotFound();
                    }
                }
            return RedirectToAction(nameof(IndexP));
        }
        private bool BuscaProveedor(string id)
        {
            return _context.Proveedores.Any(e => e.CodigoProveedor.ToString() == id);
        }
    }
}
