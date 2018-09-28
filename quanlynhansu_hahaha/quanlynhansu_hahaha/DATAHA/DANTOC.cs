namespace quanlynhansu_hahaha.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANTOC")]
    public partial class DANTOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANTOC()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
