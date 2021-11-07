namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CATEGORY_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORY_tbl()
        {
            PRODUCT_tbl = new HashSet<PRODUCT_tbl>();
        }

        [Key]
        public int CATEGORY_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CATEGORY_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CRTEGORY_STATUS { get; set; }

        public int SHOP_FID { get; set; }

        public virtual SHOP_tbl SHOP_tbl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_tbl> PRODUCT_tbl { get; set; }
    }
}
