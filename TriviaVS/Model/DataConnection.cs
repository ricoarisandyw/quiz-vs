using System.Data.Entity;

namespace TriviaVS.Model
{
	public class DataConnection : DbContext
	{
		public DataConnection() :base("Data Source=DESKTOP-VG0DTGA\\KULIAH;Initial Catalog=trivia;Integrated Security=True")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public virtual DbSet<User> Users { set; get; }
		public virtual DbSet<Question> Questions { set; get; }
		public virtual DbSet<Friend> Friends { set; get; }
		public virtual DbSet<Category> Categories { set; get; }
		public virtual DbSet<Report> Reports { set; get; }
		public virtual DbSet<Score> Scores{ set; get; }
	}
}
