namespace myProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_FEEDBACK_tbl
    {
        [Key]
        public int S_FEEDBACK_ID { get; set; }

        public int SHOPKEEPER_FID { get; set; }

        [Required]
        [StringLength(300)]
        public string S_FEEDBACK_DESCRIPTION { get; set; }

        [Column(TypeName = "date")]
        public DateTime S_FEEDBACK_DATE { get; set; }

        public virtual SHOPKEEPER_tbl SHOPKEEPER_tbl { get; set; }
    }
}
