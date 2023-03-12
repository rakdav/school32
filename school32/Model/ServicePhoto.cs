namespace school32.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicePhoto")]
    public partial class ServicePhoto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceID { get; set; }

        [Required]
        [StringLength(1000)]
        public string PhotoPath { get; set; }

        public virtual Service Service { get; set; }
    }
}
