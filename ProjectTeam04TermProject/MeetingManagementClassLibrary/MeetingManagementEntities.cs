namespace MeetingManagementClassLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MeetingManagementEntities : DbContext
    {
        public MeetingManagementEntities()
            : base("name=MeetingManagementConnection")
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingRoom> MeetingRooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Groups)
                .Map(m => m.ToTable("GroupUser").MapLeftKey("GroupId").MapRightKey("UserId"));

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Meetings)
                .WithMany(e => e.Groups)
                .Map(m => m.ToTable("MeetingGroup").MapLeftKey("GroupId").MapRightKey("MeetingId"));

            modelBuilder.Entity<Meeting>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Meeting>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Meetings1)
                .Map(m => m.ToTable("MeetingUser").MapLeftKey("MeetingId").MapRightKey("UserId"));

            modelBuilder.Entity<MeetingRoom>()
                .HasMany(e => e.Meetings)
                .WithRequired(e => e.MeetingRoom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Meetings)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);
        }
    }
}
