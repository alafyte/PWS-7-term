using System.Data.Entity;

namespace Lab06
{
    public partial class StudentsModel : DbContext
    {
        public StudentsModel()
            : base("name=StudentsModel")
        {
        }

        public virtual DbSet<note> note { get; set; }
        public virtual DbSet<student> student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .HasMany(e => e.note)
                .WithOptional(e => e.student)
                .HasForeignKey(e => e.stud_id);
        }
    }
}
