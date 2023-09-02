using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SSS.Repository.dbModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SSS.Repository
{
    public partial  class SSSDatacontext:DbContext
    {
        private readonly ILogger<SSSDatacontext> logger;
        public SSSDatacontext( DbContextOptions options, ILogger<SSSDatacontext> logger) :base(options)
        {
            this.logger = logger;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Boat> Boats { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }

}
