using Microsoft.AspNetCore.Mvc;
using smtpEmail.Models;

namespace smtpEmail.Controllers
{
    public class register : Controller
    {
        private readonly proContext _context;
        public register(proContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var register = _context.Registers.ToList();
            return View(register);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Register model,string name,string uname, string email,string pass)
        {
            model.Rname = name;
            model.Runame=uname;
            model.Remail = email;
            model.Rpass= pass;

            _context.Registers.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
