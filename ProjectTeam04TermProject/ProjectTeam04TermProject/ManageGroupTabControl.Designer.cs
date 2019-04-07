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
            this.labelSearchByGroupName = new System.Windows.Forms.Label();
            this.textBoxSearchGroupName = new System.Windows.Forms.TextBox();
            this.checkBoxShowDisabledGroups = new System.Windows.Forms.CheckBox();
            this.checkBoxGroupNoMember = new System.Windows.Forms.CheckBox();
            this.buttonFilterGroups = new System.Windows.Forms.Button();
            this.labelMembers = new System.Windows.Forms.Label();
            this.listBoxGroupMembers = new System.Windows.Forms.ListBox();
            this.labelOtherUsers = new System.Windows.Forms.Label();
            this.listBoxOtherUsers = new System.Windows.Forms.ListBox();
            this.buttonAddToGroup = new System.Windows.Forms.Button();
            this.buttonRemoveFromGroup = new System.Windows.Forms.Button();
            this.labelGroupDetail = new System.Windows.Forms.Label();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelDisabled = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDisabledNo = new System.Windows.Forms.RadioButton();
            this.radioButtonDisabledYes = new System.Windows.Forms.RadioButton();
            this.buttonUpdateGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonCancelUpdateGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(20, 47);
            this.dataGridViewGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(577, 191);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroups.Location = new System.Drawing.Point(16, 18);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(72, 24);
            this.labelGroups.TabIndex = 1;
            this.labelGroups.Text = "Groups";
            // 
            // labelSearchByGroupName
            // 
            this.labelSearchByGroupName.AutoSize = true;
            this.labelSearchByGroupName.Location = new System.Drawing.Point(625, 38);
            this.labelSearchByGroupName.Name = "labelSearchByGroupName";
            this.labelSearchByGroupName.Size = new System.Drawing.Size(138, 17);
            this.labelSearchByGroupName.TabIndex = 3;
            this.labelSearchByGroupName.Text = "Search Group Name";
            // 
            // textBoxSearchGroupName
            // 
            this.textBoxSearchGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchGroupName.Location = new System.Drawing.Point(628, 66);
            this.textBoxSearchGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchGroupName.Name = "textBoxSearchGroupName";
            this.textBoxSearchGroupName.Size = new System.Drawing.Size(229, 27);
            this.textBoxSearchGroupName.TabIndex = 4;
            // 
            // checkBoxShowDisabledGroups
            // 
            this.checkBoxShowDisabledGroups.AutoSize = true;
            this.checkBoxShowDisabledGroups.Location = new System.Drawing.Point(628, 116);
            this.checkBoxShowDisabledGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowDisabledGroups.Name = "checkBoxShowDisabledGroups";
            this.checkBoxShowDisabledGroups.Size = new System.Drawing.Size(174, 21);
            this.checkBoxShowDisabledGroups.TabIndex = 5;
            this.checkBoxShowDisabledGroups.Text = "Show Disabled Groups";
            this.checkBoxShowDisabledGroups.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroupNoMember
            // 
            this.checkBoxGroupNoMember.AutoSize = true;
            this.checkBoxGroupNoMember.Location = new System.Drawing.Point(628, 153);
            this.checkBoxGroupNoMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGroupNoMember.Name = "checkBoxGroupNoMember";
            this.checkBoxGroupNoMember.Size = new System.Drawing.Size(191, 21);
            this.checkBoxGroupNoMember.TabIndex = 6;
            this.checkBoxGroupNoMember.Text = "Show Empty Groups Only";
            this.checkBoxGroupNoMember.UseVisualStyleBackColor = true;
            // 
            // buttonFilterGroups
            // 
            this.buttonFilterGroups.Location = new System.Drawing.Point(727, 194);
            this.buttonFilterGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilterGroups.Name = "buttonFilterGroups";
            this.buttonFilterGroups.Size = new System.Drawing.Size(131, 34);
            this.buttonFilterGroups.TabIndex = 7;
            this.buttonFilterGroups.Text = "Filter Groups";
            this.buttonFilterGroups.UseVisualStyleBackColor = true;
            // 
            // labelMembers
            // 
            this.labelMembers.AutoSize = true;
            this.labelMembers.Location = new System.Drawing.Point(19, 359);
            this.labelMembers.Name = "labelMembers";
            this.labelMembers.Size = new System.Drawing.Size(110, 17);
            this.labelMembers.TabIndex = 8;
            this.labelMembers.Text = "Group Members";
            // 
            // listBoxGroupMembers
            // 
            this.listBoxGroupMembers.FormattingEnabled = true;
            this.listBoxGroupMembers.ItemHeight = 16;
            this.listBoxGroupMembers.Location = new System.Drawing.Point(21, 385);
            this.listBoxGroupMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroupMembers.Name = "listBoxGroupMembers";
            this.listBoxGroupMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGroupMembers.Size = new System.Drawing.Size(267, 164);
            this.listBoxGroupMembers.TabIndex = 9;
            // 
            // labelOtherUsers
            // 
            this.labelOtherUsers.AutoSize = true;
            this.labelOtherUsers.Location = new System.Drawing.Point(521, 359);
            this.labelOtherUsers.Name = "labelOtherUsers";
            this.labelOtherUsers.Size = new System.Drawing.Size(106, 17);
            this.labelOtherUsers.TabIndex = 12;
            this.labelOtherUsers.Text = "Available Users";
            // 
            // listBoxOtherUsers
            // 
            this.listBoxOtherUsers.FormattingEnabled = true;
            this.listBoxOtherUsers.ItemHeight = 16;
            this.listBoxOtherUsers.Location = new System.Drawing.Point(524, 385);
            this.listBoxOtherUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOtherUsers.Name = "listBoxOtherUsers";
            this.listBoxOtherUsers.Size = new System.Drawing.Size(268, 164);
            this.listBoxOtherUsers.TabIndex = 15;
            // 
            // buttonAddToGroup
            // 
            this.buttonAddToGroup.Location = new System.Drawing.Point(307, 433);
            this.buttonAddToGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddToGroup.Name = "buttonAddToGroup";
            this.buttonAddToGroup.Size = new System.Drawing.Size(200, 30);
            this.buttonAddToGroup.TabIndex = 16;
            this.buttonAddToGroup.Text = "<<Add To Group<<";
            this.buttonAddToGroup.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveFromGroup
            // 
            this.buttonRemoveFromGroup.Location = new System.Drawing.Point(307, 482);
            this.buttonRemoveFromGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveFromGroup.Name = "buttonRemoveFromGroup";
            this.buttonRemoveFromGroup.Size = new System.Drawing.Size(200, 30);
            this.buttonRemoveFromGroup.TabIndex = 17;
            this.buttonRemoveFromGroup.Text = ">>Remove From Group>>";
            this.buttonRemoveFromGroup.UseVisualStyleBackColor = true;
            // 
            // labelGroupDetail
            // 
            this.labelGroupDetail.AutoSize = true;
            this.labelGroupDetail.Location = new System.Drawing.Point(19, 258);
            this.labelGroupDetail.Name = "labelGroupDetail";
            this.labelGroupDetail.Size = new System.Drawing.Size(88, 17);
            this.labelGroupDetail.TabIndex = 18;
            this.labelGroupDetail.Text = "Group Detail";
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(19, 288);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(89, 17);
            this.labelGroupName.TabIndex = 19;
            this.labelGroupName.Text = "Group Name";
            // 
            // labelDisabled
            // 
            this.labelDisabled.AutoSize = true;
            this.labelDisabled.Location = new System.Drawing.Point(19, 324);
            this.labelDisabled.Name = "labelDisabled";
            this.labelDisabled.Size = new System.Drawing.Size(77, 17);
            this.labelDisabled.TabIndex = 20;
            this.labelDisabled.Text = "Is Disabled";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(168, 283);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(315, 27);
            this.textBoxGroupName.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDisabledNo);
            this.panel1.Controls.Add(this.radioButtonDisabledYes);
            this.panel1.Location = new System.Drawing.Point(168, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 34);
            this.panel1.TabIndex = 22;
            // 
            // radioButtonDisabledNo
            // 
            this.radioButtonDisabledNo.AutoSize = true;
            this.radioButtonDisabledNo.Location = new System.Drawing.Point(165, 5);
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
            this.radioButtonDisabledYes.Location = new System.Drawing.Point(4, 5);
            this.radioButtonDisabledYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonDisabledYes.Name = "radioButtonDisabledYes";
            this.radioButtonDisabledYes.Size = new System.Drawing.Size(53, 21);
            this.radioButtonDisabledYes.TabIndex = 0;
            this.radioButtonDisabledYes.TabStop = true;
            this.radioButtonDisabledYes.Text = "Yes";
            this.radioButtonDisabledYes.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.Location = new System.Drawing.Point(661, 282);
            this.buttonUpdateGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(131, 28);
            this.buttonUpdateGroup.TabIndex = 23;
            this.buttonUpdateGroup.Text = "Update Group";
            this.buttonUpdateGroup.UseVisualStyleBackColor = true;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.Location = new System.Drawing.Point(100, 15);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(33, 31);
            this.buttonAddGroup.TabIndex = 24;
            this.buttonAddGroup.Text = "+";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            // 
            // buttonCancelUpdateGroup
            // 
            this.buttonCancelUpdateGroup.Location = new System.Drawing.Point(661, 316);
            this.buttonCancelUpdateGroup.Name = "buttonCancelUpdateGroup";
            this.buttonCancelUpdateGroup.Size = new System.Drawing.Size(131, 23);
            this.buttonCancelUpdateGroup.TabIndex = 25;
            this.buttonCancelUpdateGroup.Text = "Cancel";
            this.buttonCancelUpdateGroup.UseVisualStyleBackColor = true;
            // 
            // ManageGroupTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelUpdateGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.buttonUpdateGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.labelDisabled);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.labelGroupDetail);
            this.Controls.Add(this.buttonRemoveFromGroup);
            this.Controls.Add(this.buttonAddToGroup);
            this.Controls.Add(this.listBoxOtherUsers);
            this.Controls.Add(this.labelOtherUsers);
            this.Controls.Add(this.listBoxGroupMembers);
            this.Controls.Add(this.labelMembers);
            this.Controls.Add(this.buttonFilterGroups);
            this.Controls.Add(this.checkBoxGroupNoMember);
            this.Controls.Add(this.checkBoxShowDisabledGroups);
            this.Controls.Add(this.textBoxSearchGroupName);
            this.Controls.Add(this.labelSearchByGroupName);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.dataGridViewGroups);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageGroupTabControl";
            this.Size = new System.Drawing.Size(880, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Label labelSearchByGroupName;
        private System.Windows.Forms.TextBox textBoxSearchGroupName;
        private System.Windows.Forms.CheckBox checkBoxShowDisabledGroups;
        private System.Windows.Forms.CheckBox checkBoxGroupNoMember;
        private System.Windows.Forms.Button buttonFilterGroups;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.ListBox listBoxGroupMembers;
        private System.Windows.Forms.Label labelOtherUsers;
        private System.Windows.Forms.ListBox listBoxOtherUsers;
        private System.Windows.Forms.Button buttonAddToGroup;
        private System.Windows.Forms.Button buttonRemoveFromGroup;
        private System.Windows.Forms.Label labelGroupDetail;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelDisabled;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonDisabledNo;
        private System.Windows.Forms.RadioButton radioButtonDisabledYes;
        private System.Windows.Forms.Button buttonUpdateGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonCancelUpdateGroup;
    }
}
