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
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly Conn _context;

        public ProductoController(Conn context)
        {
            _context = context;
        }

        public IActionResult Productos()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Productos([Bind("CodigoProducto, NombreProducto, CantidadProducto, FechaIngreso, FechaVencimiento, CodigoProveedor, NombreProveedor")] ProductoModel productomodel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productomodel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productomodel);
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaProducto(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Datos = await _context.Productos
                .FirstOrDefaultAsync(a => a.CodigoProducto == int.Parse(id));
            return View(Datos);
        }

        public async Task<IActionResult> ActualizarProducto(string id)
        {
            int nCodigoProducto;
            if (id == null)
            {
                return NotFound();
            }
            nCodigoProducto = int.Parse(id);
            var Datos = await _context.Productos.FindAsync(nCodigoProducto);

            if (Datos == null)
            {
                return NotFound();
            }
            return View(Datos);
        }

        [HttpPost]
        public async Task<IActionResult> ActualizarProducto(string id, [Bind("CodigoProducto, NombreProducto, CantidadProducto, FechaIngreso, FechaVencimiento, CodigoProveedor, NombreProveedor")] ProductoModel productomodel)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
                try
                {
                    _context.Update(productomodel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuscaProducto(productomodel.CodigoProducto.ToString()))
                    {
                        return NotFound();
                    }
                }
            return RedirectToAction(nameof(Index));
        }
        private bool BuscaProducto(string id)
        {
            return _context.Productos.Any(e => e.CodigoProducto.ToString() == id);
        }
    }
}
