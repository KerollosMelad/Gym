using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebGYM.Models;
using WebGYM.Shared;

namespace WebGYM.Concrete
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 1,
                RoleName = "admin",
                Status = true
            });


            modelBuilder.Entity<Users>().HasData(new Users
            {
                UserId = 1,
                UserName = "admin",
                EmailId = "some-admin-email@nonce.fake",
                Password = EncryptionLibrary.EncryptText("admin"),
                Status = true,
                FullName = "kerollos",
                CreatedDate = new DateTime(),
                Contactno = "212121212",
            });

            modelBuilder.Entity<UsersInRoles>().HasData(new UsersInRoles
            {
                UserRolesId = 1,
                UserId = 1,
                RoleId = 1
            });
        }

        public DbSet<SchemeMaster> SchemeMaster { get; set; }
        public DbSet<PeriodTB> PeriodTb { get; set; }
        public DbSet<PlanMaster> PlanMaster { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<MemberRegistration> MemberRegistration { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersInRoles> UsersInRoles { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
