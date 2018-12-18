namespace Oto_Galeri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adres
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Sehir { get; set; }

        [Required]
        [StringLength(50)]
        public string Ilce { get; set; }

        [Required]
        [StringLength(500)]
        public string Aciklama { get; set; }

        public int MusteriId { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
