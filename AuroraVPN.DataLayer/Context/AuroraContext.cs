using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuroraVPN.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuroraVPN.DataLayer.Context
{
    public class AuroraContext : DbContext
    {
        public AuroraContext(DbContextOptions<AuroraContext> options) : base(options)
        {

        }

        #region Newsletter

        public DbSet<Newsletter> Newsletter { get; set; }

        #endregion
    }
}
