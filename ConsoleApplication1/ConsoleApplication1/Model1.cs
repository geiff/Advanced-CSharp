namespace ConsoleApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Dispatchers> Dispatchers { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Trasitions> Trasitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<States>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<States>()
                .HasMany(e => e.Dispatchers)
                .WithRequired(e => e.States)
                .HasForeignKey(e => e.CurrentStateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Dispatchers1)
                .WithRequired(e => e.States1)
                .HasForeignKey(e => e.NextStateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trasitions>()
                .Property(e => e.Trasition)
                .IsFixedLength();

            modelBuilder.Entity<Trasitions>()
                .HasMany(e => e.Dispatchers)
                .WithRequired(e => e.Trasitions)
                .HasForeignKey(e => e.TransitionID)
                .WillCascadeOnDelete(false);
        }
    }
}
