using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NutriPaulo.Contexto;
using NutriPaulo.Models;

namespace NutriPaulo.Controllers
{
    public class NutrientesAlimentosController : Controller
    {
        private readonly NutriContexto _context;

        public NutrientesAlimentosController(NutriContexto context)
        {
            _context = context;
        }

        // GET: NutrientesAlimentos
        public async Task<IActionResult> Index()
        {
            var nutriContexto = _context.NutrientesAlimentos.Include(n => n.Alimentos).Include(n => n.Nutrientes);
            return View(await nutriContexto.ToListAsync());
        }

        // GET: NutrientesAlimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientesAlimentos = await _context.NutrientesAlimentos
                .Include(n => n.Alimentos)
                .Include(n => n.Nutrientes)
                .FirstOrDefaultAsync(m => m.AlimentosId == id);
            if (nutrientesAlimentos == null)
            {
                return NotFound();
            }

            return View(nutrientesAlimentos);
        }

        // GET: NutrientesAlimentos/Create
        public IActionResult Create()
        {
            ViewData["AlimentosId"] = new SelectList(_context.Alimentos, "AlimentosId", "AlimentosId");
            ViewData["NutrientesId"] = new SelectList(_context.Nutrientes, "NutrientesId", "NutrientesId");
            return View();
        }

        // POST: NutrientesAlimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlimentosId,NutrientesId")] NutrientesAlimentos nutrientesAlimentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nutrientesAlimentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlimentosId"] = new SelectList(_context.Alimentos, "AlimentosId", "AlimentosId", nutrientesAlimentos.AlimentosId);
            ViewData["NutrientesId"] = new SelectList(_context.Nutrientes, "NutrientesId", "NutrientesId", nutrientesAlimentos.NutrientesId);
            return View(nutrientesAlimentos);
        }

        // GET: NutrientesAlimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientesAlimentos = await _context.NutrientesAlimentos.FindAsync(id);
            if (nutrientesAlimentos == null)
            {
                return NotFound();
            }
            ViewData["AlimentosId"] = new SelectList(_context.Alimentos, "AlimentosId", "AlimentosId", nutrientesAlimentos.AlimentosId);
            ViewData["NutrientesId"] = new SelectList(_context.Nutrientes, "NutrientesId", "NutrientesId", nutrientesAlimentos.NutrientesId);
            return View(nutrientesAlimentos);
        }

        // POST: NutrientesAlimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlimentosId,NutrientesId")] NutrientesAlimentos nutrientesAlimentos)
        {
            if (id != nutrientesAlimentos.AlimentosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nutrientesAlimentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutrientesAlimentosExists(nutrientesAlimentos.AlimentosId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlimentosId"] = new SelectList(_context.Alimentos, "AlimentosId", "AlimentosId", nutrientesAlimentos.AlimentosId);
            ViewData["NutrientesId"] = new SelectList(_context.Nutrientes, "NutrientesId", "NutrientesId", nutrientesAlimentos.NutrientesId);
            return View(nutrientesAlimentos);
        }

        // GET: NutrientesAlimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientesAlimentos = await _context.NutrientesAlimentos
                .Include(n => n.Alimentos)
                .Include(n => n.Nutrientes)
                .FirstOrDefaultAsync(m => m.AlimentosId == id);
            if (nutrientesAlimentos == null)
            {
                return NotFound();
            }

            return View(nutrientesAlimentos);
        }

        // POST: NutrientesAlimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nutrientesAlimentos = await _context.NutrientesAlimentos.FindAsync(id);
            _context.NutrientesAlimentos.Remove(nutrientesAlimentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutrientesAlimentosExists(int id)
        {
            return _context.NutrientesAlimentos.Any(e => e.AlimentosId == id);
        }
    }
}
