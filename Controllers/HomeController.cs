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
}
