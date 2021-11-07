namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CITY_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITY_tbl()
        {
            SHOP_tbl = new HashSet<SHOP_tbl>();
        }

        [Key]
        public int CITY_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CITY_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string POSTAL_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOP_tbl> SHOP_tbl { get; set; }
    }
}
