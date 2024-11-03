namespace GUI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            Diems = new HashSet<Diem>();
        }

        [StringLength(10)]
        public string MonHocID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMonHoc { get; set; }

        public int SoTinChi { get; set; }

        [Required]
        [StringLength(10)]
        public string KhoaID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
