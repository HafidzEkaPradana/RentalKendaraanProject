using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    /// <summary>
    /// JenisKendaraanModels
    /// </summary>
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraans = new HashSet<Kendaraan>();
        }
        [Required(ErrorMessage = "ID Jenis Kendaraan tidak boleh kosong")]
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Jenis Kendaraan tidak boleh kosong")]
        [MaxLength(30, ErrorMessage = "Maksimal")]
        public string NamaJenisKendaraan { get; set; }

        public virtual ICollection<Kendaraan> Kendaraans { get; set; }
    }
}
