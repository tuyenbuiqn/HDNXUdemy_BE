using Newtonsoft.Json;
using NodaTime;

namespace HDNXUdemyModel.Base
{
    public class BaseModel
    {
        public long Id { get; set; }

        [JsonIgnore]
        public int CreateBy { get; set; }

        [JsonIgnore]
        public int UpdateBy { get; set; }

        [JsonIgnore]
        public LocalDateTime? CreateDate { get; set; }

        public int Status { get; set; }
    }
}