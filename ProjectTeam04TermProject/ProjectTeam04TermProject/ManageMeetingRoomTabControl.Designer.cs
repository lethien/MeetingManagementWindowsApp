namespace ProjectTeam04TermProject
{
    partial class ManageMeetingRoomTabControl
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
            this.dataGridViewMeetingRooms = new System.Windows.Forms.DataGridView();
            this.labelMeetingRooms = new System.Windows.Forms.Label();
            this.labelUpcomingMeetings = new System.Windows.Forms.Label();
            this.dataGridViewUpcomingMeetings = new System.Windows.Forms.DataGridView();
            this.labelMeetingRoomDetail = new System.Windows.Forms.Label();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomLocation = new System.Windows.Forms.Label();
            this.textBoxRoomLocation = new System.Windows.Forms.TextBox();
            this.labelNumberOfSeats = new System.Windows.Forms.Label();
            this.textBoxNumberOfSeats = new System.Windows.Forms.TextBox();
            this.labelHasPhone = new System.Windows.Forms.Label();
            this.radioButtonHasPhoneYes = new System.Windows.Forms.RadioButton();
            this.radioButtonHasPhoneNo = new System.Windows.Forms.RadioButton();
            this.panelHasPhoneRadioGroup = new System.Windows.Forms.Panel();
            this.labelHasProjector = new System.Windows.Forms.Label();
            this.panelHasProjectorRadioGroup = new System.Windows.Forms.Panel();
            this.radioButtonHasProjectorNo = new System.Windows.Forms.RadioButton();
            this.radioButtonHasProjectorYes = new System.Windows.Forms.RadioButton();
            this.buttonUpdateRoom = new System.Windows.Forms.Button();
            this.labelIsDisabled = new System.Windows.Forms.Label();
            this.panelDisabledRadioGroup = new System.Windows.Forms.Panel();
            this.radioButtonDisabledNo = new System.Windows.Forms.RadioButton();
            this.radioButtonDisabledYes = new System.Windows.Forms.RadioButton();
            this.buttonAddMeetingRoom = new System.Windows.Forms.Button();
            this.buttonCancelUpdateRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetingRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingMeetings)).BeginInit();
            this.panelHasPhoneRadioGroup.SuspendLayout();
            this.panelHasProjectorRadioGroup.SuspendLayout();
            this.panelDisabledRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMeetingRooms
            // 
            this.dataGridViewMeetingRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeetingRooms.Location = new System.Drawing.Point(24, 57);
            this.dataGridViewMeetingRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMeetingRooms.Name = "dataGridViewMeetingRooms";
            this.dataGridViewMeetingRooms.RowTemplate.Height = 24;
            this.dataGridViewMeetingRooms.Size = new System.Drawing.Size(309, 208);
            this.dataGridViewMeetingRooms.TabIndex = 0;
            // 
            // labelMeetingRooms
            // 
            this.labelMeetingRooms.AutoSize = true;
            this.labelMeetingRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeetingRooms.Location = new System.Drawing.Point(20, 21);
            this.labelMeetingRooms.Name = "labelMeetingRooms";
            this.labelMeetingRooms.Size = new System.Drawing.Size(143, 24);
            this.labelMeetingRooms.TabIndex = 1;
            this.labelMeetingRooms.Text = "Meeting Rooms";
            // 
            // labelUpcomingMeetings
            // 
            this.labelUpcomingMeetings.AutoSize = true;
            this.labelUpcomingMeetings.Location = new System.Drawing.Point(365, 32);
            this.labelUpcomingMeetings.Name = "labelUpcomingMeetings";
            this.labelUpcomingMeetings.Size = new System.Drawing.Size(132, 17);
            this.labelUpcomingMeetings.TabIndex = 2;
            this.labelUpcomingMeetings.Text = "Upcoming Meetings";
            // 
            // dataGridViewUpcomingMeetings
            // 
            this.dataGridViewUpcomingMeetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingMeetings.Location = new System.Drawing.Point(369, 57);
            this.dataGridViewUpcomingMeetings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUpcomingMeetings.Name = "dataGridViewUpcomingMeetings";
            this.dataGridViewUpcomingMeetings.RowTemplate.Height = 24;
            this.dataGridViewUpcomingMeetings.Size = new System.Drawing.Size(487, 207);
            this.dataGridViewUpcomingMeetings.TabIndex = 3;
            // 
            // labelMeetingRoomDetail
            // 
            this.labelMeetingRoomDetail.AutoSize = true;
            this.labelMeetingRoomDetail.Location = new System.Drawing.Point(20, 298);
            this.labelMeetingRoomDetail.Name = "labelMeetingRoomDetail";
            this.labelMeetingRoomDetail.Size = new System.Drawing.Size(139, 17);
            this.labelMeetingRoomDetail.TabIndex = 4;
            this.labelMeetingRoomDetail.Text = "Meeting Room Detail";
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Location = new System.Drawing.Point(24, 329);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(45, 17);
            this.labelRoomName.TabIndex = 5;
            this.labelRoomName.Text = "Name";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomName.Location = new System.Drawing.Point(157, 324);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(451, 27);
            this.textBoxRoomName.TabIndex = 6;
            // 
            // labelRoomLocation
            // 
            this.labelRoomLocation.AutoSize = true;
            this.labelRoomLocation.Location = new System.Drawing.Point(24, 367);
            this.labelRoomLocation.Name = "labelRoomLocation";
            this.labelRoomLocation.Size = new System.Drawing.Size(62, 17);
            this.labelRoomLocation.TabIndex = 7;
            this.labelRoomLocation.Text = "Location";
            // 
            // textBoxRoomLocation
            // 
            this.textBoxRoomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomLocation.Location = new System.Drawing.Point(157, 362);
            this.textBoxRoomLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRoomLocation.Name = "textBoxRoomLocation";
            this.textBoxRoomLocation.Size = new System.Drawing.Size(451, 27);
            this.textBoxRoomLocation.TabIndex = 8;
            // 
            // labelNumberOfSeats
            // 
            this.labelNumberOfSeats.AutoSize = true;
            this.labelNumberOfSeats.Location = new System.Drawing.Point(24, 405);
            this.labelNumberOfSeats.Name = "labelNumberOfSeats";
            this.labelNumberOfSeats.Size = new System.Drawing.Size(114, 17);
            this.labelNumberOfSeats.TabIndex = 9;
            this.labelNumberOfSeats.Text = "Number of Seats";
            // 
            // textBoxNumberOfSeats
            // 
            this.textBoxNumberOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfSeats.Location = new System.Drawing.Point(157, 400);
            this.textBoxNumberOfSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumberOfSeats.Name = "textBoxNumberOfSeats";
            this.textBoxNumberOfSeats.Size = new System.Drawing.Size(111, 27);
            this.textBoxNumberOfSeats.TabIndex = 10;
            // 
            // labelHasPhone
            // 
            this.labelHasPhone.AutoSize = true;
            this.labelHasPhone.Location = new System.Drawing.Point(24, 443);
            this.labelHasPhone.Name = "labelHasPhone";
            this.labelHasPhone.Size = new System.Drawing.Size(78, 17);
            this.labelHasPhone.TabIndex = 11;
            this.labelHasPhone.Text = "Has Phone";
            // 
            // radioButtonHasPhoneYes
            // 
            this.radioButtonHasPhoneYes.AutoSize = true;
            this.radioButtonHasPhoneYes.Location = new System.Drawing.Point(3, 14);
            this.radioButtonHasPhoneYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHasPhoneYes.Name = "radioButtonHasPhoneYes";
            this.radioButtonHasPhoneYes.Size = new System.Drawing.Size(53, 21);
            this.radioButtonHasPhoneYes.TabIndex = 12;
            this.radioButtonHasPhoneYes.TabStop = true;
            this.radioButtonHasPhoneYes.Text = "Yes";
            this.radioButtonHasPhoneYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonHasPhoneNo
            // 
            this.radioButtonHasPhoneNo.AutoSize = true;
            this.radioButtonHasPhoneNo.Location = new System.Drawing.Point(149, 14);
            this.radioButtonHasPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHasPhoneNo.Name = "radioButtonHasPhoneNo";
            this.radioButtonHasPhoneNo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonHasPhoneNo.TabIndex = 13;
            this.radioButtonHasPhoneNo.TabStop = true;
            this.radioButtonHasPhoneNo.Text = "No";
            this.radioButtonHasPhoneNo.UseVisualStyleBackColor = true;
            // 
            // panelHasPhoneRadioGroup
            // 
            this.panelHasPhoneRadioGroup.Controls.Add(this.radioButtonHasPhoneYes);
            this.panelHasPhoneRadioGroup.Controls.Add(this.radioButtonHasPhoneNo);
            this.panelHasPhoneRadioGroup.Location = new System.Drawing.Point(157, 433);
            this.panelHasPhoneRadioGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHasPhoneRadioGroup.Name = "panelHasPhoneRadioGroup";
            this.panelHasPhoneRadioGroup.Size = new System.Drawing.Size(277, 36);
            this.panelHasPhoneRadioGroup.TabIndex = 14;
            // 
            // labelHasProjector
            // 
            this.labelHasProjector.AutoSize = true;
            this.labelHasProjector.Location = new System.Drawing.Point(24, 485);
            this.labelHasProjector.Name = "labelHasProjector";
            this.labelHasProjector.Size = new System.Drawing.Size(94, 17);
            this.labelHasProjector.TabIndex = 15;
            this.labelHasProjector.Text = "Has Projector";
            // 
            // panelHasProjectorRadioGroup
            // 
            this.panelHasProjectorRadioGroup.Controls.Add(this.radioButtonHasProjectorNo);
            this.panelHasProjectorRadioGroup.Controls.Add(this.radioButtonHasProjectorYes);
            this.panelHasProjectorRadioGroup.Location = new System.Drawing.Point(157, 475);
            this.panelHasProjectorRadioGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHasProjectorRadioGroup.Name = "panelHasProjectorRadioGroup";
            this.panelHasProjectorRadioGroup.Size = new System.Drawing.Size(277, 36);
            this.panelHasProjectorRadioGroup.TabIndex = 16;
            // 
            // radioButtonHasProjectorNo
            // 
            this.radioButtonHasProjectorNo.AutoSize = true;
            this.radioButtonHasProjectorNo.Location = new System.Drawing.Point(149, 14);
            this.radioButtonHasProjectorNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHasProjectorNo.Name = "radioButtonHasProjectorNo";
            this.radioButtonHasProjectorNo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonHasProjectorNo.TabIndex = 1;
            this.radioButtonHasProjectorNo.TabStop = true;
            this.radioButtonHasProjectorNo.Text = "No";
            this.radioButtonHasProjectorNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonHasProjectorYes
            // 
            this.radioButtonHasProjectorYes.AutoSize = true;
            this.radioButtonHasProjectorYes.Location = new System.Drawing.Point(4, 14);
            this.radioButtonHasProjectorYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHasProjectorYes.Name = "radioButtonHasProjectorYes";
            this.radioButtonHasProjectorYes.Size = new System.Drawing.Size(53, 21);
            this.radioButtonHasProjectorYes.TabIndex = 0;
            this.radioButtonHasProjectorYes.TabStop = true;
            this.radioButtonHasProjectorYes.Text = "Yes";
            this.radioButtonHasProjectorYes.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateRoom
            // 
            this.buttonUpdateRoom.Location = new System.Drawing.Point(493, 443);
            this.buttonUpdateRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateRoom.Name = "buttonUpdateRoom";
            this.buttonUpdateRoom.Size = new System.Drawing.Size(115, 50);
            this.buttonUpdateRoom.TabIndex = 17;
            this.buttonUpdateRoom.Text = "Update Meeting Room";
            this.buttonUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // labelIsDisabled
            // 
            this.labelIsDisabled.AutoSize = true;
            this.labelIsDisabled.Location = new System.Drawing.Point(24, 530);
            this.labelIsDisabled.Name = "labelIsDisabled";
            this.labelIsDisabled.Size = new System.Drawing.Size(77, 17);
            this.labelIsDisabled.TabIndex = 18;
            this.labelIsDisabled.Text = "Is Disabled";
            // 
            // panelDisabledRadioGroup
            // 
            this.panelDisabledRadioGroup.Controls.Add(this.radioButtonDisabledNo);
            this.panelDisabledRadioGroup.Controls.Add(this.radioButtonDisabledYes);
            this.panelDisabledRadioGroup.Location = new System.Drawing.Point(157, 517);
            this.panelDisabledRadioGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDisabledRadioGroup.Name = "panelDisabledRadioGroup";
            this.panelDisabledRadioGroup.Size = new System.Drawing.Size(277, 36);
            this.panelDisabledRadioGroup.TabIndex = 19;
            // 
            // radioButtonDisabledNo
            // 
            this.radioButtonDisabledNo.AutoSize = true;
            this.radioButtonDisabledNo.Location = new System.Drawing.Point(149, 10);
            this.radioButtonDisabledNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDisabledNo.Name = "radioButtonDisabledNo";
            this.radioButtonDisabledNo.Size = new System.Drawing.Size(47, 21);
            this.radioButtonDisabledNo.TabIndex = 1;
            this.radioButtonDisabledNo.TabStop = true;
            this.radioButtonDisabledNo.Text = "No";
            this.radioButtonDisabledNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisabledYes
            // 
            this.radioButtonDisabledYes.AutoSize = true;
            this.radioButtonDisabledYes.Location = new System.Drawing.Point(4, 10);
            this.radioButtonDisabledYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDisabledYes.Name = "radioButtonDisabledYes";
            this.radioButtonDisabledYes.Size = new System.Drawing.Size(53, 21);
            this.radioButtonDisabledYes.TabIndex = 0;
            this.radioButtonDisabledYes.TabStop = true;
            this.radioButtonDisabledYes.Text = "Yes";
            this.radioButtonDisabledYes.UseVisualStyleBackColor = true;
            // 
            // buttonAddMeetingRoom
            // 
            this.buttonAddMeetingRoom.Location = new System.Drawing.Point(180, 17);
            this.buttonAddMeetingRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddMeetingRoom.Name = "buttonAddMeetingRoom";
            this.buttonAddMeetingRoom.Size = new System.Drawing.Size(33, 31);
            this.buttonAddMeetingRoom.TabIndex = 20;
            this.buttonAddMeetingRoom.Text = "+";
            this.buttonAddMeetingRoom.UseVisualStyleBackColor = true;
            // 
            // buttonCancelUpdateRoom
            // 
            this.buttonCancelUpdateRoom.Location = new System.Drawing.Point(493, 508);
            this.buttonCancelUpdateRoom.Name = "buttonCancelUpdateRoom";
            this.buttonCancelUpdateRoom.Size = new System.Drawing.Size(115, 45);
            this.buttonCancelUpdateRoom.TabIndex = 21;
            this.buttonCancelUpdateRoom.Text = "Cancel";
            this.buttonCancelUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // ManageMeetingRoomTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelUpdateRoom);
            this.Controls.Add(this.buttonAddMeetingRoom);
            this.Controls.Add(this.panelDisabledRadioGroup);
            this.Controls.Add(this.labelIsDisabled);
            this.Controls.Add(this.buttonUpdateRoom);
            this.Controls.Add(this.panelHasProjectorRadioGroup);
            this.Controls.Add(this.labelHasProjector);
            this.Controls.Add(this.panelHasPhoneRadioGroup);
            this.Controls.Add(this.labelHasPhone);
            this.Controls.Add(this.textBoxNumberOfSeats);
            this.Controls.Add(this.labelNumberOfSeats);
            this.Controls.Add(this.textBoxRoomLocation);
            this.Controls.Add(this.labelRoomLocation);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.labelMeetingRoomDetail);
            this.Controls.Add(this.dataGridViewUpcomingMeetings);
            this.Controls.Add(this.labelUpcomingMeetings);
            this.Controls.Add(this.labelMeetingRooms);
            this.Controls.Add(this.dataGridViewMeetingRooms);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageMeetingRoomTabControl";
            this.Size = new System.Drawing.Size(880, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetingRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingMeetings)).EndInit();
            this.panelHasPhoneRadioGroup.ResumeLayout(false);
            this.panelHasPhoneRadioGroup.PerformLayout();
            this.panelHasProjectorRadioGroup.ResumeLayout(false);
            this.panelHasProjectorRadioGroup.PerformLayout();
            this.panelDisabledRadioGroup.ResumeLayout(false);
            this.panelDisabledRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeetingRooms;
        private System.Windows.Forms.Label labelMeetingRooms;
        private System.Windows.Forms.Label labelUpcomingMeetings;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingMeetings;
        private System.Windows.Forms.Label labelMeetingRoomDetail;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelRoomLocation;
        private System.Windows.Forms.TextBox textBoxRoomLocation;
        private System.Windows.Forms.Label labelNumberOfSeats;
        private System.Windows.Forms.TextBox textBoxNumberOfSeats;
        private System.Windows.Forms.Label labelHasPhone;
        private System.Windows.Forms.RadioButton radioButtonHasPhoneYes;
        private System.Windows.Forms.RadioButton radioButtonHasPhoneNo;
        private System.Windows.Forms.Panel panelHasPhoneRadioGroup;
        private System.Windows.Forms.Label labelHasProjector;
        private System.Windows.Forms.Panel panelHasProjectorRadioGroup;
        private System.Windows.Forms.RadioButton radioButtonHasProjectorNo;
        private System.Windows.Forms.RadioButton radioButtonHasProjectorYes;
        private System.Windows.Forms.Button buttonUpdateRoom;
        private System.Windows.Forms.Label labelIsDisabled;
        private System.Windows.Forms.Panel panelDisabledRadioGroup;
        private System.Windows.Forms.RadioButton radioButtonDisabledNo;
        private System.Windows.Forms.RadioButton radioButtonDisabledYes;
        private System.Windows.Forms.Button buttonAddMeetingRoom;
        private System.Windows.Forms.Button buttonCancelUpdateRoom;
    }
}
