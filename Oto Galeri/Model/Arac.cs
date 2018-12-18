namespace Oto_Galeri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            AracOzellikler = new HashSet<AracOzellikler>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Plaka { get; set; }

        public int? MarkaId { get; set; }

        public int? ModelId { get; set; }

        public int RenkId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public bool? SatildiDurumu { get; set; }

        public int? SatısId { get; set; }

        public int? Kategoriıd { get; set; }

        public virtual AracKategori AracKategori { get; set; }

        public virtual AracRenk AracRenk { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual Model Model { get; set; }

        public virtual Satis Satis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracOzellikler> AracOzellikler { get; set; }
    }
}
