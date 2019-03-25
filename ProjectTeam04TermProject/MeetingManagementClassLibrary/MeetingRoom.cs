using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementClassLibrary
{
    class MeetingRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasPhone { get; set; }
        public bool HasProjector { get; set; }
        public bool IsDisabled { get; set; }
    }
}
