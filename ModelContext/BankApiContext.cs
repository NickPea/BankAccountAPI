using Microsoft.EntityFrameworkCore;
using BankApi.Models;

namespace BankApi.ModelContext
{

    public class BankApiContext : DbContext
    {

        public BankApiContext(DbContextOptions<BankApiContext> options) :
            base(options)
        { }
        //////////////////////////ENTITIES//////////////////////////////////
        public DbSet<Person> Persons { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        ///////////////////////MODEL-TUNING//////////////////////////////
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /////////////////GENERATED VALUES/////////////////////////////


            /////////////////EXPLICIT COLUMN TYPES FOR CURRENCY///////////
            modelBuilder.Entity<Account>()
                    .Property(a => a.Balance)
                    .HasColumnType("money");

            modelBuilder.Entity<Transaction>()
                    .Property(t => t.Amount)
                    .HasColumnType("money");


            /////////////////////////////////SEEDED DATA//////////////////////////////

            modelBuilder.Entity<Person>().HasData(
                new Person { FirstName = "sally", LastName = "sandra" }
            );

        }//end onmodelcreating

    }//end class/context
}//end namespace