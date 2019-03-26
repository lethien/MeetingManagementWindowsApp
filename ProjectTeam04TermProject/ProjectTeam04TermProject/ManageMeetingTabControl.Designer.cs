namespace ProjectTeam04TermProject
{
    partial class ManageMeetingTabControl
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
            this.labelCreatedMeetings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCreatedMeetings
            // 
            this.labelCreatedMeetings.AutoSize = true;
            this.labelCreatedMeetings.Location = new System.Drawing.Point(18, 19);
            this.labelCreatedMeetings.Name = "labelCreatedMeetings";
            this.labelCreatedMeetings.Size = new System.Drawing.Size(115, 17);
            this.labelCreatedMeetings.TabIndex = 0;
            this.labelCreatedMeetings.Text = "CreatedMeetings";
            // 
            // ManageMeetingTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCreatedMeetings);
            this.Name = "ManageMeetingTabControl";
            this.Size = new System.Drawing.Size(880, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatedMeetings;
    }
}
