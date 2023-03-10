using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cl> model = _db.Cls
                            .Include(cl => cl.St)
                            .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StId = new SelectList(_db.Sts, "StId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cl cl)
    {
      if (cl.StId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Cls.Add(cl);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cl thisCl = _db.Cls
                          .Include(cl => cl.St)
                          .FirstOrDefault(cl => cl.ClId == id);
      return View(thisCl);
    }

    public ActionResult Edit(int id)
    {
      Cl thisCl = _db.Cls.FirstOrDefault(cl => cl.ClId == id);
      ViewBag.StId = new SelectList(_db.Sts, "StId", "Name");
      return View(thisCl);
    }

    [HttpPost]
    public ActionResult Edit(Cl cl)
    {
      _db.Cls.Update(cl);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Cl thisCl = _db.Cls.FirstOrDefault(cl => cl.ClId == id);
      return View(thisCl);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Cl thisCl = _db.Cls.FirstOrDefault(cl => cl.ClId == id);
      _db.Cls.Remove(thisCl);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}