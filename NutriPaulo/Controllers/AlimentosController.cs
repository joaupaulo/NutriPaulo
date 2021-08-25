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
    public class AlimentosController : Controller
    {
        private readonly NutriContexto _context;

        public AlimentosController(NutriContexto context)
        {
            _context = context;
        }

        // GET: Alimentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alimentos.ToListAsync());
        }

        // GET: Alimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentos = await _context.Alimentos
                .FirstOrDefaultAsync(m => m.AlimentosId == id);
            if (alimentos == null)
            {
                return NotFound();
            }

            return View(alimentos);
        }

        // GET: Alimentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlimentosId,CafeDaManha,Almoço,Lanche,CafeDaNoite")] Alimentos alimentos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alimentos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alimentos);
        }

        // GET: Alimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentos = await _context.Alimentos.FindAsync(id);
            if (alimentos == null)
            {
                return NotFound();
            }
            return View(alimentos);
        }

        // POST: Alimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlimentosId,CafeDaManha,Almoço,Lanche,CafeDaNoite")] Alimentos alimentos)
        {
            if (id != alimentos.AlimentosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alimentos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlimentosExists(alimentos.AlimentosId))
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
            return View(alimentos);
        }

        // GET: Alimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alimentos = await _context.Alimentos
                .FirstOrDefaultAsync(m => m.AlimentosId == id);
            if (alimentos == null)
            {
                return NotFound();
            }

            return View(alimentos);
        }

        // POST: Alimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alimentos = await _context.Alimentos.FindAsync(id);
            _context.Alimentos.Remove(alimentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlimentosExists(int id)
        {
            return _context.Alimentos.Any(e => e.AlimentosId == id);
        }
    }
}
