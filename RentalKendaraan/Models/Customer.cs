using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    /// <summary>
    /// CustomerModels
    /// </summary>
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "ID Customer tidak boleh kosong")]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage="Nama Customer tidak boleh kosong")]
        [MaxLength(30, ErrorMessage = "Maksimal")]
        public string NamaCustomer { get; set; }
        [Required(ErrorMessage = "NIK tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage ="Hanya bisa diisi oleh angka !!")]
        [MinLength(16, ErrorMessage ="NIK Minimal 16 angka")]
        [MaxLength(16, ErrorMessage = "NIK Minimal 16 angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        [MaxLength(150, ErrorMessage = "Maksimal")]
        public string Alamat { get; set; }
        [Required(ErrorMessage = "No HP tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya bisa diisi oleh angka !!")]
        [MinLength(10, ErrorMessage = "No HP Minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP Minimal 13 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
