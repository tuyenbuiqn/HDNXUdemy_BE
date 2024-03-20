using HDNXUdemyData.Entities;
using HDNXUdemyModel.Constant;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace HDNXUdemyData.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            LocalDateTime dateTime = LocalDateTime.FromDateTime(DateTime.UtcNow);
            modelBuilder.Entity<CategoryEntities>().HasData(
                new CategoryEntities { Id = new Guid(), Name = "Thiết kế cơ khí", CreateBy = new Guid(), CreateDate = dateTime, Status = (int)EStatus.Active, UpdateBy = new Guid(), UpdateDate = dateTime },
                new CategoryEntities { Id = new Guid(), Name = "Lập trình CNC", CreateBy = new Guid(), CreateDate = dateTime, Status = (int)EStatus.Active, UpdateBy = new Guid(), UpdateDate = dateTime },
                new CategoryEntities { Id = new Guid(), Name = "Vận hành máy CNC", CreateBy = new Guid(), CreateDate = dateTime, Status = (int)EStatus.Active, UpdateBy = new Guid(), UpdateDate = dateTime }
    );
        }
    }
}