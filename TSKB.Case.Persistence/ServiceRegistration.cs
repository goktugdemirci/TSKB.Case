using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Abstractions;
using TSKB.Case.Application.Repositories;
using TSKB.Case.Persistence.Concretes;
using TSKB.Case.Persistence.Context;
using TSKB.Case.Persistence.Mapping;
using TSKB.Case.Persistence.Repositories;

namespace TSKB.Case.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<TSKBCaseDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IPersonelService, PersonelService>();
            services.AddTransient<IDepartmanService, DepartmanService>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }
    }
}
