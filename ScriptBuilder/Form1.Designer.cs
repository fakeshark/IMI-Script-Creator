namespace ScriptBuilder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblImportedTM = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTopLevelTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxParaList = new System.Windows.Forms.ListBox();
            this.gbxWorkArea = new System.Windows.Forms.GroupBox();
            this.cbxlstStructure = new System.Windows.Forms.ListBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblTagsStructure = new System.Windows.Forms.Label();
            this.btnExtractParas = new System.Windows.Forms.Button();
            this.gbxPreview = new System.Windows.Forms.GroupBox();
            this.rtbTest = new System.Windows.Forms.RichTextBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gbxData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxWorkArea.SuspendLayout();
            this.gbxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.btnViewSource);
            this.gbxData.Controls.Add(this.btnImport);
            this.gbxData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxData.Location = new System.Drawing.Point(0, 24);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(1188, 110);
            this.gbxData.TabIndex = 0;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Unsaved Project - Data:";
            // 
            // btnViewSource
            // 
            this.btnViewSource.Location = new System.Drawing.Point(18, 62);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(87, 29);
            this.btnViewSource.TabIndex = 2;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.BtnViewSource_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(18, 27);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(87, 29);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import TM";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // lblImportedTM
            // 
            this.lblImportedTM.AutoSize = true;
            this.lblImportedTM.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblImportedTM.Location = new System.Drawing.Point(179, 8);
            this.lblImportedTM.Name = "lblImportedTM";
            this.lblImportedTM.Size = new System.Drawing.Size(70, 13);
            this.lblImportedTM.TabIndex = 0;
            this.lblImportedTM.Text = "Imported File:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTMToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.exportScriptToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.closeProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importTMToolStripMenuItem
            // 
            this.importTMToolStripMenuItem.Name = "importTMToolStripMenuItem";
            this.importTMToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.importTMToolStripMenuItem.Text = "Import TM";
            this.importTMToolStripMenuItem.Click += new System.EventHandler(this.ImportTMToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // exportScriptToolStripMenuItem
            // 
            this.exportScriptToolStripMenuItem.Name = "exportScriptToolStripMenuItem";
            this.exportScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exportScriptToolStripMenuItem.Text = "Export Script";
            this.exportScriptToolStripMenuItem.Click += new System.EventHandler(this.ExportScriptToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setTopLevelTagToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // setTopLevelTagToolStripMenuItem
            // 
            this.setTopLevelTagToolStripMenuItem.Name = "setTopLevelTagToolStripMenuItem";
            this.setTopLevelTagToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setTopLevelTagToolStripMenuItem.Text = "Set top level tag";
            this.setTopLevelTagToolStripMenuItem.Click += new System.EventHandler(this.SetTopLevelTagToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // lbxParaList
            // 
            this.lbxParaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxParaList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxParaList.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbxParaList.FormattingEnabled = true;
            this.lbxParaList.ItemHeight = 18;
            this.lbxParaList.Location = new System.Drawing.Point(255, 51);
            this.lbxParaList.Name = "lbxParaList";
            this.lbxParaList.Size = new System.Drawing.Size(524, 344);
            this.lbxParaList.TabIndex = 2;
            this.lbxParaList.DoubleClick += new System.EventHandler(this.LbxParaList_DoubleClick);
            // 
            // gbxWorkArea
            // 
            this.gbxWorkArea.Controls.Add(this.label1);
            this.gbxWorkArea.Controls.Add(this.cbxlstStructure);
            this.gbxWorkArea.Controls.Add(this.lblSteps);
            this.gbxWorkArea.Controls.Add(this.lblTagsStructure);
            this.gbxWorkArea.Controls.Add(this.btnExtractParas);
            this.gbxWorkArea.Controls.Add(this.gbxPreview);
            this.gbxWorkArea.Controls.Add(this.lbxParaList);
            this.gbxWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxWorkArea.Location = new System.Drawing.Point(0, 134);
            this.gbxWorkArea.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.gbxWorkArea.Name = "gbxWorkArea";
            this.gbxWorkArea.Size = new System.Drawing.Size(1188, 470);
            this.gbxWorkArea.TabIndex = 3;
            this.gbxWorkArea.TabStop = false;
            this.gbxWorkArea.Text = "Default";
            // 
            // cbxlstStructure
            // 
            this.cbxlstStructure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxlstStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxlstStructure.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxlstStructure.FormattingEnabled = true;
            this.cbxlstStructure.ItemHeight = 18;
            this.cbxlstStructure.Location = new System.Drawing.Point(18, 51);
            this.cbxlstStructure.Name = "cbxlstStructure";
            this.cbxlstStructure.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cbxlstStructure.Size = new System.Drawing.Size(231, 344);
            this.cbxlstStructure.TabIndex = 10;
            this.cbxlstStructure.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbxlstStructure_MouseDoubleClick);
            // 
            // lblSteps
            // 
            this.lblSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(252, 35);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(85, 13);
            this.lblSteps.TabIndex = 9;
            this.lblSteps.Text = "Extracted Steps:";
            // 
            // lblTagsStructure
            // 
            this.lblTagsStructure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTagsStructure.AutoSize = true;
            this.lblTagsStructure.Location = new System.Drawing.Point(15, 35);
            this.lblTagsStructure.Name = "lblTagsStructure";
            this.lblTagsStructure.Size = new System.Drawing.Size(94, 13);
            this.lblTagsStructure.TabIndex = 8;
            this.lblTagsStructure.Text = "TM Tag Structure:";
            // 
            // btnExtractParas
            // 
            this.btnExtractParas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtractParas.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnExtractParas.FlatAppearance.BorderSize = 2;
            this.btnExtractParas.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExtractParas.Location = new System.Drawing.Point(195, 401);
            this.btnExtractParas.Name = "btnExtractParas";
            this.btnExtractParas.Size = new System.Drawing.Size(113, 26);
            this.btnExtractParas.TabIndex = 6;
            this.btnExtractParas.Text = "❱❱❱";
            this.btnExtractParas.UseVisualStyleBackColor = false;
            this.btnExtractParas.Click += new System.EventHandler(this.btnExtractParas_Click);
            // 
            // gbxPreview
            // 
            this.gbxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPreview.Controls.Add(this.rtbTest);
            this.gbxPreview.Location = new System.Drawing.Point(785, 26);
            this.gbxPreview.Name = "gbxPreview";
            this.gbxPreview.Size = new System.Drawing.Size(378, 414);
            this.gbxPreview.TabIndex = 4;
            this.gbxPreview.TabStop = false;
            this.gbxPreview.Text = "Script Preview:";
            // 
            // rtbTest
            // 
            this.rtbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTest.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTest.Location = new System.Drawing.Point(20, 33);
            this.rtbTest.Name = "rtbTest";
            this.rtbTest.Size = new System.Drawing.Size(338, 343);
            this.rtbTest.TabIndex = 0;
            this.rtbTest.Text = "";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ScriptBuilder.Form1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Extract steps from selected TM sections";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 604);
            this.Controls.Add(this.gbxWorkArea);
            this.Controls.Add(this.lblImportedTM);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TRG IMI Script Builder";
            this.gbxData.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxWorkArea.ResumeLayout(false);
            this.gbxWorkArea.PerformLayout();
            this.gbxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.Label lblImportedTM;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxParaList;
        private System.Windows.Forms.GroupBox gbxWorkArea;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox gbxPreview;
        private System.Windows.Forms.Button btnExtractParas;
        private System.Windows.Forms.RichTextBox rtbTest;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblTagsStructure;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.ToolStripMenuItem setTopLevelTagToolStripMenuItem;
        private System.Windows.Forms.ListBox cbxlstStructure;
        private System.Windows.Forms.Label label1;
    }
}

