using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StsController : Controller
  {
    private readonly HairSalonContext _db;

    public StsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<St> model = _db.Sts.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(St st)
    {
      _db.Sts.Add(st);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      St thisSt = _db.Sts
                                  .Include(st => st.Cls)
                                  .FirstOrDefault(st => st.StId == id);
      return View(thisSt);
    }

    public ActionResult Edit(int id)
    {
      St thisSt = _db.Sts.FirstOrDefault(st => st.StId == id);
      return View(thisSt);
    }

    [HttpPost]
    public ActionResult Edit(St st)
    {
      _db.Sts.Update(st);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      St thisSt = _db.Sts.FirstOrDefault(st => st.StId == id);
      return View(thisSt);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      St thisSt = _db.Sts.FirstOrDefault(st => st.StId == id);
      _db.Sts.Remove(thisSt);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
