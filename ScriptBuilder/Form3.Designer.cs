namespace ScriptBuilder
{
    partial class Form3
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
            this.rtbSourceView = new System.Windows.Forms.RichTextBox();
            this.btnViewClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSourceView
            // 
            this.rtbSourceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSourceView.Location = new System.Drawing.Point(12, 34);
            this.rtbSourceView.Name = "rtbSourceView";
            this.rtbSourceView.Size = new System.Drawing.Size(964, 523);
            this.rtbSourceView.TabIndex = 0;
            this.rtbSourceView.Text = "";
            // 
            // btnViewClose
            // 
            this.btnViewClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewClose.Location = new System.Drawing.Point(452, 566);
            this.btnViewClose.Name = "btnViewClose";
            this.btnViewClose.Size = new System.Drawing.Size(75, 34);
            this.btnViewClose.TabIndex = 1;
            this.btnViewClose.Text = "Close";
            this.btnViewClose.UseVisualStyleBackColor = true;
            this.btnViewClose.Click += new System.EventHandler(this.btnViewClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.btnViewClose);
            this.Controls.Add(this.rtbSourceView);
            this.Name = "Form3";
            this.Text = "View Source";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourceView;
        private System.Windows.Forms.Button btnViewClose;
    }
}