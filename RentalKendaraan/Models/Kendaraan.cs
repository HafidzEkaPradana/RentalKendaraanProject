using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }
        [Required(ErrorMessage = "ID Kendaraan tidak boleh kosong")]
        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "No Polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }
        [Required(ErrorMessage = "No STNK tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya bisa diisi oleh angka !!")]
        [MinLength(8, ErrorMessage = "No HP STNK Minimal 8 angka")]
        [MaxLength(8, ErrorMessage = "No HP STNK Minimal 8 angka")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "ID Jenis Kendaraan tidak boleh kosong")]
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }
        public virtual JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
