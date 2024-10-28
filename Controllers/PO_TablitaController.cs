using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PauloOlivo_ExamenP1.Data;
using PauloOlivo_ExamenP1.Models;

namespace PauloOlivo_ExamenP1.Controllers
{
    public class PO_TablitaController : Controller
    {
        private readonly PauloOlivo_ExamenP1Context _context;

        public PO_TablitaController(PauloOlivo_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: PO_Tablita
        public async Task<IActionResult> Index()
        {
            return View(await _context.PO_Tablita.ToListAsync());
        }

        // GET: PO_Tablita/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pO_Tablita = await _context.PO_Tablita
                .FirstOrDefaultAsync(m => m.PO_TablitaId == id);
            if (pO_Tablita == null)
            {
                return NotFound();
            }

            return View(pO_Tablita);
        }

        // GET: PO_Tablita/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PO_Tablita/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PO_TablitaId,PO_Tabla,PO_Nombre,PO_Apellido,PO_Precio,PO_Fecha")] PO_Tablita pO_Tablita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pO_Tablita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pO_Tablita);
        }

        // GET: PO_Tablita/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pO_Tablita = await _context.PO_Tablita.FindAsync(id);
            if (pO_Tablita == null)
            {
                return NotFound();
            }
            return View(pO_Tablita);
        }

        // POST: PO_Tablita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PO_TablitaId,PO_Tabla,PO_Nombre,PO_Apellido,PO_Precio,PO_Fecha")] PO_Tablita pO_Tablita)
        {
            if (id != pO_Tablita.PO_TablitaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pO_Tablita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PO_TablitaExists(pO_Tablita.PO_TablitaId))
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
            return View(pO_Tablita);
        }

        // GET: PO_Tablita/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pO_Tablita = await _context.PO_Tablita
                .FirstOrDefaultAsync(m => m.PO_TablitaId == id);
            if (pO_Tablita == null)
            {
                return NotFound();
            }

            return View(pO_Tablita);
        }

        // POST: PO_Tablita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pO_Tablita = await _context.PO_Tablita.FindAsync(id);
            if (pO_Tablita != null)
            {
                _context.PO_Tablita.Remove(pO_Tablita);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PO_TablitaExists(int id)
        {
            return _context.PO_Tablita.Any(e => e.PO_TablitaId == id);
        }
    }
}
