using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    /// <summary>
    /// JaminanModels
    /// </summary>
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "ID Jaminan tidak boleh kosong")]
        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama Jaminan tidak boleh kosong")]
        [MaxLength(40, ErrorMessage = "Maksimal")]
        public string NamaJaminan { get; set; }

        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
