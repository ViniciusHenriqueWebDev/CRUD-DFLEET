using DFleet_CRUD.Data;
using DFleet_CRUD.Models.Dominio;
using DFleet_CRUD.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DFleet_CRUD.Controllers
{
    public class AbastecimentoController : Controller
    {

        private readonly AppDBContext _context;
        public AbastecimentoController(AppDBContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public IActionResult Registro()
        {
            ViewBag.Estado = EstadosServices.Abastecimentos().Select(c => new SelectListItem()
            {
                Text = c.CombustivelUtilizado
            });

            ViewBag.Lista = EstadosServices.ListaAbastecimentos().Select(x => new SelectListItem()
            {
                Text = x.TipoAbastecimento
            });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(Abastecimento abastecimentoRequest)
        {
            var abastecimento = new Abastecimento()
            {
                Nome = abastecimentoRequest.Nome,
                Cidade = abastecimentoRequest.Cidade,
                Estabelecimento = abastecimentoRequest.Estabelecimento,
                Veiculo = abastecimentoRequest.Veiculo,
                Frentista = abastecimentoRequest.Frentista, 
                CombustivelUtilizado = abastecimentoRequest.CombustivelUtilizado,
                QuantidadeLitros = abastecimentoRequest.QuantidadeLitros,
                ValorLitro = abastecimentoRequest.ValorLitro,
                TipoAbastecimento = abastecimentoRequest.TipoAbastecimento,
                CompletouTanque = abastecimentoRequest.CompletouTanque,
                DataAbastecimento = abastecimentoRequest.DataAbastecimento
            };

            await _context.Abastecimento.AddAsync(abastecimento);
            await _context.SaveChangesAsync();

            return RedirectToAction("Registro");

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var abastecimentos = await _context.Abastecimento.ToListAsync();

            return View(abastecimentos);
        }

        [HttpGet]
        public async Task<IActionResult> View(int? id)
        {
            if (id == null || _context.Abastecimento == null)
            {
                return NotFound();
            }

            var abastecimento = await _context.Abastecimento.FindAsync(id);
            if (abastecimento == null)
            {
                return NotFound();
            }
            return View(abastecimento);
        }

        [HttpPost]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> View(int id, [Bind("AbastecimentoId,Nome,Estado,Cidade,Veiculo,Frentista,CombustivelUtilizado,QuantidadeLitros,ValorLitro,TipoAbastecimento,CompletouTanque,Estabelecimento,DataAbastecimento")] Abastecimento abastecimento)
        {
            if (id != abastecimento.AbastecimentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(abastecimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbastecimentoExists(abastecimento.AbastecimentoId))
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
            return View(abastecimento);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Abastecimento == null)
            {
                return NotFound();
            }

            var abastecimento = await _context.Abastecimento
                .FirstOrDefaultAsync(m => m.AbastecimentoId == id);
            if (abastecimento == null)
            {
                return NotFound();
            }

            return View(abastecimento);
        }

        // POST: AbastecimentosV2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Abastecimento == null)
            {
                return Problem("Entity set 'AppDBContext.Abastecimento'  is null.");
            }
            var abastecimento = await _context.Abastecimento.FindAsync(id);
            if (abastecimento != null)
            {
                _context.Abastecimento.Remove(abastecimento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbastecimentoExists(int id)
        {
            return _context.Abastecimento.Any(e => e.AbastecimentoId == id);
        }
    }
}
