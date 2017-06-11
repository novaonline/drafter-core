using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DrafterCore.Models.Characters;
using DrafterCore.Models.Shows;
using DrafterCore.Models.Users;
using System.Linq;

namespace DrafterCore.Rules.Context
{
    public class DrafterContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterTransaction> CharacterTransactions { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<ShowRound> ShowRounds { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<UserCharacterAssignment> UserCharacterAssignments { get; set; }
        public DbSet<UserPermissionType> UserPermissionTypes { get; set; }
        public DbSet<UserCharacterPermission> UserCharacterPermissions { get; set; }
        public DbSet<UserShowPermission> UserShowPermissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string gets passed in by the project calling this lib
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // general rules
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.Name.Replace('.', '_').ToLower();

                foreach(var dateAwareProps in entityType.GetProperties().Where(x=>x.Name == "UTCAddDate" || x.Name == "UTCUpdateDate"))
                {
                    dateAwareProps.Relational().DefaultValueSql = "GETUTCDATE()";
                }
            }

            modelBuilder.Entity<Character>().HasIndex(c => new { c.ShowId, c.UTCAddDate });
            modelBuilder.Entity<Character>().HasIndex(c => new { c.UserId, c.UTCAddDate });
            modelBuilder.Entity<CharacterTransaction>().HasIndex(ct => ct.CharacterId);
            modelBuilder.Entity<Show>().HasIndex(s => s.UTCAddDate);
            modelBuilder.Entity<ShowRound>().HasIndex(sr => sr.ShowId);
            modelBuilder.Entity<User>().HasIndex(u => u.UTCAddDate);

        }
    }
}
