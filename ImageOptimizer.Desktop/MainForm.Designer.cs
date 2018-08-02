namespace ImageOptimizer.Desktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSourceSelect = new System.Windows.Forms.Button();
            this.btnOutputFolderSelect = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.chkQuality = new System.Windows.Forms.CheckBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Folder:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(130, 50);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(336, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(130, 88);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(336, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // btnSourceSelect
            // 
            this.btnSourceSelect.Location = new System.Drawing.Point(472, 47);
            this.btnSourceSelect.Name = "btnSourceSelect";
            this.btnSourceSelect.Size = new System.Drawing.Size(34, 23);
            this.btnSourceSelect.TabIndex = 4;
            this.btnSourceSelect.Text = "...";
            this.btnSourceSelect.UseVisualStyleBackColor = true;
            this.btnSourceSelect.Click += new System.EventHandler(this.btnSourceSelect_Click);
            // 
            // btnOutputFolderSelect
            // 
            this.btnOutputFolderSelect.Location = new System.Drawing.Point(472, 86);
            this.btnOutputFolderSelect.Name = "btnOutputFolderSelect";
            this.btnOutputFolderSelect.Size = new System.Drawing.Size(34, 23);
            this.btnOutputFolderSelect.TabIndex = 5;
            this.btnOutputFolderSelect.Text = "...";
            this.btnOutputFolderSelect.UseVisualStyleBackColor = true;
            this.btnOutputFolderSelect.Click += new System.EventHandler(this.btnOutputFolderSelect_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(202, 151);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(167, 23);
            this.btnCompress.TabIndex = 6;
            this.btnCompress.Text = "Compress Image";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // chkQuality
            // 
            this.chkQuality.AutoSize = true;
            this.chkQuality.Location = new System.Drawing.Point(53, 124);
            this.chkQuality.Name = "chkQuality";
            this.chkQuality.Size = new System.Drawing.Size(58, 17);
            this.chkQuality.TabIndex = 7;
            this.chkQuality.Text = "Quality";
            this.chkQuality.UseVisualStyleBackColor = true;
            this.chkQuality.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(130, 122);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 20);
            this.txtQuality.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 422);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.chkQuality);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnOutputFolderSelect);
            this.Controls.Add(this.btnSourceSelect);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSourceSelect;
        private System.Windows.Forms.Button btnOutputFolderSelect;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.CheckBox chkQuality;
        private System.Windows.Forms.TextBox txtQuality;
    }
}

