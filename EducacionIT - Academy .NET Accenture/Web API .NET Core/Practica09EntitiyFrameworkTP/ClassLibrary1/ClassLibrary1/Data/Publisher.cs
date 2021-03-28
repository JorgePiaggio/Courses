namespace ClassLibrary1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Publisher
    {
        [Key]
        [StringLength(4)]
        public string pub_id { get; set; }

        [StringLength(40)]
        public string pub_name { get; set; }

        [StringLength(20)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(30)]
        public string country { get; set; }
    }
}
