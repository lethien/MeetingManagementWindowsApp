namespace ProjectTeam04TermProject
{
    partial class XMLTabControl
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
            this.labelExportToXML = new System.Windows.Forms.Label();
            this.buttonExportXML = new System.Windows.Forms.Button();
            this.labelImportXML = new System.Windows.Forms.Label();
            this.buttonImportXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExportToXML
            // 
            this.labelExportToXML.AutoSize = true;
            this.labelExportToXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportToXML.Location = new System.Drawing.Point(3, 40);
            this.labelExportToXML.Name = "labelExportToXML";
            this.labelExportToXML.Size = new System.Drawing.Size(177, 16);
            this.labelExportToXML.TabIndex = 0;
            this.labelExportToXML.Text = "Export Database to XML File";
            // 
            // buttonExportXML
            // 
            this.buttonExportXML.Location = new System.Drawing.Point(260, 23);
            this.buttonExportXML.Name = "buttonExportXML";
            this.buttonExportXML.Size = new System.Drawing.Size(100, 50);
            this.buttonExportXML.TabIndex = 1;
            this.buttonExportXML.Text = "Export";
            this.buttonExportXML.UseVisualStyleBackColor = true;
            // 
            // labelImportXML
            // 
            this.labelImportXML.AutoSize = true;
            this.labelImportXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportXML.Location = new System.Drawing.Point(3, 152);
            this.labelImportXML.Name = "labelImportXML";
            this.labelImportXML.Size = new System.Drawing.Size(191, 16);
            this.labelImportXML.TabIndex = 2;
            this.labelImportXML.Text = "Import Database from XML File";
            // 
            // buttonImportXML
            // 
            this.buttonImportXML.Location = new System.Drawing.Point(260, 135);
            this.buttonImportXML.Name = "buttonImportXML";
            this.buttonImportXML.Size = new System.Drawing.Size(100, 50);
            this.buttonImportXML.TabIndex = 3;
            this.buttonImportXML.Text = "Import";
            this.buttonImportXML.UseVisualStyleBackColor = true;
            // 
            // XMLTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonImportXML);
            this.Controls.Add(this.labelImportXML);
            this.Controls.Add(this.buttonExportXML);
            this.Controls.Add(this.labelExportToXML);
            this.Name = "XMLTabControl";
            this.Size = new System.Drawing.Size(660, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExportToXML;
        private System.Windows.Forms.Button buttonExportXML;
        private System.Windows.Forms.Label labelImportXML;
        private System.Windows.Forms.Button buttonImportXML;
    }
}
