namespace quanlynhansu_hahaha.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            THANNHANs = new HashSet<THANNHAN>();
        }

        public int ID { get; set; }

        public string MANV { get; set; }

        public int? PHONGBANID { get; set; }

        public int? CHUCVUID { get; set; }

        public string HOTEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        public string NOISINH { get; set; }

        public string MATKHAU { get; set; }

        public string TAIKHOAN { get; set; }

        public int? DANTOCID { get; set; }

        public int? TONGIAOID { get; set; }

        public int? TRINHDOHOCVANID { get; set; }

        public int? NGOAINGUID { get; set; }

        public double? LUONG { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual DANTOC DANTOC { get; set; }

        public virtual NGOAINGU NGOAINGU { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        public virtual TONGIAO TONGIAO { get; set; }

        public virtual TRINHDOHOCVAN TRINHDOHOCVAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANNHAN> THANNHANs { get; set; }
    }
}
