using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    /// <summary>
    /// PeminjamanModels
    /// </summary>
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalians = new HashSet<Pengembalian>();
        }

        [Required(ErrorMessage = "ID Peminjaman tidak boleh kosong")]
        public int IdPeminjamaan { get; set; }
        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjamaan { get; set; }
        [Required(ErrorMessage = "ID Kendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "ID Customer tidak boleh kosong")]
        public int? IdCustomer { get; set; }
        [Required(ErrorMessage = "ID Jaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }
        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        public int? Biaya { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual Jaminan IdJaminanNavigation { get; set; }
        public virtual Kendaraan IdKendaraanNavigation { get; set; }
        public virtual ICollection<Pengembalian> Pengembalians { get; set; }
    }
}
