using System;

namespace RelayCrm.Data
{
	/// <summary>
	/// Base class of all stored records.
	/// </summary>
	public abstract class Entity
	{
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}

	public enum UserRole { Admin, Manager, Sales }

	public enum LifecycleStage { Lead, Prospect, Customer, Churned }

	public enum ActivityType { Call, Email, Meeting, Note }

	public enum TaskPriority { Low, Normal, High }

	public enum CrmTaskStatus { Open, Done }

	public class User : Entity
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public UserRole Role { get; set; }
		/// <summary>Avatar colour as #RRGGBB.</summary>
		public string AvatarColor { get; set; }
		public bool Active { get; set; } = true;

		public string Initials => Text.Initials(this.Name);
	}

	public class Company : Entity
	{
		public string Name { get; set; }
		public string Industry { get; set; }
		/// <summary>Size band, e.g. "51-200".</summary>
		public string Size { get; set; }
		public string Website { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public decimal AnnualRevenue { get; set; }
		/// <summary>Comma separated tag names.</summary>
		public string Tags { get; set; }
		public int? OwnerId { get; set; }
		public User Owner { get; set; }
	}

	public class Contact : Entity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int? CompanyId { get; set; }
		public Company Company { get; set; }
		public LifecycleStage Stage { get; set; }
		public string LeadSource { get; set; }
		/// <summary>Comma separated tag names.</summary>
		public string Tags { get; set; }
		public int? OwnerId { get; set; }
		public User Owner { get; set; }
		public DateTime? LastContacted { get; set; }

		public string FullName => (this.FirstName + " " + this.LastName).Trim();
	}

	public class Pipeline : Entity
	{
		public string Name { get; set; }
	}

	public class Stage : Entity
	{
		public int PipelineId { get; set; }
		public Pipeline Pipeline { get; set; }
		public string Name { get; set; }
		public int Order { get; set; }
		/// <summary>Win probability in percent (0-100).</summary>
		public int Probability { get; set; }
		public bool IsWon { get; set; }
		public bool IsLost { get; set; }
	}

	public class Deal : Entity
	{
		public string Title { get; set; }
		public int? CompanyId { get; set; }
		public Company Company { get; set; }
		public int? PrimaryContactId { get; set; }
		public Contact PrimaryContact { get; set; }
		public decimal Amount { get; set; }
		public string Currency { get; set; } = "USD";
		public int StageId { get; set; }
		public Stage Stage { get; set; }
		public DateTime ExpectedCloseDate { get; set; }
		/// <summary>Win probability in percent (0-100).</summary>
		public int Probability { get; set; }
		public int? OwnerId { get; set; }
		public User Owner { get; set; }
		public string LostReason { get; set; }
		public DateTime? ClosedDate { get; set; }
		/// <summary>Position of the card inside its stage column.</summary>
		public int BoardOrder { get; set; }
	}

	public class Activity : Entity
	{
		public ActivityType Type { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		/// <summary>Duration in minutes.</summary>
		public int Duration { get; set; }
		public int? ContactId { get; set; }
		public Contact Contact { get; set; }
		public int? CompanyId { get; set; }
		public Company Company { get; set; }
		public int? DealId { get; set; }
		public Deal Deal { get; set; }
		public int? UserId { get; set; }
		public User User { get; set; }
	}

	public class CrmTask : Entity
	{
		public string Title { get; set; }
		public DateTime DueDate { get; set; }
		public TaskPriority Priority { get; set; } = TaskPriority.Normal;
		public CrmTaskStatus Status { get; set; } = CrmTaskStatus.Open;
		public int? ContactId { get; set; }
		public Contact Contact { get; set; }
		public int? CompanyId { get; set; }
		public Company Company { get; set; }
		public int? DealId { get; set; }
		public Deal Deal { get; set; }
		public int? AssigneeId { get; set; }
		public User Assignee { get; set; }
	}

	public class Tag : Entity
	{
		public string Name { get; set; }
	}
}
