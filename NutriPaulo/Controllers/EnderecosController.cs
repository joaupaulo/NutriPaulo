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
    public class EnderecosController : Controller
    {
        private readonly NutriContexto _context;

        public EnderecosController(NutriContexto context)
        {
            _context = context;
        }

        // GET: Enderecos
        public async Task<IActionResult> Index()
        {
            var nutriContexto = _context.Enderecos.Include(e => e.Pessoas);
            return View(await nutriContexto.ToListAsync());
        }

        // GET: Enderecos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecos = await _context.Enderecos
                .Include(e => e.Pessoas)
                .FirstOrDefaultAsync(m => m.EnderecosId == id);
            if (enderecos == null)
            {
                return NotFound();
            }

            return View(enderecos);
        }

        // GET: Enderecos/Create
        public IActionResult Create()
        {
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId");
            return View();
        }

        // POST: Enderecos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnderecosId,Bairro,Complemento,Numero,CEP,Pais,Cidade,Estado,PessoasId")] Enderecos enderecos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enderecos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", enderecos.PessoasId);
            return View(enderecos);
        }

        // GET: Enderecos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecos = await _context.Enderecos.FindAsync(id);
            if (enderecos == null)
            {
                return NotFound();
            }
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", enderecos.PessoasId);
            return View(enderecos);
        }

        // POST: Enderecos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnderecosId,Bairro,Complemento,Numero,CEP,Pais,Cidade,Estado,PessoasId")] Enderecos enderecos)
        {
            if (id != enderecos.EnderecosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enderecos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecosExists(enderecos.EnderecosId))
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
            ViewData["PessoasId"] = new SelectList(_context.Pessoas, "PessoasId", "PessoasId", enderecos.PessoasId);
            return View(enderecos);
        }

        // GET: Enderecos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enderecos = await _context.Enderecos
                .Include(e => e.Pessoas)
                .FirstOrDefaultAsync(m => m.EnderecosId == id);
            if (enderecos == null)
            {
                return NotFound();
            }

            return View(enderecos);
        }

        // POST: Enderecos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enderecos = await _context.Enderecos.FindAsync(id);
            _context.Enderecos.Remove(enderecos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecosExists(int id)
        {
            return _context.Enderecos.Any(e => e.EnderecosId == id);
        }
    }
}
