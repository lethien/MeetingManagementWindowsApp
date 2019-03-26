using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Group
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public Boolean Disabled { get; set; }
    }

    public class Meeting
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Notes { get; set; }
        public string CreatedBY { get; set; }
        public int MeetingRoomID { get; set; }
        public Boolean Canceled { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public Boolean Disabled { get; set; }
    }

    public class MeetingRoom
    {
        public int ID { get; set;}
        public string RoomName { get; set; }
        public string Location { get; set; }
        public string NumberOfSeats { get; set;}
        public Boolean HasPhone { get; set; }
        public Boolean HasProjector { get; set; }
        public Boolean Disabled { get; set;}
    }
}
