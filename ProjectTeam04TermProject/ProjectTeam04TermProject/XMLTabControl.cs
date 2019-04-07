using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static ProjectTeam04TermProject.MeetingManagementDataSet;
using ProjectTeam04TermProject.MeetingManagementDataSetTableAdapters;

namespace ProjectTeam04TermProject
{
    public partial class XMLTabControl : UserControl
    {
        // Use Disconnected Layer for XML
        MeetingManagementDataSet dataSet;
        UserTableAdapter userTableAdapter;
        GroupTableAdapter groupTableAdapter;
        GroupUserTableAdapter groupUserTableAdapter;
        MeetingRoomTableAdapter meetingRoomTableAdapter;
        MeetingTableAdapter meetingTableAdapter;
        MeetingGroupTableAdapter meetingGroupTableAdapter;
        MeetingUserTableAdapter meetingUserTableAdapter;
        
        public XMLTabControl()
        {
            InitializeComponent();

            // Initialize Disconnected Layer object
            dataSet = new MeetingManagementDataSet();
            userTableAdapter = new UserTableAdapter();
            groupTableAdapter = new GroupTableAdapter();
            groupUserTableAdapter = new GroupUserTableAdapter();
            meetingRoomTableAdapter = new MeetingRoomTableAdapter();
            meetingTableAdapter = new MeetingTableAdapter();
            meetingGroupTableAdapter = new MeetingGroupTableAdapter();
            meetingUserTableAdapter = new MeetingUserTableAdapter();

            // Fill dataset with data
            userTableAdapter.Fill(dataSet.User);
            groupTableAdapter.Fill(dataSet.Group);
            groupUserTableAdapter.Fill(dataSet.GroupUser);
            meetingRoomTableAdapter.Fill(dataSet.MeetingRoom);
            meetingTableAdapter.Fill(dataSet.Meeting);
            meetingGroupTableAdapter.Fill(dataSet.MeetingGroup);
            meetingUserTableAdapter.Fill(dataSet.MeetingUser);

            // Bind click events on buttons
            buttonExportXML.Click += (s, e) => ExportDatabaseToXML();
            buttonImportXML.Click += (s, e) => ImportDatabaseFromXML();
        }

        private void ExportDatabaseToXML()
        {
            // Ask user to choose a place to save xml file
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "XML (*.xml)|*.xml|All files (*.*)|*.*";
            if (fileDialog.ShowDialog(this.Parent) == DialogResult.OK)
            {
                // Write data to XML
                dataSet.WriteXml(fileDialog.FileName);

                // Complete message
                MessageBox.Show("Database exported");                
            }
        }

        private void ImportDatabaseFromXML()
        {
            // Ask user for XML database file
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML (*.xml)|*.xml|All files (*.*)|*.*";
            if (fileDialog.ShowDialog(this.Parent) == DialogResult.OK)
            {
                // Clear database
                DeleteData(meetingGroupTableAdapter.Adapter, dataSet.MeetingGroup);
                DeleteData(meetingUserTableAdapter.Adapter, dataSet.MeetingUser);
                DeleteData(groupUserTableAdapter.Adapter, dataSet.GroupUser);
                DeleteData(meetingTableAdapter.Adapter, dataSet.Meeting);
                DeleteData(groupTableAdapter.Adapter, dataSet.Group);
                DeleteData(userTableAdapter.Adapter, dataSet.User);
                DeleteData(meetingRoomTableAdapter.Adapter, dataSet.MeetingRoom);

                // Reseed tables
                ReseedTable(userTableAdapter.Connection, dataSet.User.TableName, dataSet.User.Count());
                ReseedTable(groupTableAdapter.Connection, dataSet.Group.TableName, dataSet.Group.Count());
                ReseedTable(meetingRoomTableAdapter.Connection, dataSet.MeetingRoom.TableName, dataSet.MeetingRoom.Count());
                ReseedTable(meetingTableAdapter.Connection, dataSet.Meeting.TableName, dataSet.Meeting.Count());

                // Read data from XML
                dataSet.ReadXml(fileDialog.FileName);

                // Save to database
                userTableAdapter.Update(dataSet.User);
                groupTableAdapter.Update(dataSet.Group);
                groupUserTableAdapter.Update(dataSet.GroupUser);
                meetingRoomTableAdapter.Update(dataSet.MeetingRoom);
                meetingTableAdapter.Update(dataSet.Meeting);
                meetingGroupTableAdapter.Update(dataSet.MeetingGroup);
                meetingUserTableAdapter.Update(dataSet.MeetingUser);

                // Complete message
                MessageBox.Show("Database imported");

                // Reload other tabs
                ((MainForm)this.Parent.Parent.Parent).ReloadTabsContent();
            }
        }

        /// <summary>
        /// Delete all data in a table, and update using data adapter
        /// Credit to Michael Hrybyk - Douglas College 
        /// </summary>
        /// <param name="dataAdapter">Adapter to use</param>
        /// <param name="dataTable"></param>
        public void DeleteData(IDbDataAdapter dataAdapter, DataTable dataTable)
        {
            if (dataAdapter == null || dataTable == null || dataTable.DataSet == null)
                return;

            // call the Fill method on the dataset, which loads the select statement
            // as a command

            dataAdapter.Fill(dataTable.DataSet);

            // now delete each row in the datatable (in memory)

            foreach (DataRow d in dataTable.Rows)
                d.Delete();

            // now call Update() which will sync the database with the now cleared table

            dataAdapter.Update(dataTable.DataSet);
        }

        /// <summary>
        /// Using CHECKIDENT, reseed a data table to start id with 1
        /// Credit to Michael Hrybyk - Douglas College 
        /// </summary>
        /// <param name="sqlConnection">Connection object</param>
        /// <param name="tableName">Table to reseed</param>
        /// <param name="reseed">Reseed value</param>
        private void ReseedTable(SqlConnection sqlConnection, string tableName, int numberOfTableRows)
        {
            // reseed value
            int reseed = 0;

            // open the connection, execute the reseed command, and close
            // any errors, show a message and exit the method
            try
            {
                sqlConnection.Open();
                SqlCommand reseedCommand = sqlConnection.CreateCommand();
                reseedCommand.CommandText = $" DBCC CHECKIDENT ('{tableName}', RESEED, {reseed})";
                reseedCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch
            {
                MessageBox.Show($"Problem with reseed of {tableName} to {reseed}");
                return;
            }
        }
    }
}
