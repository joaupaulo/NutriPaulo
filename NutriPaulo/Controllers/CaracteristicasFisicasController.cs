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
    public class CaracteristicasFisicasController : Controller
    {
        private readonly NutriContexto _context;

        public CaracteristicasFisicasController(NutriContexto context)
        {
            _context = context;
        }

        // GET: CaracteristicasFisicas
        public async Task<IActionResult> Index()
        {
            var nutriContexto = _context.CaracteristicasFisicas.Include(c => c.PessoaId);
            return View(await nutriContexto.ToListAsync());
        }

        // GET: CaracteristicasFisicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caracteristicasFisicas = await _context.CaracteristicasFisicas
                .Include(c => c.PessoaId)
                .FirstOrDefaultAsync(m => m.CaracteFisicasId == id);
            if (caracteristicasFisicas == null)
            {
                return NotFound();
            }

            return View(caracteristicasFisicas);
        }

        // GET: CaracteristicasFisicas/Create
        public IActionResult Create()
        {
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId");
            return View();
        }

        // POST: CaracteristicasFisicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CaracteFisicasId,Altura,Peso,Biotipo,PessoasId")] CaracteristicasFisicas caracteristicasFisicas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caracteristicasFisicas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", caracteristicasFisicas.PessoasId);
            return View(caracteristicasFisicas);
        }

        // GET: CaracteristicasFisicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caracteristicasFisicas = await _context.CaracteristicasFisicas.FindAsync(id);
            if (caracteristicasFisicas == null)
            {
                return NotFound();
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", caracteristicasFisicas.PessoasId);
            return View(caracteristicasFisicas);
        }

        // POST: CaracteristicasFisicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CaracteFisicasId,Altura,Peso,Biotipo,PessoasId")] CaracteristicasFisicas caracteristicasFisicas)
        {
            if (id != caracteristicasFisicas.CaracteFisicasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caracteristicasFisicas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaracteristicasFisicasExists(caracteristicasFisicas.CaracteFisicasId))
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
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", caracteristicasFisicas.PessoasId);
            return View(caracteristicasFisicas);
        }

        // GET: CaracteristicasFisicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caracteristicasFisicas = await _context.CaracteristicasFisicas
                .Include(c => c.PessoaId)
                .FirstOrDefaultAsync(m => m.CaracteFisicasId == id);
            if (caracteristicasFisicas == null)
            {
                return NotFound();
            }

            return View(caracteristicasFisicas);
        }

        // POST: CaracteristicasFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caracteristicasFisicas = await _context.CaracteristicasFisicas.FindAsync(id);
            _context.CaracteristicasFisicas.Remove(caracteristicasFisicas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaracteristicasFisicasExists(int id)
        {
            return _context.CaracteristicasFisicas.Any(e => e.CaracteFisicasId == id);
        }
    }
}
