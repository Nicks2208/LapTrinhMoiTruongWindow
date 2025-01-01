namespace DAL.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            HocViens = new HashSet<HocVien>();
            TheHocViens = new HashSet<TheHocVien>();
        }

        [Key]
        [StringLength(10)]
        public string ID_Lop { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        [StringLength(10)]
        public string ID_HLV { get; set; }

        [StringLength(50)]
        public string ThoiGianHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocVien> HocViens { get; set; }

        public virtual HuanLuyenVien HuanLuyenVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheHocVien> TheHocViens { get; set; }
    }
}
