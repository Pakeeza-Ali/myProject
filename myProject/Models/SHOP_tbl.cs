namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOP_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHOP_tbl()
        {
            CATEGORY_tbl = new HashSet<CATEGORY_tbl>();
            ORDER_tbl = new HashSet<ORDER_tbl>();
        }

        [Key]
        public int SHOP_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOP_NAME { get; set; }

        [Required]
        [StringLength(300)]
        public string SHOP_ADDRESS { get; set; }

        public int FLOOR_FID { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOP_RENT { get; set; }

        public int SHOPKEEPER_FID { get; set; }

        public int CITY_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORY_tbl> CATEGORY_tbl { get; set; }

        public virtual CITY_tbl CITY_tbl { get; set; }

        public virtual FLOOR_tbl FLOOR_tbl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_tbl> ORDER_tbl { get; set; }

        public virtual SHOPKEEPER_tbl SHOPKEEPER_tbl { get; set; }
    }
}
