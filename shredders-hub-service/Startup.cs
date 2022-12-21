using AutoMapper;
using shredders_hub_application;
using shredders_hub_repositories.InMemoryRepositories;

namespace shredders_hub_service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
            });

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            
            services.AddSingleton(mapper);
            services.AddControllers();
            services.AddSingleton<IShreddersHubRepository, ShreddersHubRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors();
            app.UseRouting();
            
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}