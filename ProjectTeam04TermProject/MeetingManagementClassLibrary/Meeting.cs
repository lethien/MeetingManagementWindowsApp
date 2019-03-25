using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementClassLibrary
{
    class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public MeetingRoom MeetingRoom { get; set; }
        public string Notes { get; set; }
        public User CreatedBy { get; set; }
        public bool IsCanceled { get; set; }
        public List<User> InvitedUsers { get; set; }
        public List<Group> InvitedGroups { get; set; }
    }
}
