using auct.Data;
using auct.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly MyAppDbContext _db;
    public HomeController(MyAppDbContext db)
    {
        _db = db;
    }

    // GET: /
    [HttpGet]
    public IActionResult Index()
    {
        var allTasks = _db.Tasks.ToList();
        return View(allTasks);
    }

    // POST: /
    [HttpPost]
    public IActionResult Index(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            var task = new TaskItem { Name = name };
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }

    // POST: /Home/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        var task = _db.Tasks.Find(id);
        if (task != null)
        {
            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }

    // GET: Home/Edit/5
    public IActionResult Edit(int id)
    {
        var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    // POST: Home/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, TaskItem taskItem)
    {
        if (id != taskItem.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _db.Update(taskItem);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(taskItem);
    }
}
