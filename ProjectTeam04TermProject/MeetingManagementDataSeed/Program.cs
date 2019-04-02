using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity;
using MeetingManagementClassLibrary;

namespace MeetingRoomBookingDataSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----Start seeding Meeting Management database----");

            MeetingManagementEntities context = new MeetingManagementEntities();

            // set up database log to write to output window in VS
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            // delete db if exists, then create
            context.Database.Delete();
            context.Database.Create();

            // Sample Users
            List<User> users = new List<User>()
            {
                new User { Username = "admin1", Role = Constants.USER_ROLE_ADMIN, Disabled = false },
                new User { Username = "admin2", Role = Constants.USER_ROLE_ADMIN, Disabled = false },
                new User { Username = "manager1", Role = Constants.USER_ROLE_MANAGER, Disabled = false },
                new User { Username = "manager2", Role = Constants.USER_ROLE_MANAGER, Disabled = false },
                new User { Username = "manager3", Role = Constants.USER_ROLE_MANAGER, Disabled = false },
                new User { Username = "user1", Role = Constants.USER_ROLE_USER, Disabled = false },
                new User { Username = "user2", Role = Constants.USER_ROLE_USER, Disabled = false },
                new User { Username = "user3", Role = Constants.USER_ROLE_USER, Disabled = false },
                new User { Username = "user4", Role = Constants.USER_ROLE_USER, Disabled = false },
                new User { Username = "user5", Role = Constants.USER_ROLE_USER, Disabled = false }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
            context.Users.Load();

            System.Console.WriteLine("----Users Created----");
            context.Users.ToList().ForEach(user => System.Console.WriteLine("Id: " + user.Id + "; Username: " + user.Username));

            // Sample Groups
            List<Group> groups = new List<Group>
            {
                new Group { GroupName = "Admins", Disabled = false },
                new Group { GroupName = "Managers", Disabled = false },
                new Group { GroupName = "HR Department", Disabled = false },
                new Group { GroupName = "IT Department", Disabled = false }
            };

            context.Groups.AddRange(groups);
            context.SaveChanges();
            context.Groups.Load();

            System.Console.WriteLine("----Groups Created----");
            context.Groups.ToList().ForEach(group => System.Console.WriteLine("Id: " + group.Id + "; Username: " + group.GroupName));

            // Add Users to Groups
            List<User> adminUsers = context.Users.Where(user => user.Username.Contains("admin")).ToList();
            Group adminGroup = context.Groups.Where(group => group.GroupName == "Admins").ToList()[0];
            adminUsers.ForEach(user => adminGroup.Users.Add(user));
            List<User> managerUsers = context.Users.Where(user => user.Username.Contains("manager")).ToList();
            Group managerGroup = context.Groups.Where(group => group.GroupName == "Managers").ToList()[0];
            managerUsers.ForEach(user => managerGroup.Users.Add(user));

            context.SaveChanges();
            context.Groups.Load();

            System.Console.WriteLine("----Users added to Groups----");
            context.Groups.ToList().ForEach(group => System.Console.WriteLine("Id: " + group.Id + "; Member count: " + group.Users.Count));

            // Sample Meeting Rooms
            List<MeetingRoom> rooms = new List<MeetingRoom>()
            {
                new MeetingRoom { RoomName = "MR.2.1", Location = "Floor 2nd", NumberOfSeats = 20, HasPhone = true, HasProjector = true, Disabled = false },
                new MeetingRoom { RoomName = "MR.2.2", Location = "Floor 2nd", NumberOfSeats = 6, HasPhone = true, HasProjector = false, Disabled = false },
                new MeetingRoom { RoomName = "MR.3.1", Location = "Floor 3rd", NumberOfSeats = 50, HasPhone = true, HasProjector = true, Disabled = false },
                new MeetingRoom { RoomName = "MR.4.1", Location = "Floor 4th", NumberOfSeats = 20, HasPhone = false, HasProjector = true, Disabled = false },
                new MeetingRoom { RoomName = "MR.4.2", Location = "Floor 4th", NumberOfSeats = 20, HasPhone = true, HasProjector = false, Disabled = false },
                new MeetingRoom { RoomName = "MR.5.1", Location = "Floor 5th", NumberOfSeats = 100, HasPhone = true, HasProjector = true, Disabled = false },
            };

            context.MeetingRooms.AddRange(rooms);
            context.SaveChanges();
            context.MeetingRooms.Load();

            System.Console.WriteLine("----Meeting Rooms Created----");
            context.MeetingRooms.ToList().ForEach(room => System.Console.WriteLine("Id: " + room.Id + "; Room Name: " + room.RoomName));

            // Sample Meetings
            List<Meeting> meetings = new List<Meeting>()
            {
                new Meeting { Title = "Annual Meeting", Description = "Inform employees about financial status of the company", From = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 30, 0), To = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 4, 0, 0), MeetingRoomId = 1, Notes = "Please be on time", CreatedBy = 1 },
                new Meeting { Title = "HR Dept Brainstorm", Description = "On how to attract more employees", From = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 0, 0), To = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 30, 0), MeetingRoomId = 3, Notes = "Please be on time", CreatedBy = 2 }
            };

            context.Meetings.AddRange(meetings);
            context.SaveChanges();
            context.Meetings.Load();
            context.MeetingRooms.Load();
            context.Users.Load();

            System.Console.WriteLine("----Meetings Created----");
            context.Meetings.ToList().ForEach(meeting => System.Console.WriteLine("Id: " + meeting.Id + "; Title: " + meeting.Title));

            // Invite some employees to meetings
            List<User> annualMeetingUsers = context.Users.Where(user => user.Username.Contains("manager")).ToList();
            annualMeetingUsers.ForEach(user => context.Meetings.ToList()[0].Users.Add(user));
            List<Group> hrMeetingGroups = context.Groups.Where(group => group.GroupName == "Managers").ToList();
            hrMeetingGroups.ForEach(group => context.Meetings.ToList()[1].Groups.Add(group));

            context.SaveChanges();
            context.Meetings.Load();
            context.Users.Load();

            System.Console.WriteLine("----Users invited to Meetings----");
            context.Meetings.ToList().ForEach(meeting => System.Console.WriteLine("Id: " + meeting.Id + "; Invited count: " + meeting.Users.Count));

            System.Console.WriteLine("----Done seeding Meeting Management database----");

            System.Console.ReadLine();
        }
    }
}
