using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppPhotoSharing.Models;

namespace WebAppPhotoSharing.Data
{
    public class PhotoSharingDBContext : DbContext
    {
        public PhotoSharingDBContext() : base("keyDBPhotos") { }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}