using System;
using Microsoft.EntityFrameworkCore;

namespace RelayCrm.Data
{
	/// <summary>
	/// EF Core context of Relay CRM, stored in the SQLite file relay.db.
	/// </summary>
	public class RelayDbContext : DbContext
	{
		/// <summary>
		/// Full path of the database file; set once at startup.
		/// </summary>
		public static string DatabasePath { get; set; } = "relay.db";

		public DbSet<User> Users { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Pipeline> Pipelines { get; set; }
		public DbSet<Stage> Stages { get; set; }
		public DbSet<Deal> Deals { get; set; }
		public DbSet<Activity> Activities { get; set; }
		public DbSet<CrmTask> Tasks { get; set; }
		public DbSet<Tag> Tags { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=" + DatabasePath);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// SQLite has no decimal type: store money as double so it can be summed and sorted in SQL.
			modelBuilder.Entity<Company>().Property(c => c.AnnualRevenue).HasConversion<double>();
			modelBuilder.Entity<Deal>().Property(d => d.Amount).HasConversion<double>();

			modelBuilder.Entity<Contact>().HasIndex(c => c.Email);
			modelBuilder.Entity<Deal>().HasIndex(d => d.StageId);
			modelBuilder.Entity<Activity>().HasIndex(a => a.Date);
			modelBuilder.Entity<CrmTask>().HasIndex(t => t.DueDate);

			modelBuilder.Entity<Contact>().HasOne(c => c.Company).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Deal>().HasOne(d => d.Company).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Deal>().HasOne(d => d.PrimaryContact).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Activity>().HasOne(a => a.Contact).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Activity>().HasOne(a => a.Company).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Activity>().HasOne(a => a.Deal).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<CrmTask>().HasOne(t => t.Contact).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<CrmTask>().HasOne(t => t.Company).WithMany().OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<CrmTask>().HasOne(t => t.Deal).WithMany().OnDelete(DeleteBehavior.SetNull);
		}

		public override int SaveChanges()
		{
			var now = DateTime.Now;
			foreach (var entry in this.ChangeTracker.Entries<Entity>())
			{
				if (entry.State == EntityState.Added)
				{
					if (entry.Entity.CreatedAt == default)
						entry.Entity.CreatedAt = now;
					entry.Entity.UpdatedAt = now;
				}
				else if (entry.State == EntityState.Modified)
					entry.Entity.UpdatedAt = now;
			}
			return base.SaveChanges();
		}
	}
}
