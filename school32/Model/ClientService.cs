namespace school32.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientService")]
    public partial class ClientService
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientID { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        public string Comment { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }
    }
}
