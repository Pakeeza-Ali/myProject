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
            P_CATEGORY_tbl = new HashSet<P_CATEGORY_tbl>();
            ORDER_tbl = new HashSet<ORDER_tbl>(); 
           
        }

        [Key]
        public int SHOP_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOP_NAME { get; set; }
        
       
        [StringLength(500)]
        public string SHOP_IMAGE { get; set; }
        

        [Required]
        [StringLength(300)]
        public string SHOP_ADDRESS { get; set; }

       

        [Required]
        [StringLength(50)]
        public string SHOP_RENT { get; set; }

        public int SHOPKEEPER_FID { get; set; }
        public int SHP_CATEGORY_FID { get; set; }

        public int CITY_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_CATEGORY_tbl> P_CATEGORY_tbl { get; set; }

        public virtual CITY_tbl CITY_tbl { get; set; }

        public virtual SHP_CATEGORY_tbl SHP_CATEGORY_tbl { get; set; }
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_tbl> ORDER_tbl { get; set; }

        public virtual SHOPKEEPER_tbl SHOPKEEPER_tbl { get; set; }

        
    }
}
