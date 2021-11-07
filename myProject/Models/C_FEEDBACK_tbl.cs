namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_FEEDBACK_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_FEEDBACK_ID { get; set; }

        public int CUSTOMER_FID { get; set; }

        [Required]
        [StringLength(300)]
        public string C_FEEDBACK_DESCRIPTION { get; set; }

        [Column(TypeName = "date")]
        public DateTime C_FEEDBACK_DATE { get; set; }

        public virtual CUSTOMER_tbl CUSTOMER_tbl { get; set; }
    }
}
