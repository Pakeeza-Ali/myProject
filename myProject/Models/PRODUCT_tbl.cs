namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUCT_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT_tbl()
        {
            C0RDER_DETAIL_tbl = new HashSet<C0RDER_DETAIL_tbl>();
        }

        [Key]
        public int PRODUCT_ID { get; set; }
        [NotMapped]
        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_NAME { get; set; }

        
        [StringLength(300)]
        public string PRODUCT_IMAGE { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_DESCRIPTION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PRODUCT_PURCHASEPRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PRODUCT_SALEPRICE { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_AVAILABILITY { get; set; }

        public int P_CATEGORY_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C0RDER_DETAIL_tbl> C0RDER_DETAIL_tbl { get; set; }

        public virtual P_CATEGORY_tbl P_CATEGORY_tbl { get; set; }
    }
}
