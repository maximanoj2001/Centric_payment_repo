using Centric_Payment_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;
using Centric_Payment_API.DataBase;

namespace Centric_Payment_API.DataBase
{
    public class PaymentEntities : DbContext
    {
        public PaymentEntities(DbContextOptions<PaymentEntities> options) : base(options)
        {

        }
        public virtual DbSet<HistoricalPayments> paymentHistory { get; set; }
        public virtual DbSet<PaymentHistoryRecord>? PaymentHistoryRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentHistoryRecord>()
                   .HasNoKey();

            modelBuilder.Entity<HistoricalPayments>()
                   .HasNoKey();
            
            modelBuilder.Entity<PaymentHistoryRecord>()
          .HasKey(p => p.recorded_id); // Set RecordedId as the primary key

            modelBuilder.Entity<PaymentHistoryRecord>()
                .Property(p => p.recorded_id)
                .ValueGeneratedOnAdd();
        }


    }

}
