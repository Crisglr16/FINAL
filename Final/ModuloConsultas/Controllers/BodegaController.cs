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
    public class BodegaController : Controller
    {
        private readonly ILogger<BodegaController> _logger;
        private readonly Conn _context;

        public BodegaController(Conn context)
        {
            _context = context;
        }
        public IActionResult IndexB()
        {
            return View();
        }
        public async Task<IActionResult> Bodega()
        {
            return View(await _context.Bodega.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Bodega([Bind("CodigoSalida, CodigoProveedor, FechaIngreso, ExistenciaProducto")] BodegaModel bodegamodel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bodegamodel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexB));
            }
            return View(bodegamodel);
        }
        [HttpGet]
        public async Task<IActionResult> ConsultaBodega(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Datos = await _context.Bodega
                .FirstOrDefaultAsync(a => a.CodigoSalida == int.Parse(id));
            return View(Datos);
        }
        public async Task<IActionResult> ActualizarBodega(string id)
        {
            int nCodigoSalida;
            if (id == null)
            {
                return NotFound();
            }
            nCodigoSalida = int.Parse(id);
            var Datos = await _context.Bodega.FindAsync(nCodigoSalida);

            if (Datos == null)
            {
                return NotFound();
            }
            return View(Datos);
        }
        [HttpPost]
        public async Task<IActionResult> ActualizarBodega(string id, [Bind("CodigoSalida, CodigoProveedor, FechaIngreso, ExistenciaProducto")] BodegaModel bodegamodel)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
                try
                {
                    _context.Update(bodegamodel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuscaBodega(bodegamodel.CodigoSalida.ToString()))
                    {
                        return NotFound();
                    }
                }
            return RedirectToAction(nameof(IndexB));
        }
        private bool BuscaBodega(string id)
        {
            return _context.Bodega.Any(e => e.CodigoSalida.ToString() == id);
        }
    }
}
