namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOPKEEPER_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHOPKEEPER_tbl()
        {
            S_FEEDBACK_tbl = new HashSet<S_FEEDBACK_tbl>();
            SHOP_tbl = new HashSet<SHOP_tbl>();
        }

        [Key]
        public int SHOPKEEPER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOPKEEPER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOPKEEPER_CONTACT { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOPKEEPER_CNIC { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOPKEEPER_EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string SHOPKEEPER_PASSWORD { get; set; }

        [Required]
        [StringLength(300)]
        public string SHOPKEEPER_ADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_FEEDBACK_tbl> S_FEEDBACK_tbl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOP_tbl> SHOP_tbl { get; set; }
    }
}
