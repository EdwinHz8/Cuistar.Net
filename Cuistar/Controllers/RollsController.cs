using Cuistar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cuistar.Controllers
{
    public class RollsController : Controller
    {
        private readonly Cuistar4Context _context;

        public RollsController(Cuistar4Context context)
        {
            _context = context;
        }

        // GET: Rolls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rolls.ToListAsync());
        }

        // GET: Rolls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls
                .FirstOrDefaultAsync(m => m.IdRol == id);
            if (roll == null)
            {
                return NotFound();
            }

            return View(roll);
        }

        // GET: Rolls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rolls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRol,Descripcion,Trial760")] Roll roll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roll);
        }

        // GET: Rolls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls.FindAsync(id);
            if (roll == null)
            {
                return NotFound();
            }
            return View(roll);
        }

        // POST: Rolls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRol,Descripcion,Trial760")] Roll roll)
        {
            if (id != roll.IdRol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RollExists(roll.IdRol))
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
            return View(roll);
        }

        // GET: Rolls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roll = await _context.Rolls
                .FirstOrDefaultAsync(m => m.IdRol == id);
            if (roll == null)
            {
                return NotFound();
            }

            return View(roll);
        }

        // POST: Rolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roll = await _context.Rolls.FindAsync(id);
            if (roll != null)
            {
                _context.Rolls.Remove(roll);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RollExists(int id)
        {
            return _context.Rolls.Any(e => e.IdRol == id);
        }
    }
}
