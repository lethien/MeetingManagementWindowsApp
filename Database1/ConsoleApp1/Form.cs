using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Dataset
using static ConsoleApp1.MeetingDataSet;
using ConsoleApp1.MeetingDataSetTableAdapters;

namespace ConsoleApp1
{
    public partial class DataForm
    {
        //variables to hold datasets, tabales and adaptors 
        MeetingDataSet MeetingDataSet;
        MeetingDataTable MeetingDataTable;
        GroupDataTable GroupDataTable;
        MeetingRoomDataTable MeetingRoomDataTable;
        UserDataTable UserDataTable;

    }
}
