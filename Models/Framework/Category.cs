using System.ComponentModel;

namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        [DisplayName("Ten danh muc")]
        [Required(ErrorMessage = "Ban chua nhap \"Ten danh muc\"")]
        public string Name { get; set; }

        [StringLength(50)]
        [DisplayName("Tieu de SEO")]
        public string Alias { get; set; }

        [DisplayName("Danh muc cha")]
        public int? ParentID { get; set; }

        [DisplayName("Ngay tao")]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("Thu tu")]
        //[Range(0,Int32.MaxValue)]
        public int? Order { get; set; }

        [DisplayName("Trang thai")]
        public bool? Status { get; set; }
    }
}
