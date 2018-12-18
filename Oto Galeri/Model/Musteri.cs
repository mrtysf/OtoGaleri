namespace Oto_Galeri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Adres1 = new HashSet<Adres>();
            Satis = new HashSet<Satis>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal TcNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public decimal Tel { get; set; }

        public decimal Tel2 { get; set; }

        [Required]
        [StringLength(50)]
        public string BabaAdı { get; set; }

        [Required]
        [StringLength(50)]
        public string AnneAdı { get; set; }

        [Column(TypeName = "date")]
        public DateTime DogumTarih { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        
        [StringLength(500)]
        public string Foto { get; set; }

        [Required]
        [StringLength(500)]
        public string Adres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adres> Adres1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
