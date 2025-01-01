namespace DAL.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheHocVien")]
    public partial class TheHocVien
    {
        [Key]
        [StringLength(10)]
        public string ID_TheHV { get; set; }

        [StringLength(10)]
        public string ID_HocVien { get; set; }

        [StringLength(10)]
        public string ID_Lop { get; set; }

        [StringLength(10)]
        public string ID_HLV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        public virtual HocVien HocVien { get; set; }

        public virtual HuanLuyenVien HuanLuyenVien { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
