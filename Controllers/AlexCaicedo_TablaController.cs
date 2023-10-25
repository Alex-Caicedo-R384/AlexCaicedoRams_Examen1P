using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlexCaicedoRams_Examen1P.Data;
using AlexCaicedoRams_Examen1P.Models;

namespace AlexCaicedoRams_Examen1P.Controllers
{
    public class AlexCaicedo_TablaController : Controller
    {
        private readonly AlexCaicedoRams_Examen1PContext _context;

        public AlexCaicedo_TablaController(AlexCaicedoRams_Examen1PContext context)
        {
            _context = context;
        }

        // GET: AlexCaicedo_Tabla
        public async Task<IActionResult> Index()
        {
              return _context.AlexCaicedo_Tabla != null ? 
                          View(await _context.AlexCaicedo_Tabla.ToListAsync()) :
                          Problem("Entity set 'AlexCaicedoRams_Examen1PContext.AlexCaicedo_Tabla'  is null.");
        }

        // GET: AlexCaicedo_Tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AlexCaicedo_Tabla == null)
            {
                return NotFound();
            }

            var alexCaicedo_Tabla = await _context.AlexCaicedo_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alexCaicedo_Tabla == null)
            {
                return NotFound();
            }

            return View(alexCaicedo_Tabla);
        }

        // GET: AlexCaicedo_Tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlexCaicedo_Tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AcCedula,AcNombre,AcApellido,AcMayordeEdad,AcIngresos,AcFechaNacimiento")] AlexCaicedo_Tabla alexCaicedo_Tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alexCaicedo_Tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alexCaicedo_Tabla);
        }

        // GET: AlexCaicedo_Tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AlexCaicedo_Tabla == null)
            {
                return NotFound();
            }

            var alexCaicedo_Tabla = await _context.AlexCaicedo_Tabla.FindAsync(id);
            if (alexCaicedo_Tabla == null)
            {
                return NotFound();
            }
            return View(alexCaicedo_Tabla);
        }

        // POST: AlexCaicedo_Tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AcCedula,AcNombre,AcApellido,AcMayordeEdad,AcIngresos,AcFechaNacimiento")] AlexCaicedo_Tabla alexCaicedo_Tabla)
        {
            if (id != alexCaicedo_Tabla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alexCaicedo_Tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlexCaicedo_TablaExists(alexCaicedo_Tabla.Id))
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
            return View(alexCaicedo_Tabla);
        }

        // GET: AlexCaicedo_Tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AlexCaicedo_Tabla == null)
            {
                return NotFound();
            }

            var alexCaicedo_Tabla = await _context.AlexCaicedo_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alexCaicedo_Tabla == null)
            {
                return NotFound();
            }

            return View(alexCaicedo_Tabla);
        }

        // POST: AlexCaicedo_Tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AlexCaicedo_Tabla == null)
            {
                return Problem("Entity set 'AlexCaicedoRams_Examen1PContext.AlexCaicedo_Tabla'  is null.");
            }
            var alexCaicedo_Tabla = await _context.AlexCaicedo_Tabla.FindAsync(id);
            if (alexCaicedo_Tabla != null)
            {
                _context.AlexCaicedo_Tabla.Remove(alexCaicedo_Tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlexCaicedo_TablaExists(int id)
        {
          return (_context.AlexCaicedo_Tabla?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
