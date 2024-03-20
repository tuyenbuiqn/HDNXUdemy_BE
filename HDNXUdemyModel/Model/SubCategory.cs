using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class SubCategoryModel : BaseModel
    {
        public string? Name { get; set; }

        public Guid IdCategory { get; set; }
    }
}