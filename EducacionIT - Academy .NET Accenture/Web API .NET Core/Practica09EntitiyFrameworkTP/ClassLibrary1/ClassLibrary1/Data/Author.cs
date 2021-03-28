namespace ClassLibrary1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        [Key]
        [StringLength(11)]
        public string au_id { get; set; }

        [Required]
        [StringLength(40)]
        public string au_lname { get; set; }

        [Required]
        [StringLength(20)]
        public string au_fname { get; set; }

        [Required]
        [StringLength(12)]
        public string phone { get; set; }

        [StringLength(40)]
        public string address { get; set; }

        [StringLength(20)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(5)]
        public string zip { get; set; }

        public bool contract { get; set; }
    }
}
