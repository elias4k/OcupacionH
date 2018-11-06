using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Microsoft.AspNetCore.Authorization;
using Core.Abstract;

namespace SistemaReservas
{
    [Authorize]
    public class AlojamientosController : Controller
    {
        private readonly AlojamientoDataBaseContext _context;

        public AlojamientosController(AlojamientoDataBaseContext context)
        {
            _context = context;
        }

        //GET: Alojamientos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alojamientos.ToListAsync());
        }

        // GET: Alojamientos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamientos = await _context.Alojamientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alojamientos == null)
            {
                return NotFound();
            }

            return View(alojamientos);
           
        }

        //GET: Alojamientos/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Alojamientos/Create
       // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
         //more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Localidad,Clase,NroHab,NroHabOcupadas,Plazas,PlazasOcupadas,Reservas")] Alojamientos alojamientos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alojamientos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alojamientos);
        }

        //GET: Alojamientos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamientos = await _context.Alojamientos.FindAsync(id);
            if (alojamientos == null)
            {
                return NotFound();
            }
            return View(alojamientos);
        }

        // POST: Alojamientos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Localidad,Clase,NroHab,NroHabOcupadas,Plazas,PlazasOcupadas,Reservas")] Alojamientos alojamientos)
        {
            if (id != alojamientos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alojamientos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlojamientosExists(alojamientos.Id))
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
            return View(alojamientos);
        }

        // GET: Alojamientos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alojamientos = await _context.Alojamientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alojamientos == null)
            {
                return NotFound();
            }

            return View(alojamientos);
        }

        // POST: Alojamientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alojamientos = await _context.Alojamientos.FindAsync(id);
            _context.Alojamientos.Remove(alojamientos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlojamientosExists(int id)
        {
            return _context.Alojamientos.Any(e => e.Id == id);
        }
    }
}
