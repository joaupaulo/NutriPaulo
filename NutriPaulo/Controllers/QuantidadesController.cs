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
    public class QuantidadesController : Controller
    {
        private readonly NutriContexto _context;

        public QuantidadesController(NutriContexto context)
        {
            _context = context;
        }

        // GET: Quantidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quantidades.ToListAsync());
        }

        // GET: Quantidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantidade = await _context.Quantidades
                .FirstOrDefaultAsync(m => m.QuantidadeId == id);
            if (quantidade == null)
            {
                return NotFound();
            }

            return View(quantidade);
        }

        // GET: Quantidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quantidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuantidadeId")] Quantidade quantidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quantidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quantidade);
        }

        // GET: Quantidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantidade = await _context.Quantidades.FindAsync(id);
            if (quantidade == null)
            {
                return NotFound();
            }
            return View(quantidade);
        }

        // POST: Quantidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuantidadeId")] Quantidade quantidade)
        {
            if (id != quantidade.QuantidadeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quantidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuantidadeExists(quantidade.QuantidadeId))
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
            return View(quantidade);
        }

        // GET: Quantidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quantidade = await _context.Quantidades
                .FirstOrDefaultAsync(m => m.QuantidadeId == id);
            if (quantidade == null)
            {
                return NotFound();
            }

            return View(quantidade);
        }

        // POST: Quantidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quantidade = await _context.Quantidades.FindAsync(id);
            _context.Quantidades.Remove(quantidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuantidadeExists(int id)
        {
            return _context.Quantidades.Any(e => e.QuantidadeId == id);
        }
    }
}
