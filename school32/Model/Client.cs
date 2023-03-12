namespace school32.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public DateTime RegistrationDate { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(1)]
        public string GenderCode { get; set; }

        [StringLength(1000)]
        public string PhotoPath { get; set; }

        public virtual Gender Gender { get; set; }

    }
}
