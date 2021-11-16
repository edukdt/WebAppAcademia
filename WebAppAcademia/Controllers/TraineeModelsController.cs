using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppAcademia.Data;
using WebAppAcademia.Models;

namespace WebAppAcademia.Controllers
{
    public class TraineeModelsController : Controller
    {
        private readonly WebAppAcademiaContext _context;

        public TraineeModelsController(WebAppAcademiaContext context)
        {
            _context = context;
        }

        // GET: TraineeModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TraineeModel.ToListAsync());
        }

        // GET: TraineeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeModel = await _context.TraineeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traineeModel == null)
            {
                return NotFound();
            }

            return View(traineeModel);
        }

        // GET: TraineeModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TraineeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] TraineeModel traineeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(traineeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(traineeModel);
        }

        // GET: TraineeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeModel = await _context.TraineeModel.FindAsync(id);
            if (traineeModel == null)
            {
                return NotFound();
            }
            return View(traineeModel);
        }

        // POST: TraineeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] TraineeModel traineeModel)
        {
            if (id != traineeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(traineeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TraineeModelExists(traineeModel.Id))
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
            return View(traineeModel);
        }

        // GET: TraineeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeModel = await _context.TraineeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (traineeModel == null)
            {
                return NotFound();
            }

            return View(traineeModel);
        }

        // POST: TraineeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var traineeModel = await _context.TraineeModel.FindAsync(id);
            _context.TraineeModel.Remove(traineeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TraineeModelExists(int id)
        {
            return _context.TraineeModel.Any(e => e.Id == id);
        }
    }
}
