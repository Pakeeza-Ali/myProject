namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUSTOMER_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER_tbl()
        {
            C_FEEDBACK_tbl = new HashSet<C_FEEDBACK_tbl>();
            ORDER_tbl = new HashSet<ORDER_tbl>();
        }

        [Key]
        public int CUSTOMER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_AGE { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_CNIC { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_CONTACT { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_PASSWORD { get; set; }

        [Required]
        [StringLength(300)]
        public string CUSTOMER_ADDRESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_FEEDBACK_tbl> C_FEEDBACK_tbl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_tbl> ORDER_tbl { get; set; }
    }
}
