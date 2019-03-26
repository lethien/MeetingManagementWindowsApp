namespace ProjectTeam04TermProject
{
    partial class ManageGroupTabControl
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
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.labelGroups = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelSearchByGroupName = new System.Windows.Forms.Label();
            this.textBoxSearchGroupName = new System.Windows.Forms.TextBox();
            this.checkBoxShowDisabledGroups = new System.Windows.Forms.CheckBox();
            this.checkBoxGroupNoMember = new System.Windows.Forms.CheckBox();
            this.buttonFilterGroups = new System.Windows.Forms.Button();
            this.labelMembers = new System.Windows.Forms.Label();
            this.listBoxGroupMembers = new System.Windows.Forms.ListBox();
            this.textBoxFilterMembers = new System.Windows.Forms.TextBox();
            this.buttonFilterMembers = new System.Windows.Forms.Button();
            this.labelOtherUsers = new System.Windows.Forms.Label();
            this.textBoxFilterUsers = new System.Windows.Forms.TextBox();
            this.buttonFilterOtherUsers = new System.Windows.Forms.Button();
            this.listBoxOtherUsers = new System.Windows.Forms.ListBox();
            this.buttonAddToGroup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(19, 38);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(393, 222);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(16, 18);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(55, 17);
            this.labelGroups.TabIndex = 1;
            this.labelGroups.Text = "Groups";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(476, 18);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(50, 17);
            this.labelFilters.TabIndex = 2;
            this.labelFilters.Text = "Filters:";
            // 
            // labelSearchByGroupName
            // 
            this.labelSearchByGroupName.AutoSize = true;
            this.labelSearchByGroupName.Location = new System.Drawing.Point(479, 39);
            this.labelSearchByGroupName.Name = "labelSearchByGroupName";
            this.labelSearchByGroupName.Size = new System.Drawing.Size(89, 17);
            this.labelSearchByGroupName.TabIndex = 3;
            this.labelSearchByGroupName.Text = "Group Name";
            // 
            // textBoxSearchGroupName
            // 
            this.textBoxSearchGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchGroupName.Location = new System.Drawing.Point(586, 36);
            this.textBoxSearchGroupName.Name = "textBoxSearchGroupName";
            this.textBoxSearchGroupName.Size = new System.Drawing.Size(271, 27);
            this.textBoxSearchGroupName.TabIndex = 4;
            // 
            // checkBoxShowDisabledGroups
            // 
            this.checkBoxShowDisabledGroups.AutoSize = true;
            this.checkBoxShowDisabledGroups.Location = new System.Drawing.Point(482, 81);
            this.checkBoxShowDisabledGroups.Name = "checkBoxShowDisabledGroups";
            this.checkBoxShowDisabledGroups.Size = new System.Drawing.Size(136, 21);
            this.checkBoxShowDisabledGroups.TabIndex = 5;
            this.checkBoxShowDisabledGroups.Text = "Disabled Groups";
            this.checkBoxShowDisabledGroups.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroupNoMember
            // 
            this.checkBoxGroupNoMember.AutoSize = true;
            this.checkBoxGroupNoMember.Location = new System.Drawing.Point(482, 117);
            this.checkBoxGroupNoMember.Name = "checkBoxGroupNoMember";
            this.checkBoxGroupNoMember.Size = new System.Drawing.Size(180, 21);
            this.checkBoxGroupNoMember.TabIndex = 6;
            this.checkBoxGroupNoMember.Text = "Groups with no member";
            this.checkBoxGroupNoMember.UseVisualStyleBackColor = true;
            // 
            // buttonFilterGroups
            // 
            this.buttonFilterGroups.Location = new System.Drawing.Point(727, 156);
            this.buttonFilterGroups.Name = "buttonFilterGroups";
            this.buttonFilterGroups.Size = new System.Drawing.Size(130, 34);
            this.buttonFilterGroups.TabIndex = 7;
            this.buttonFilterGroups.Text = "Filter Groups";
            this.buttonFilterGroups.UseVisualStyleBackColor = true;
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Location = new System.Drawing.Point(19, 294);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(110, 17);
            this.labelMembers.TabIndex = 8;
            this.labelMembers.Text = "Group Members";
            // 
            // listBoxGroupMembers
            // 
            this.listBoxGroupMembers.FormattingEnabled = true;
            this.listBoxGroupMembers.ItemHeight = 16;
            this.listBoxGroupMembers.Location = new System.Drawing.Point(22, 351);
            this.listBoxGroupMembers.Name = "listBoxGroupMembers";
            this.listBoxGroupMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGroupMembers.Size = new System.Drawing.Size(267, 196);
            this.listBoxGroupMembers.TabIndex = 9;
            // 
            // textBoxFilterMembers
            // 
            this.textBoxFilterMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterMembers.Location = new System.Drawing.Point(22, 315);
            this.textBoxFilterMembers.Name = "textBoxFilterMembers";
            this.textBoxFilterMembers.Size = new System.Drawing.Size(186, 27);
            this.textBoxFilterMembers.TabIndex = 10;
            // 
            // buttonFilterMembers
            // 
            this.buttonFilterMembers.Location = new System.Drawing.Point(214, 315);
            this.buttonFilterMembers.Name = "buttonFilterMembers";
            this.buttonFilterMembers.Size = new System.Drawing.Size(75, 27);
            this.buttonFilterMembers.TabIndex = 11;
            this.buttonFilterMembers.Text = "Filter";
            this.buttonFilterMembers.UseVisualStyleBackColor = true;
            // 
            // labelOtherUsers
            // 
            this.labelOtherUsers.AutoSize = true;
            this.labelOtherUsers.Location = new System.Drawing.Point(521, 294);
            this.labelOtherUsers.Name = "labelOtherUsers";
            this.labelOtherUsers.Size = new System.Drawing.Size(106, 17);
            this.labelOtherUsers.TabIndex = 12;
            this.labelOtherUsers.Text = "Available Users";
            // 
            // textBoxFilterUsers
            // 
            this.textBoxFilterUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterUsers.Location = new System.Drawing.Point(524, 315);
            this.textBoxFilterUsers.Name = "textBoxFilterUsers";
            this.textBoxFilterUsers.Size = new System.Drawing.Size(186, 27);
            this.textBoxFilterUsers.TabIndex = 13;
            // 
            // buttonFilterOtherUsers
            // 
            this.buttonFilterOtherUsers.Location = new System.Drawing.Point(717, 315);
            this.buttonFilterOtherUsers.Name = "buttonFilterOtherUsers";
            this.buttonFilterOtherUsers.Size = new System.Drawing.Size(75, 27);
            this.buttonFilterOtherUsers.TabIndex = 14;
            this.buttonFilterOtherUsers.Text = "Filter";
            this.buttonFilterOtherUsers.UseVisualStyleBackColor = true;
            // 
            // listBoxOtherUsers
            // 
            this.listBoxOtherUsers.FormattingEnabled = true;
            this.listBoxOtherUsers.ItemHeight = 16;
            this.listBoxOtherUsers.Location = new System.Drawing.Point(524, 351);
            this.listBoxOtherUsers.Name = "listBoxOtherUsers";
            this.listBoxOtherUsers.Size = new System.Drawing.Size(268, 196);
            this.listBoxOtherUsers.TabIndex = 15;
            // 
            // buttonAddToGroup
            // 
            this.buttonAddToGroup.Location = new System.Drawing.Point(306, 389);
            this.buttonAddToGroup.Name = "buttonAddToGroup";
            this.buttonAddToGroup.Size = new System.Drawing.Size(200, 30);
            this.buttonAddToGroup.TabIndex = 16;
            this.buttonAddToGroup.Text = "<<Add To Group<<";
            this.buttonAddToGroup.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = ">>Remove From Group>>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageGroupTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddToGroup);
            this.Controls.Add(this.listBoxOtherUsers);
            this.Controls.Add(this.buttonFilterOtherUsers);
            this.Controls.Add(this.textBoxFilterUsers);
            this.Controls.Add(this.labelOtherUsers);
            this.Controls.Add(this.buttonFilterMembers);
            this.Controls.Add(this.textBoxFilterMembers);
            this.Controls.Add(this.listBoxGroupMembers);
            this.Controls.Add(this.labelMembers);
            this.Controls.Add(this.buttonFilterGroups);
            this.Controls.Add(this.checkBoxGroupNoMember);
            this.Controls.Add(this.checkBoxShowDisabledGroups);
            this.Controls.Add(this.textBoxSearchGroupName);
            this.Controls.Add(this.labelSearchByGroupName);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.dataGridViewGroups);
            this.Name = "ManageGroupTabControl";
            this.Size = new System.Drawing.Size(880, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelSearchByGroupName;
        private System.Windows.Forms.TextBox textBoxSearchGroupName;
        private System.Windows.Forms.CheckBox checkBoxShowDisabledGroups;
        private System.Windows.Forms.CheckBox checkBoxGroupNoMember;
        private System.Windows.Forms.Button buttonFilterGroups;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.ListBox listBoxGroupMembers;
        private System.Windows.Forms.TextBox textBoxFilterMembers;
        private System.Windows.Forms.Button buttonFilterMembers;
        private System.Windows.Forms.Label labelOtherUsers;
        private System.Windows.Forms.TextBox textBoxFilterUsers;
        private System.Windows.Forms.Button buttonFilterOtherUsers;
        private System.Windows.Forms.ListBox listBoxOtherUsers;
        private System.Windows.Forms.Button buttonAddToGroup;
        private System.Windows.Forms.Button button1;
    }
}
