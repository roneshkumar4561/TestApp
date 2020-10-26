namespace TestApp
{
    partial class DisplayLog
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
            this.richTextLog = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextLog
            // 
            this.richTextLog.Location = new System.Drawing.Point(13, 13);
            this.richTextLog.Name = "richTextLog";
            this.richTextLog.Size = new System.Drawing.Size(896, 341);
            this.richTextLog.TabIndex = 0;
            this.richTextLog.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(834, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DisplayLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 413);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTextLog);
            this.Name = "DisplayLog";
            this.Text = "DisplayLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextLog;
        private System.Windows.Forms.Button btnClose;
    }
}