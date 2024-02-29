using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Domain.Entities;

namespace TSKB.Case.Persistence.Context
{
    public class TSKBCaseDbContext : DbContext
    {
        //IoC container'da tanımla
        public TSKBCaseDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmans { get; set; }
    }
}
