namespace quanlynhansu_hahaha.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANNHAN")]
    public partial class THANNHAN
    {
        [Key]
        public int IDTN { get; set; }

        public string HOTEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        public string QUANHEGDID { get; set; }

        public int? NHANVIENID { get; set; }

        [StringLength(50)]
        public string MATN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
