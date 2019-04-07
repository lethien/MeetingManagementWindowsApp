# MeetingRoomBooking
Meeting Room Management App using C#
Term Project for CSIS3540 - Winter 2019 - Douglas College

Instructor: Michael Hrybyk
Student: Toan Thien Le

### Technical Overview:
- Winform
- Entity Framework
- SQL Server
- ADO.Net Disconnected Layer (Only for import / export database from / to XML)

### Installation Manual:
- Download the whole project
- Create a database named MeetingManagement
- Publish MeetingManagementDatabase to the created database
- Tools -> NuGet Package Manager -> Manage NuGet Package for Solution -> Install Entity Framework for all projects in this solution
- (Caution) Check for MeetingManagementConnection in App.config of all projects that use Entity Framework
- (Optional) Run MeetingManagementDataSeed
- Run main project MeetingManageApplication
- If you seeded the database, there are 9 users available for login (admin1 -> admin2, manager1 -> manager 3, user1 -> user4) 

For more information, please prefer to report in this same git repo.