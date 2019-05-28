using Indimaret.Model;
using Indimaret.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class BarangController : Controller
    {
        //
        // GET: /Barang/
        public ActionResult Index()
        {
            return View(BarangRepoo.GetAll());
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(BarangModel barangModel)
        {
            if (BarangRepoo.Createbarang(barangModel))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            if (BarangRepoo.Deletebarang(ID))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit", BarangRepoo.GetByID(ID));
        }


        public ActionResult Update(BarangModel barangModel)
        {
            if (BarangRepoo.Editbarang(barangModel))
            {
                return Json(new { Gantidata = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Gantidata = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }
    }
}