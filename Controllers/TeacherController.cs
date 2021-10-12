using JinKeTang.Models;
using JinKeTang.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace JinKeTang.Controllers
{
    public class TeacherController : Controller
    {
        JKTDbContext dbContext;
        public TeacherController(JKTDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveReg(Teacher model)
        {
            dbContext.Teachers.Add(model);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult List(string gh = null, string xm = null)
        {
            IQueryable<Teacher> list = dbContext.Teachers;

            if (!string.IsNullOrEmpty(gh)) list = list.Where(a => a.GH == gh);

            if (!string.IsNullOrEmpty(xm)) list = list.Where(a => a.XM.Contains(xm));

            return View(list.ToList());
        }


        public IActionResult Edit(int id)
        {
            var m = dbContext.Teachers.Find(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult Edit(int id, Teacher teacher)
        {
            var m = dbContext.Teachers.Find(id);
            if (m != null)
            {
                m.XM = teacher.XM;
                m.XB = teacher.XB;
                m.MM = teacher.MM;
                m.GH = teacher.GH;
                dbContext.Teachers.Update(m);
                dbContext.SaveChanges();
                return RedirectToAction("list");
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var m = dbContext.Teachers.Find(id);
            if (m != null)
            {
                dbContext.Remove(m);
                dbContext.SaveChanges();
                return Json(new { code = 0 });
            }
            else return Json(new { code = 1, msg = "数据不存在" });
        }
    }
}
