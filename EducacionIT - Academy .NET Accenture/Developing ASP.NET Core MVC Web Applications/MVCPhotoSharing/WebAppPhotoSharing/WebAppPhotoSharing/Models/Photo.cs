using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPhotoSharing.Models
{
    public class Photo
    {
        #region propiedades
        public int PhotoID { get; set; } 

        [Required]
        public string Title { get; set; }

        [DisplayName("Picture")]
        [MaxLength]
        public byte[] PhotoFile { get; set; }

        // ImageMimeType, stores the MIME type for the PhotoFile
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        public string UserName { get; set; }

        // All the comments on this photo, as a navigation property
        public virtual ICollection<Comment> Comments { get; set; }
      
        #endregion
    }
}