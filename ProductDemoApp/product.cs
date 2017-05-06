namespace ProductDemoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long product_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string description { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2147483647)]
        public string price { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2147483647)]
        public string image { get; set; }
    }
}
