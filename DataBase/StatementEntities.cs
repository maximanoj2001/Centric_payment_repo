using Microsoft.EntityFrameworkCore;

namespace Centric_Payment_API.DataBase
{
    public class StatementEntities : DbContext
    {
        public StatementEntities(DbContextOptions<StatementEntities> options) : base(options)
        {

        }
        public virtual DbSet<StatementHistoryRecord> StatementHistoryRecord { get; set; }
        public virtual DbSet<HistoricalStatement> historicalStatement { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatementHistoryRecord>()
                   .HasNoKey();

            modelBuilder.Entity<HistoricalStatement>()
                   .HasNoKey();

            modelBuilder.Entity<StatementHistoryRecord>()
          .HasKey(p => p.recorded_id); // Set RecordedId as the primary key

            modelBuilder.Entity<StatementHistoryRecord>()
                .Property(p => p.recorded_id)
                .ValueGeneratedOnAdd();


        }
    }
}