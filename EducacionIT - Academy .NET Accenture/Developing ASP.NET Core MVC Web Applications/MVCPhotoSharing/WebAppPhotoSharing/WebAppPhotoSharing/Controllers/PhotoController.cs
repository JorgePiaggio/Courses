using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPhotoSharing.Models;
using WebAppPhotoSharing.Data;
using System.Collections.Generic;

namespace WebAppPhotoSharing.Controllers
{
    [ValueReporter]
    public class PhotoController : Controller
    {
        private PhotoSharingDBContext context = new PhotoSharingDBContext();


        #region endpoints
        // GET: Photo
        public ActionResult Index()
        {
            return View("Index");
        }


        [ChildActionOnly]
        public ActionResult _PhotoGallery(int number = 0)
        {
            List<Photo> photos;
            if (number == 0)
            {
                photos = context.Photos.ToList();
            }
            else
            {
                photos = ( from p in context.Photos orderby p.CreationDate descending select p).Take(number).ToList();
            }

            return PartialView("_PhotoGallery",photos);
        }


        public ActionResult Display(int id)
        {
            Photo photo = context.Photos.Find(id);

            if (photo == null)
            {
                return HttpNotFound();
            }
            return View("Display", photo);
        }

        #region create

        public ActionResult Create()
        {
            Photo newPhoto = new Photo();
            newPhoto.CreationDate = DateTime.Today;

            return View("Create", newPhoto);
        }

        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
            photo.CreationDate = DateTime.Today;

            if (!ModelState.IsValid)
            {
                return View("Create", photo);
            }
            else
            {
                if (image != null)
                {
                    photo.ImageMimeType = image.ContentType;
                    photo.PhotoFile = new byte[image.ContentLength];
                    image.InputStream.Read(photo.PhotoFile, 0, image.ContentLength);
                    context.Photos.Add(photo);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }

        }
        #endregion

        #region delete
        public ActionResult Delete(int id)
        {
            Photo photo = context.Photos.Find(id);

            if(photo == null)
            {
                return HttpNotFound();
            }
            return View("Delete", photo);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Photo photo = context.Photos.Find(id);
            context.Photos.Remove(photo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region getImage
        public FileContentResult GetImage(int id)
        {
            Photo photo = context.Photos.Find(id);

            if(photo != null)
            {
                return File(photo.PhotoFile, photo.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
        #endregion


        #endregion


    }
}