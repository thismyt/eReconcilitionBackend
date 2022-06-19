using eReconcilition.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.DataAccess.Concreate.EntityFramework.Context
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = MERTVELI; Database = eReconcilitionDB; Integrated Security = true");
        }

        public DbSet<AccountReconcilitaionDetail> AccountReconcilitaionDetails { get; set; }
        public DbSet<AccountReconcilition> AccountReconcilitions { get; set; }
        public DbSet<BaBsReconcilition> BaBsReconcilitions { get; set; }
        public DbSet<BaBsReconcilitionDetail> BaBsReconcilitionDetails { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyAccount> CurrencyAccounts { get; set; }
        public DbSet<MailParameter> MailParameters { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
