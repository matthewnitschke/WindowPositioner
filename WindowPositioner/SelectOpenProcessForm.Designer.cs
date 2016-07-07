namespace WindowPositioner
{
    partial class SelectOpenProcessForm
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
            this.openProcesses = new System.Windows.Forms.ListBox();
            this.selectProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openProcesses
            // 
            this.openProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openProcesses.FormattingEnabled = true;
            this.openProcesses.Location = new System.Drawing.Point(13, 13);
            this.openProcesses.Name = "openProcesses";
            this.openProcesses.Size = new System.Drawing.Size(200, 82);
            this.openProcesses.TabIndex = 0;
            // 
            // selectProcessButton
            // 
            this.selectProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectProcessButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.selectProcessButton.Location = new System.Drawing.Point(138, 101);
            this.selectProcessButton.Name = "selectProcessButton";
            this.selectProcessButton.Size = new System.Drawing.Size(75, 23);
            this.selectProcessButton.TabIndex = 1;
            this.selectProcessButton.Text = "Select";
            this.selectProcessButton.UseVisualStyleBackColor = true;
            // 
            // SelectOpenProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 136);
            this.Controls.Add(this.selectProcessButton);
            this.Controls.Add(this.openProcesses);
            this.Name = "SelectOpenProcessForm";
            this.Text = "SelectOpenProcess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox openProcesses;
        private System.Windows.Forms.Button selectProcessButton;
    }
}