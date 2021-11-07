namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDER_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_tbl()
        {
            C0RDER_DETAIL_tbl = new HashSet<C0RDER_DETAIL_tbl>();
        }

        [Key]
        public int ORDER_ID { get; set; }

        public DateTime ORDER_DATE { get; set; }

        public int SHOP_FID { get; set; }

        public int CUSTOMER_FID { get; set; }

        [Required]
        [StringLength(50)]
        public string ORDER_STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string PAYMENT_MODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C0RDER_DETAIL_tbl> C0RDER_DETAIL_tbl { get; set; }

        public virtual CUSTOMER_tbl CUSTOMER_tbl { get; set; }

        public virtual SHOP_tbl SHOP_tbl { get; set; }
    }
}
