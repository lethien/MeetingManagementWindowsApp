using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementClassLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserRoles Role { get; set; }
        public bool IsDisabled { get; set; }

        public enum UserRoles { USER, MANAGER, ADMIN }
    }
}
