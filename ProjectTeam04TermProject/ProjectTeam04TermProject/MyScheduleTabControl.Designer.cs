namespace ProjectTeam04TermProject
{
    partial class MyScheduleTabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMyMeetings = new System.Windows.Forms.Label();
            this.dataGridViewUpcomingMeetings = new System.Windows.Forms.DataGridView();
            this.labelMeetingDetail = new System.Windows.Forms.Label();
            this.labelMeetingTitle = new System.Windows.Forms.Label();
            this.labelMeetingDescription = new System.Windows.Forms.Label();
            this.labelDisplayMeetingTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelDisplayDescription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDisplayDate = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelDisplayFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMeetingRoom = new System.Windows.Forms.Label();
            this.labelDisplayMeetingRoom = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDisplayLocation = new System.Windows.Forms.Label();
            this.labelMeetingNotes = new System.Windows.Forms.Label();
            this.labelDisplayNotes = new System.Windows.Forms.Label();
            this.checkBoxShowPastMeeting = new System.Windows.Forms.CheckBox();
            this.labelTextSearch = new System.Windows.Forms.Label();
            this.textBoxTextSearch = new System.Windows.Forms.TextBox();
            this.buttonFilterMeetings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingMeetings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMyMeetings
            // 
            this.labelMyMeetings.AutoSize = true;
            this.labelMyMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyMeetings.Location = new System.Drawing.Point(14, 15);
            this.labelMyMeetings.Name = "labelMyMeetings";
            this.labelMyMeetings.Size = new System.Drawing.Size(104, 20);
            this.labelMyMeetings.TabIndex = 0;
            this.labelMyMeetings.Text = "My Meetings";
            // 
            // dataGridViewUpcomingMeetings
            // 
            this.dataGridViewUpcomingMeetings.AllowUserToAddRows = false;
            this.dataGridViewUpcomingMeetings.AllowUserToDeleteRows = false;
            this.dataGridViewUpcomingMeetings.AllowUserToOrderColumns = true;
            this.dataGridViewUpcomingMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingMeetings.Location = new System.Drawing.Point(17, 36);
            this.dataGridViewUpcomingMeetings.Name = "dataGridViewUpcomingMeetings";
            this.dataGridViewUpcomingMeetings.RowTemplate.Height = 24;
            this.dataGridViewUpcomingMeetings.Size = new System.Drawing.Size(841, 200);
            this.dataGridViewUpcomingMeetings.TabIndex = 1;
            // 
            // labelMeetingDetail
            // 
            this.labelMeetingDetail.AutoSize = true;
            this.labelMeetingDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeetingDetail.Location = new System.Drawing.Point(16, 300);
            this.labelMeetingDetail.Name = "labelMeetingDetail";
            this.labelMeetingDetail.Size = new System.Drawing.Size(117, 20);
            this.labelMeetingDetail.TabIndex = 4;
            this.labelMeetingDetail.Text = "Meeting Detail";
            // 
            // labelMeetingTitle
            // 
            this.labelMeetingTitle.AutoSize = true;
            this.labelMeetingTitle.Location = new System.Drawing.Point(17, 334);
            this.labelMeetingTitle.Name = "labelMeetingTitle";
            this.labelMeetingTitle.Size = new System.Drawing.Size(35, 17);
            this.labelMeetingTitle.TabIndex = 5;
            this.labelMeetingTitle.Text = "Title";
            // 
            // labelMeetingDescription
            // 
            this.labelMeetingDescription.AutoSize = true;
            this.labelMeetingDescription.Location = new System.Drawing.Point(17, 367);
            this.labelMeetingDescription.Name = "labelMeetingDescription";
            this.labelMeetingDescription.Size = new System.Drawing.Size(79, 17);
            this.labelMeetingDescription.TabIndex = 6;
            this.labelMeetingDescription.Text = "Description";
            // 
            // labelDisplayMeetingTitle
            // 
            this.labelDisplayMeetingTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelDisplayMeetingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayMeetingTitle.Location = new System.Drawing.Point(118, 331);
            this.labelDisplayMeetingTitle.Name = "labelDisplayMeetingTitle";
            this.labelDisplayMeetingTitle.Size = new System.Drawing.Size(739, 23);
            this.labelDisplayMeetingTitle.TabIndex = 7;
            // 
            // labelDisplayDescription
            // 
            this.labelDisplayDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayDescription.Location = new System.Drawing.Point(118, 364);
            this.labelDisplayDescription.Name = "labelDisplayDescription";
            this.labelDisplayDescription.Size = new System.Drawing.Size(739, 23);
            this.labelDisplayDescription.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(17, 400);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // labelDisplayDate
            // 
            this.labelDisplayDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayDate.Location = new System.Drawing.Point(118, 397);
            this.labelDisplayDate.Name = "labelDisplayDate";
            this.labelDisplayDate.Size = new System.Drawing.Size(140, 23);
            this.labelDisplayDate.TabIndex = 10;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(321, 400);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(40, 17);
            this.labelFrom.TabIndex = 11;
            this.labelFrom.Text = "From";
            // 
            // labelDisplayFrom
            // 
            this.labelDisplayFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayFrom.Location = new System.Drawing.Point(424, 397);
            this.labelDisplayFrom.Name = "labelDisplayFrom";
            this.labelDisplayFrom.Size = new System.Drawing.Size(140, 23);
            this.labelDisplayFrom.TabIndex = 12;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(627, 400);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(25, 17);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "To";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 14;
            // 
            // labelMeetingRoom
            // 
            this.labelMeetingRoom.AutoSize = true;
            this.labelMeetingRoom.Location = new System.Drawing.Point(17, 433);
            this.labelMeetingRoom.Name = "labelMeetingRoom";
            this.labelMeetingRoom.Size = new System.Drawing.Size(99, 17);
            this.labelMeetingRoom.TabIndex = 15;
            this.labelMeetingRoom.Text = "Meeting Room";
            // 
            // labelDisplayMeetingRoom
            // 
            this.labelDisplayMeetingRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayMeetingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayMeetingRoom.Location = new System.Drawing.Point(118, 430);
            this.labelDisplayMeetingRoom.Name = "labelDisplayMeetingRoom";
            this.labelDisplayMeetingRoom.Size = new System.Drawing.Size(302, 23);
            this.labelDisplayMeetingRoom.TabIndex = 16;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(486, 433);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(62, 17);
            this.labelLocation.TabIndex = 17;
            this.labelLocation.Text = "Location";
            // 
            // labelDisplayLocation
            // 
            this.labelDisplayLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayLocation.Location = new System.Drawing.Point(555, 430);
            this.labelDisplayLocation.Name = "labelDisplayLocation";
            this.labelDisplayLocation.Size = new System.Drawing.Size(302, 23);
            this.labelDisplayLocation.TabIndex = 18;
            // 
            // labelMeetingNotes
            // 
            this.labelMeetingNotes.AutoSize = true;
            this.labelMeetingNotes.Location = new System.Drawing.Point(17, 466);
            this.labelMeetingNotes.Name = "labelMeetingNotes";
            this.labelMeetingNotes.Size = new System.Drawing.Size(38, 17);
            this.labelMeetingNotes.TabIndex = 19;
            this.labelMeetingNotes.Text = "Note";
            // 
            // labelDisplayNotes
            // 
            this.labelDisplayNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayNotes.Location = new System.Drawing.Point(118, 466);
            this.labelDisplayNotes.Name = "labelDisplayNotes";
            this.labelDisplayNotes.Size = new System.Drawing.Size(739, 89);
            this.labelDisplayNotes.TabIndex = 20;
            // 
            // checkBoxShowPastMeeting
            // 
            this.checkBoxShowPastMeeting.AutoSize = true;
            this.checkBoxShowPastMeeting.Location = new System.Drawing.Point(466, 250);
            this.checkBoxShowPastMeeting.Name = "checkBoxShowPastMeeting";
            this.checkBoxShowPastMeeting.Size = new System.Drawing.Size(156, 21);
            this.checkBoxShowPastMeeting.TabIndex = 21;
            this.checkBoxShowPastMeeting.Text = "Show past meetings";
            this.checkBoxShowPastMeeting.UseVisualStyleBackColor = true;
            // 
            // labelTextSearch
            // 
            this.labelTextSearch.AutoSize = true;
            this.labelTextSearch.Location = new System.Drawing.Point(17, 251);
            this.labelTextSearch.Name = "labelTextSearch";
            this.labelTextSearch.Size = new System.Drawing.Size(53, 17);
            this.labelTextSearch.TabIndex = 22;
            this.labelTextSearch.Text = "Search";
            // 
            // textBoxTextSearch
            // 
            this.textBoxTextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextSearch.Location = new System.Drawing.Point(119, 246);
            this.textBoxTextSearch.Name = "textBoxTextSearch";
            this.textBoxTextSearch.Size = new System.Drawing.Size(259, 27);
            this.textBoxTextSearch.TabIndex = 23;
            // 
            // buttonFilterMeetings
            // 
            this.buttonFilterMeetings.Location = new System.Drawing.Point(716, 243);
            this.buttonFilterMeetings.Name = "buttonFilterMeetings";
            this.buttonFilterMeetings.Size = new System.Drawing.Size(141, 32);
            this.buttonFilterMeetings.TabIndex = 24;
            this.buttonFilterMeetings.Text = "Filter Meetings";
            this.buttonFilterMeetings.UseVisualStyleBackColor = true;
            // 
            // MyScheduleTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFilterMeetings);
            this.Controls.Add(this.textBoxTextSearch);
            this.Controls.Add(this.labelTextSearch);
            this.Controls.Add(this.checkBoxShowPastMeeting);
            this.Controls.Add(this.labelDisplayNotes);
            this.Controls.Add(this.labelMeetingNotes);
            this.Controls.Add(this.labelDisplayLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDisplayMeetingRoom);
            this.Controls.Add(this.labelMeetingRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelDisplayFrom);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelDisplayDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDisplayDescription);
            this.Controls.Add(this.labelDisplayMeetingTitle);
            this.Controls.Add(this.labelMeetingDescription);
            this.Controls.Add(this.labelMeetingTitle);
            this.Controls.Add(this.labelMeetingDetail);
            this.Controls.Add(this.dataGridViewUpcomingMeetings);
            this.Controls.Add(this.labelMyMeetings);
            this.Name = "MyScheduleTabControl";
            this.Size = new System.Drawing.Size(882, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingMeetings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyMeetings;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingMeetings;
        private System.Windows.Forms.Label labelMeetingDetail;
        private System.Windows.Forms.Label labelMeetingTitle;
        private System.Windows.Forms.Label labelMeetingDescription;
        private System.Windows.Forms.Label labelDisplayMeetingTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelDisplayDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDisplayDate;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelDisplayFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMeetingRoom;
        private System.Windows.Forms.Label labelDisplayMeetingRoom;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDisplayLocation;
        private System.Windows.Forms.Label labelMeetingNotes;
        private System.Windows.Forms.Label labelDisplayNotes;
        private System.Windows.Forms.CheckBox checkBoxShowPastMeeting;
        private System.Windows.Forms.Label labelTextSearch;
        private System.Windows.Forms.TextBox textBoxTextSearch;
        private System.Windows.Forms.Button buttonFilterMeetings;
    }
}
