namespace ProjectTeam04TermProject
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainForm = new System.Windows.Forms.TabControl();
            this.tabPageManageMeetings = new System.Windows.Forms.TabPage();
            this.tabPageManageMeetingRooms = new System.Windows.Forms.TabPage();
            this.tabPageManageGroups = new System.Windows.Forms.TabPage();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.tabControlMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainForm
            // 
            this.tabControlMainForm.Controls.Add(this.tabPageManageMeetings);
            this.tabControlMainForm.Controls.Add(this.tabPageManageMeetingRooms);
            this.tabControlMainForm.Controls.Add(this.tabPageManageGroups);
            this.tabControlMainForm.Controls.Add(this.tabPageXML);
            this.tabControlMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainForm.Location = new System.Drawing.Point(13, 13);
            this.tabControlMainForm.Name = "tabControlMainForm";
            this.tabControlMainForm.SelectedIndex = 0;
            this.tabControlMainForm.Size = new System.Drawing.Size(1177, 776);
            this.tabControlMainForm.TabIndex = 0;
            // 
            // tabPageManageMeetings
            // 
            this.tabPageManageMeetings.Location = new System.Drawing.Point(4, 29);
            this.tabPageManageMeetings.Name = "tabPageManageMeetings";
            this.tabPageManageMeetings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageMeetings.Size = new System.Drawing.Size(1169, 743);
            this.tabPageManageMeetings.TabIndex = 1;
            this.tabPageManageMeetings.Text = "Manage Meetings";
            this.tabPageManageMeetings.UseVisualStyleBackColor = true;
            // 
            // tabPageManageMeetingRooms
            // 
            this.tabPageManageMeetingRooms.Location = new System.Drawing.Point(4, 29);
            this.tabPageManageMeetingRooms.Name = "tabPageManageMeetingRooms";
            this.tabPageManageMeetingRooms.Size = new System.Drawing.Size(1169, 743);
            this.tabPageManageMeetingRooms.TabIndex = 2;
            this.tabPageManageMeetingRooms.Text = "Meeting Rooms";
            this.tabPageManageMeetingRooms.UseVisualStyleBackColor = true;
            // 
            // tabPageManageGroups
            // 
            this.tabPageManageGroups.Location = new System.Drawing.Point(4, 29);
            this.tabPageManageGroups.Name = "tabPageManageGroups";
            this.tabPageManageGroups.Size = new System.Drawing.Size(1169, 743);
            this.tabPageManageGroups.TabIndex = 3;
            this.tabPageManageGroups.Text = "Manage Groups";
            this.tabPageManageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageXML
            // 
            this.tabPageXML.Location = new System.Drawing.Point(4, 29);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Size = new System.Drawing.Size(1169, 743);
            this.tabPageXML.TabIndex = 4;
            this.tabPageXML.Text = "Import / Export XML";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 801);
            this.Controls.Add(this.tabControlMainForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Room Booking App";
            this.tabControlMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainForm;
        private System.Windows.Forms.TabPage tabPageManageMeetings;
        private System.Windows.Forms.TabPage tabPageManageMeetingRooms;
        private System.Windows.Forms.TabPage tabPageManageGroups;
        private System.Windows.Forms.TabPage tabPageXML;
    }
}