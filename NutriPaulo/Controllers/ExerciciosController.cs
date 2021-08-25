﻿using System;
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
    public class ExerciciosController : Controller
    {
        private readonly NutriContexto _context;

        public ExerciciosController(NutriContexto context)
        {
            _context = context;
        }

        // GET: Exercicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exercicios.ToListAsync());
        }

        // GET: Exercicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicios = await _context.Exercicios
                .FirstOrDefaultAsync(m => m.ExerciciosId == id);
            if (exercicios == null)
            {
                return NotFound();
            }

            return View(exercicios);
        }

        // GET: Exercicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exercicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExerciciosId")] Exercicios exercicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exercicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exercicios);
        }

        // GET: Exercicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicios = await _context.Exercicios.FindAsync(id);
            if (exercicios == null)
            {
                return NotFound();
            }
            return View(exercicios);
        }

        // POST: Exercicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExerciciosId")] Exercicios exercicios)
        {
            if (id != exercicios.ExerciciosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciciosExists(exercicios.ExerciciosId))
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
            return View(exercicios);
        }

        // GET: Exercicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercicios = await _context.Exercicios
                .FirstOrDefaultAsync(m => m.ExerciciosId == id);
            if (exercicios == null)
            {
                return NotFound();
            }

            return View(exercicios);
        }

        // POST: Exercicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exercicios = await _context.Exercicios.FindAsync(id);
            _context.Exercicios.Remove(exercicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciciosExists(int id)
        {
            return _context.Exercicios.Any(e => e.ExerciciosId == id);
        }
    }
}
