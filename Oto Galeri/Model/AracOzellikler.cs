namespace Oto_Galeri.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracOzellikler")]
    public partial class AracOzellikler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracOzellikler()
        {
            Arac = new HashSet<Arac>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        [StringLength(50)]
        public string YakıtTur { get; set; }

        public long? Kilometre { get; set; }

        [StringLength(50)]
        public string Vites { get; set; }

        [StringLength(50)]
        public string MotorHacmi { get; set; }

        [StringLength(50)]
        public string BeygirGucu { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [StringLength(50)]
        public string ModelYil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }
    }
}
