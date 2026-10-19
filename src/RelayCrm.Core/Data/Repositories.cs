using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RelayCrm.Data
{
	/// <summary>
	/// Store-independent access to one aggregate.
	/// </summary>
	public interface IRepository<T> where T : Entity
	{
		/// <summary>Queryable for reading; tracked when the caller intends to change the results.</summary>
		IQueryable<T> Query(bool tracking = false);
		T Get(int id);
		void Add(T entity);
		void Remove(T entity);
	}

	/// <summary>
	/// One unit of work: the repositories of all aggregates over a single store session.
	/// Create one per operation and dispose it.
	/// </summary>
	public interface IUnitOfWork : IDisposable
	{
		IRepository<User> Users { get; }
		IRepository<Company> Companies { get; }
		IRepository<Contact> Contacts { get; }
		IRepository<Pipeline> Pipelines { get; }
		IRepository<Stage> Stages { get; }
		IRepository<Deal> Deals { get; }
		IRepository<Activity> Activities { get; }
		IRepository<CrmTask> Tasks { get; }
		IRepository<Tag> Tags { get; }
		int Save();
	}

	internal class EfRepository<T> : IRepository<T> where T : Entity
	{
		private readonly RelayDbContext db;

		public EfRepository(RelayDbContext db)
		{
			this.db = db;
		}

		public IQueryable<T> Query(bool tracking = false)
		{
			return tracking ? this.db.Set<T>() : this.db.Set<T>().AsNoTracking();
		}

		public T Get(int id)
		{
			return this.db.Set<T>().Find(id);
		}

		public void Add(T entity)
		{
			this.db.Set<T>().Add(entity);
		}

		public void Remove(T entity)
		{
			this.db.Set<T>().Remove(entity);
		}
	}

	/// <summary>
	/// EF Core implementation of <see cref="IUnitOfWork"/>.
	/// </summary>
	public class EfUnitOfWork : IUnitOfWork
	{
		private readonly RelayDbContext db = new RelayDbContext();

		public EfUnitOfWork()
		{
			this.Users = new EfRepository<User>(this.db);
			this.Companies = new EfRepository<Company>(this.db);
			this.Contacts = new EfRepository<Contact>(this.db);
			this.Pipelines = new EfRepository<Pipeline>(this.db);
			this.Stages = new EfRepository<Stage>(this.db);
			this.Deals = new EfRepository<Deal>(this.db);
			this.Activities = new EfRepository<Activity>(this.db);
			this.Tasks = new EfRepository<CrmTask>(this.db);
			this.Tags = new EfRepository<Tag>(this.db);
		}

		public IRepository<User> Users { get; }
		public IRepository<Company> Companies { get; }
		public IRepository<Contact> Contacts { get; }
		public IRepository<Pipeline> Pipelines { get; }
		public IRepository<Stage> Stages { get; }
		public IRepository<Deal> Deals { get; }
		public IRepository<Activity> Activities { get; }
		public IRepository<CrmTask> Tasks { get; }
		public IRepository<Tag> Tags { get; }

		public int Save()
		{
			return this.db.SaveChanges();
		}

		public void Dispose()
		{
			this.db.Dispose();
		}
	}

	/// <summary>
	/// Creates units of work; swap <see cref="Factory"/> to change the store.
	/// </summary>
	public static class Store
	{
		public static Func<IUnitOfWork> Factory { get; set; } = () => new EfUnitOfWork();

		public static IUnitOfWork Open()
		{
			return Factory();
		}
	}
}
