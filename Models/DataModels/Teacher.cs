using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JinKeTang.Models.DataModels
{
    /*
     * 1.修改类中字段的属性
     * 2.add-migration modify_teacher
     * 3.update-database
     */
    [Table("tb_teacher")]
    public class Teacher
    {

        [Column("id", Order = 1)]
        [Key]
        public int Id { get; set; }

        [Column("gh", Order = 2)]
        [StringLength(12)]
        public string GH { get; set; }

        [Column("xm", Order = 3)]
        [StringLength(10)]
        public string XM { get; set; }

        [Column("xb", Order = 5)]
        [StringLength(1)]
        public string XB { get; set; }

        [Column("mm", Order = 4)]
        [StringLength(32)]
        public string MM { get; set; }

    }
}
