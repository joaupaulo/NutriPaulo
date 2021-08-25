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
    public class RelatorioPrincipalsController : Controller
    {
        private readonly NutriContexto _context;

        public RelatorioPrincipalsController(NutriContexto context)
        {
            _context = context;
        }

        // GET: RelatorioPrincipals
        public async Task<IActionResult> Index()
        {
            var nutriContexto = _context.RelatorioPrincipal.Include(r => r.Pessoas);
            return View(await nutriContexto.ToListAsync());
        }

        // GET: RelatorioPrincipals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relatorioPrincipal = await _context.RelatorioPrincipal
                .Include(r => r.Pessoas)
                .FirstOrDefaultAsync(m => m.RelatorioPrincipalId == id);
            if (relatorioPrincipal == null)
            {
                return NotFound();
            }

            return View(relatorioPrincipal);
        }

        // GET: RelatorioPrincipals/Create
        public IActionResult Create()
        {
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId");
            return View();
        }

        // POST: RelatorioPrincipals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RelatorioPrincipalId,PessoasId")] RelatorioPrincipal relatorioPrincipal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relatorioPrincipal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", relatorioPrincipal.PessoasId);
            return View(relatorioPrincipal);
        }

        // GET: RelatorioPrincipals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relatorioPrincipal = await _context.RelatorioPrincipal.FindAsync(id);
            if (relatorioPrincipal == null)
            {
                return NotFound();
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", relatorioPrincipal.PessoasId);
            return View(relatorioPrincipal);
        }

        // POST: RelatorioPrincipals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RelatorioPrincipalId,PessoasId")] RelatorioPrincipal relatorioPrincipal)
        {
            if (id != relatorioPrincipal.RelatorioPrincipalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relatorioPrincipal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioPrincipalExists(relatorioPrincipal.RelatorioPrincipalId))
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
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", relatorioPrincipal.PessoasId);
            return View(relatorioPrincipal);
        }

        // GET: RelatorioPrincipals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var relatorioPrincipal = await _context.RelatorioPrincipal
                .Include(r => r.Pessoas)
                .FirstOrDefaultAsync(m => m.RelatorioPrincipalId == id);
            if (relatorioPrincipal == null)
            {
                return NotFound();
            }

            return View(relatorioPrincipal);
        }

        // POST: RelatorioPrincipals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var relatorioPrincipal = await _context.RelatorioPrincipal.FindAsync(id);
            _context.RelatorioPrincipal.Remove(relatorioPrincipal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatorioPrincipalExists(int id)
        {
            return _context.RelatorioPrincipal.Any(e => e.RelatorioPrincipalId == id);
        }
    }
}
