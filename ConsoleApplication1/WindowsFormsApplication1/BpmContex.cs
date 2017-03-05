namespace WindowsFormsApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BpmContex : DbContext
    {
        public BpmContex()
            : base("name=BpmContex")
        {
        }

        public virtual DbSet<dispatcher> dispatchers { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<transition> transitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<state>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .HasMany(e => e.dispatchers)
                .WithOptional(e => e.state)
                .HasForeignKey(e => e.CurrentStateID);

            modelBuilder.Entity<state>()
                .HasMany(e => e.dispatchers1)
                .WithOptional(e => e.state1)
                .HasForeignKey(e => e.NextStateID);

            modelBuilder.Entity<transition>()
                .Property(e => e.TransitionName)
                .IsUnicode(false);
        }
    }
}
