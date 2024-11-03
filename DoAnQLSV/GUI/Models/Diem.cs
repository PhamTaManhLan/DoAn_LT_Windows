namespace GUI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        public int DiemID { get; set; }

        [Required]
        [StringLength(10)]
        public string SinhVienID { get; set; }

        [Required]
        [StringLength(10)]
        public string MonHocID { get; set; }

        public double? DiemSoHe4 { get; set; }

        public double? DiemSoHe10 { get; set; }

        [StringLength(2)]
        public string DiemChu { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
