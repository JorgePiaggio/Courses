using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPhotoSharing.Models
{
    public class Comment
    {

        #region propiedades
        public int CommentID { get; set; }

        //PhotoID. This is the ID of the photo that this comment relates to
        public int PhotoID { get; set; }

        //UserName. This is the name of the user who made this comment
        public string UserName { get; set; }

        [Required]
        [StringLength(250)]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        //Photo. This is the photo that this comment relates to as a navigation property
        public virtual Photo Photo { get; set; }
        #endregion

    }
}