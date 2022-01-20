namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHP_CATEGORY_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHP_CATEGORY_tbl()
        {
            SHOP_tbl = new HashSet<SHOP_tbl>();
        }

        [Key]
        public int SHP_CATEGORY_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SHP_CATEGORY_NAME { get; set; }
        [Required]
        [StringLength(50)]
        public string SHP_CATEGORY_ICON { get; set; }
        [Required]
        [StringLength(50)]
        public string SHP_CATEGORY_STATUS{ get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOP_tbl> SHOP_tbl { get; set; }
    }
}
