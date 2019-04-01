namespace MeetingManagementClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MeetingRoom")]
    public partial class MeetingRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MeetingRoom()
        {
            Meetings = new HashSet<Meeting>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomName { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        public int NumberOfSeats { get; set; }

        public bool HasPhone { get; set; }

        public bool HasProjector { get; set; }

        public bool Disabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}
