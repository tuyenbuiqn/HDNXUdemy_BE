using Newtonsoft.Json;
using NodaTime;

namespace HDNXUdemyModel.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public Guid CreateBy { get; set; }

        public Guid UpdateBy { get; set; }

        public LocalDateTime? CreateDate { get; set; }

        public LocalDateTime? UpdateDate { get; set; }

        public int Status { get; set; }
    }
}