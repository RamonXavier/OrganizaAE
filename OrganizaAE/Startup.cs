using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using OrganizaAE.Feactures.Mounth.Service;
using OrganizaAE.Feactures.Payment.Service;
using OrganizaAE.Feactures.Social.Service;
using OrganizaAE.Feactures.User.Service;
using OrganizaAE.Infrastructure;
using OrganizaAE.Infrastructure.Mounth;
using OrganizaAE.Infrastructure.Payment;
using OrganizaAE.Infrastructure.Social;
using OrganizaAE.Infrastructure.User;
using OrganizaAE.Models.User;
using AutoMapper;
using OrganizaAE.Profiles;

namespace OrganizaAE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrganizaAE", Version = "v1" });
            });

            services.AddDbContext<OrganizaAeDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));

            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMounthRepository, MounthRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMounthService, MounthService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ISocialService, SocialService>();

            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProfilesAutomaper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrganizaAE v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
