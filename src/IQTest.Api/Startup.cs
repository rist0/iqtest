using System;
using System.IO;
using System.Text;
using AutoMapper;
using IQTest.Api.Helpers;
using IQTest.Api.Services;
using IQTest.Core.Interfaces;
using IQTest.Data;
using IQTest.Data.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace IQTest.Api
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
            services.AddAutoMapper(typeof(Startup));

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"))
                    .EnableSensitiveDataLogging();
            });

            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.Configure<JwtSettingsOptions>(Configuration.GetSection(JwtSettingsOptions.JwtSettings));
            services.AddSingleton<IEmailSender, EmailSender>();
            services.Configure<SendGridOptions>(Configuration.GetSection(SendGridOptions.SendGridSettings));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    //ValidateIssuer = true,
                    //ValidIssuer = Configuration["JwtSettings:Issuer"],
                    //ValidateAudience = true,
                    //ValidAudience = Configuration["JwtSettings:Audience"],
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["JwtSettings:Secret"])),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero // infinite for now
                };
            });

            services.AddCors(o =>
            {
                o.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyHeader();
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var resourcePath = Path.Combine(env.ContentRootPath, @"Resources");
            if (!Directory.Exists(resourcePath))
                Directory.CreateDirectory(resourcePath);
            
            //app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(resourcePath),
                RequestPath = new PathString("/Resources")
            });

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
