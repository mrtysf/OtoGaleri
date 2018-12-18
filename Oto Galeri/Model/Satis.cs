namespace Oto_Galeri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satis()
        {
            Arac = new HashSet<Arac>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int MusteriId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        public decimal Fiyat { get; set; }

        [Required]
        [StringLength(50)]
        public string OdemeTur { get; set; }

        [Required]
        [StringLength(500)]
        public string Aciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
