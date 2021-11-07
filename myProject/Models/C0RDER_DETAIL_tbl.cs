namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("0RDER_DETAIL_tbl")]
    public partial class C0RDER_DETAIL_tbl
    {
        [Key]
        public int ORDER_DETAIL_ID { get; set; }

        public int PRODUCT_FID { get; set; }

        [Required]
        [StringLength(50)]
        public string PRO_ORDER_QUANTIY { get; set; }

        public int ORDER_FID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PURCHASE_PRICE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SALE_PRICE { get; set; }

        public virtual ORDER_tbl ORDER_tbl { get; set; }

        public virtual PRODUCT_tbl PRODUCT_tbl { get; set; }
    }
}
