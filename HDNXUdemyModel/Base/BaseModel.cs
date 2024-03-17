using Newtonsoft.Json;
using NodaTime;

namespace HDNXUdemyModel.Base
{
    public class BaseModel
    {
        public long Id { get; set; }

        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }

        public LocalDateTime? CreateDate { get; set; }

        public LocalDateTime? UpdateDate { get; set; }

        public int Status { get; set; }
    }
}