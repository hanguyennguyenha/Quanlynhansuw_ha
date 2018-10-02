namespace quanlynhansu_hahaha.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGBAN")]
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? IDCAPTREN { get; set; }

        public DateTime? NGAYTHANHLAP { get; set; }

        public string MOTAPHONGBAN { get; set; }

        public string DIADIEM { get; set; }

        [StringLength(50)]
        public string KIHIEUPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
