using Cuistar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cuistar.Controllers
{
    public class ProductoesController : Controller
    {
        private readonly Cuistar4Context _context;

        public ProductoesController(Cuistar4Context context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            var cuistar4Context = _context.Productos.Include(p => p.IdCategoriaNavigation).Include(p => p.IdTallasNavigation).Include(p => p.IdTipoproduNavigation).Include(p => p.IdUnidadmedidaNavigation);
            return View(await cuistar4Context.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.IdTallasNavigation)
                .Include(p => p.IdTipoproduNavigation)
                .Include(p => p.IdUnidadmedidaNavigation)
                .FirstOrDefaultAsync(m => m.IdProductos == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria");
            ViewData["IdTallas"] = new SelectList(_context.Tallas, "IdTallas", "IdTallas");
            ViewData["IdTipoprodu"] = new SelectList(_context.TipoProductos, "IdTipoprodu", "IdTipoprodu");
            ViewData["IdUnidadmedida"] = new SelectList(_context.UnidadMedida, "IdUnidadmedida", "IdUnidadmedida");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProductos,NombreProducto,DescripcionProducto,IdTipoprodu,IdUnidadmedida,PrecioUnitario,IdCategoria,IdTallas,Imagen,Trial757")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria", producto.IdCategoria);
            ViewData["IdTallas"] = new SelectList(_context.Tallas, "IdTallas", "IdTallas", producto.IdTallas);
            ViewData["IdTipoprodu"] = new SelectList(_context.TipoProductos, "IdTipoprodu", "IdTipoprodu", producto.IdTipoprodu);
            ViewData["IdUnidadmedida"] = new SelectList(_context.UnidadMedida, "IdUnidadmedida", "IdUnidadmedida", producto.IdUnidadmedida);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria", producto.IdCategoria);
            ViewData["IdTallas"] = new SelectList(_context.Tallas, "IdTallas", "IdTallas", producto.IdTallas);
            ViewData["IdTipoprodu"] = new SelectList(_context.TipoProductos, "IdTipoprodu", "IdTipoprodu", producto.IdTipoprodu);
            ViewData["IdUnidadmedida"] = new SelectList(_context.UnidadMedida, "IdUnidadmedida", "IdUnidadmedida", producto.IdUnidadmedida);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProductos,NombreProducto,DescripcionProducto,IdTipoprodu,IdUnidadmedida,PrecioUnitario,IdCategoria,IdTallas,Imagen,Trial757")] Producto producto)
        {
            if (id != producto.IdProductos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.IdProductos))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "IdCategoria", "IdCategoria", producto.IdCategoria);
            ViewData["IdTallas"] = new SelectList(_context.Tallas, "IdTallas", "IdTallas", producto.IdTallas);
            ViewData["IdTipoprodu"] = new SelectList(_context.TipoProductos, "IdTipoprodu", "IdTipoprodu", producto.IdTipoprodu);
            ViewData["IdUnidadmedida"] = new SelectList(_context.UnidadMedida, "IdUnidadmedida", "IdUnidadmedida", producto.IdUnidadmedida);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Include(p => p.IdTallasNavigation)
                .Include(p => p.IdTipoproduNavigation)
                .Include(p => p.IdUnidadmedidaNavigation)
                .FirstOrDefaultAsync(m => m.IdProductos == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.IdProductos == id);
        }
    }
}
