using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    
    public class PhotoController : Controller
    {
        private AppDbContext db = new AppDbContext();
        [Authorize(Roles = "1")]
        // GET: Photo
        public ActionResult Index()
        {
            return View(db.Photos.ToList());
        }

        [Authorize(Roles = "1")]
        public ActionResult Create()
        {
            return View();
        }


        [Authorize(Roles = "1")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Photo photo, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(imageFile.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads/"), fileName);
                    imageFile.SaveAs(path);
                    photo.ImagePath = "~/Uploads/" + fileName;
                }
                db.Photos.Add(photo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photo);
        }


        [Authorize(Roles = "1")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Photo photo = db.Photos.Find(id);
            if (photo == null)
            {
                return HttpNotFound();
            }
            return View(photo);
        }


        [Authorize(Roles = "1")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Photo photo, HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    // Delete the old image file if exists
                    if (!string.IsNullOrEmpty(photo.ImagePath))
                    {
                        var oldImagePath = Server.MapPath(photo.ImagePath);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    // Save the new image file
                    var fileName = Path.GetFileName(imageFile.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads/"), fileName);
                    imageFile.SaveAs(path);
                    photo.ImagePath = "~/Uploads/" + fileName;
                }

                db.Entry(photo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photo);
        }


        [Authorize(Roles = "1")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Photo photo = db.Photos.Find(id);
            db.Photos.Remove(photo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public PartialViewResult DisplayPhoto(string tittle)
        {
            Photo photo = db.Photos.FirstOrDefault(e=>e.Title == tittle);
            return PartialView("_DisplayPhoto", photo);
        }


        public PartialViewResult CopyRightText(string tittle)
        {
            Photo photo = db.Photos.FirstOrDefault(e => e.Title == tittle);
            return PartialView("_CopyRightText", photo);
        }
    }
}