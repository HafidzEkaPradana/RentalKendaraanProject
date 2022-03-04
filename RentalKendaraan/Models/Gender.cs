using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }
        [Required(ErrorMessage = "Gender tidak boleh kosong")]
        public int IdGender { get; set; }
        [Required(ErrorMessage = "Nama Gender tidak boleh kosong")]
        [MaxLength(1, ErrorMessage = "Maksimal")]
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
