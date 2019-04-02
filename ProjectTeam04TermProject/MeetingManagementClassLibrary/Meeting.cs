namespace MeetingManagementClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meeting")]
    public partial class Meeting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meeting()
        {
            Groups = new HashSet<Group>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime From { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime To { get; set; }

        public int MeetingRoomId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Notes { get; set; }

        public int CreatedBy { get; set; }

        public bool Canceled { get; set; }

        public virtual User User { get; set; }

        public virtual MeetingRoom MeetingRoom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
