using Microsoft.EntityFrameworkCore;

namespace Centric_Payment_API.DataBase
{
    public class UsageEntities : DbContext
    {

        public UsageEntities(DbContextOptions<UsageEntities> options) : base(options)
        {

        }
        public virtual DbSet<UsageHistoryRecord> usageHistory { get; set; }
        public virtual DbSet<UsageHistorySource> usageHistorySource { get; set; }
        public virtual DbSet<HistoricalUsage> historicalUsage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsageHistoryRecord>()
                   .HasNoKey();

            modelBuilder.Entity<UsageHistorySource>()
                   .HasNoKey();

            modelBuilder.Entity<HistoricalUsage>()
                   .HasNoKey();


            modelBuilder.Entity<UsageHistoryRecord>()
          .HasKey(p => p.recorded_id); // Set RecordedId as the primary key

            modelBuilder.Entity<UsageHistoryRecord>()
                .Property(p => p.recorded_id)
                .ValueGeneratedOnAdd();
        }
       

    }
}

