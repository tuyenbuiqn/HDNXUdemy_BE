using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using HDNXUdemyAPI.Middlewares;
using HDNXUdemyAPI.ModelHelp;
using HDNXUdemyAPI.ProjectExtensisons;
using HDNXUdemyData.EntitiesContext;
using HDNXUdemyServices.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using System.Text.Json.Serialization;
using static HDNXUdemyAPI.ProjectExtensisons.ApplicationSwaggerExtension;

namespace HDNXUdemyAPI
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.

            // Add services to the container.
            HelperConstantsModel.LoadConfig(configuration);
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfigureOptions>();
            builder.Services.AddDbContext<ProjectContext>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.NullValueHandling = NullValueHandling.Include;
            });
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            builder.Services.AddSwaggerGen(options =>
            {
                options.IncludeXmlComments(xmlFilePath);
            });

            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new UrlSegmentApiVersionReader();
            }).AddApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;
            });
            builder.Services.AddSwashbuckleSwagger();
            builder.Services.AddApplicationServicesExtension();
            builder.Services.CustomerApplicationJWTExtension();
            builder.Services.AddCors(x =>
            {
                x.AddDefaultPolicy(polocy =>
                {
                    polocy.WithOrigins("http://localhost:4200", "http://localhost:53373")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });

            var app = builder.Build();

            var apiVersionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
            // Configure the HTTP request pipeline.
            var env = app.Environment;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwashbuckleSwagger(apiVersionProvider);
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseExceptionMiddleware();
            app.UseCors();
            app.UseRouting().UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });

            app.UseAuthorization();

            app.Run();
        }
    }
}