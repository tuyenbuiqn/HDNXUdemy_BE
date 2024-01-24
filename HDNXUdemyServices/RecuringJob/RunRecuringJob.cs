using Hangfire;
using HDNXUdemyModel.Base;
using HDNXUdemyServices.IServices;

namespace HDNXUdemyServices.RecuringJob
{
    public static class RunRecuringJob
    {
        public static void RunAutoRecuringJob(RedisConnect configuration)
        {
            // RecurringJob.AddOrUpdate<IUploadFileVideoToServer>("Convert_Main_Video_To_Stream_Video", (convert) => convert.ConvertVideoToStreamFile(), configuration.ScronJobSetting);
        }
    }
}