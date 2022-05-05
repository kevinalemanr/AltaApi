using AltaApi.EFCore.EntityConfiguration;
using AltaApi.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaApi.EFCore.DataContext
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ApiKeyConfiguration());
            modelBuilder.ApplyConfiguration(new HeartBeatInitiateConfiguration());
            modelBuilder.ApplyConfiguration(new RequestInboxConfiguration());
            modelBuilder.ApplyConfiguration(new RequestInitiateConfiguration());
            modelBuilder.ApplyConfiguration(new SaveFromPrimeConfiguration());
            modelBuilder.ApplyConfiguration(new SaveToPrimeConfiguration());


        }

        public DbSet<Users> User { get; set; }
        public DbSet<ApiKeys> ApiKey { get; set; }
        public DbSet<HeartBeatInitiate> HeartBeatInitiates {get; set;}
        public DbSet<RequestInbox> RequestsInbox { get; set; }
        public DbSet<RequestInitiate> RequestInitiates {get; set; }
        public DbSet<SaveFromPrime> SaveFromPrimes {get; set;} 
        public DbSet<SaveToPrime> SaveToPrimes {get; set;}



    }
}
