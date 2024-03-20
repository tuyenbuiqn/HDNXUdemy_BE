using NodaTime;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HDNXUdemyData.Entities
{
    public class BaseEntities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("CreateDate")]
        public LocalDateTime CreateDate { get; set; }

        [Column("UpdateDate")]
        public LocalDateTime UpdateDate { get; set; }

        [Column("CreateBy")]
        public Guid CreateBy { get; set; }

        [Column("UpdateBy")]
        public Guid UpdateBy { get; set; }

        [Column("Status")]
        public int Status { get; set; }
    }
}