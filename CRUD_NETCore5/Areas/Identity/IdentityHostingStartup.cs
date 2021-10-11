using System;
using AERHNIC.Areas.Identity.Data;
using AERHNIC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AERHNIC.Areas.Identity.IdentityHostingStartup))]
namespace AERHNIC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AERHNICContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AERHNICContextConnection")));

                services.AddDefaultIdentity<AERHNICUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AERHNICContext>();
            });
        }
    }
}