using Microsoft.EntityFrameworkCore;
using System;
using BankApi.Models;

namespace BankApi.ModelContext
{

    public class BankApiContext : DbContext
    {

        public BankApiContext(DbContextOptions<BankApiContext> options) :
            base(options)
        { }


        ///////////////DECLARED ENTITIES////////////////////
        public DbSet<Person> Persons { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }



        //////////////////MODEL//////////////////////////////
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////////////////////KEYS/////////////////////////
            modelBuilder.Entity<Transaction>()
                .HasKey(t => new { t.DateTime, t.AccountId });

            ///////////////////REQUIRED////////////////////////
            modelBuilder.Entity<Account>()
                .Property(a => a.PersonId)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.AccountId)
                .IsRequired();

            //////////////////////DEFAULTS///////////////////////
            modelBuilder.Entity<Transaction>()
                .Property(t => t.DateTime)
                .HasDefaultValue(DateTime.UtcNow);
            //Also used to date account creation if on
            //creation of an account a deposit must be made.

            /////////////////SEQUENCES///////////////////////////
            modelBuilder.HasSequence("AccountNumbers", schema: "shared")
                .StartsAt(100000000000000); //hundred trillion

            modelBuilder.Entity<Account>()
                .Property(a => a.AccountId)
                .HasDefaultValueSql("NEXT VALUE FOR shared.AccountNumbers");

            /////////////////EXPLICIT COLUMN TYPES///////////
            modelBuilder.Entity<Account>()
                    .Property(a => a.Balance)
                    .HasColumnType("money");

            modelBuilder.Entity<Transaction>()
                    .Property(t => t.Amount)
                    .HasColumnType("money");



        }//end onmodelcreating method

    }//end context class

}//end namespace