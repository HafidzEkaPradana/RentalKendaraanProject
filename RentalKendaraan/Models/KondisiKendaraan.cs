using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    /// <summary>
    /// KondisiKendaraanModels
    /// </summary>
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }
        [Required(ErrorMessage = "ID Kondisi tidak boleh kosong")]
        public int IdKondisi { get; set; }
        [Required(ErrorMessage = "Kondisi tidak boleh kosong")]
        [MaxLength(30, ErrorMessage = "Maksimal")]
        public string NamaKondisi { get; set; }

        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
