﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppPhotoSharing.Models;

namespace WebAppPhotoSharing.Data
{
    public class PhotoSharingDBContext : DbContext, IPhotoSharingContext
    {
        public PhotoSharingDBContext() : base("keyDBPhotos") { }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        IQueryable<Photo> IPhotoSharingContext.Photos { get { return Photos; }}
        IQueryable<Comment> IPhotoSharingContext.Comments { get { return Comments; }}
        int IPhotoSharingContext.SaveChanges(){ return SaveChanges(); }
        T IPhotoSharingContext.Add<T>(T entity){ return Set<T>().Add(entity); }
        Photo IPhotoSharingContext.FindPhotoById(int ID){ return Set<Photo>().Find(ID); }
       // Photo IPhotoSharingContext.FindPhotoByTitle(string title) { return Set<Photo>().Find(title); }
        Comment IPhotoSharingContext.FindCommentById(int ID){ return Set<Comment>().Find(ID);}
        T IPhotoSharingContext.Delete<T>(T entity){ return Set<T>().Remove(entity); }






    }
}