namespace TestApp
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
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDrugQuantity1 = new System.Windows.Forms.Label();
            this.lblDrugName1 = new System.Windows.Forms.Label();
            this.btnCounter1 = new System.Windows.Forms.Button();
            this.lblDrugQuantityPlaceholder1 = new System.Windows.Forms.Label();
            this.lblDrugNamePlaceholder1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDrugQuantity2 = new System.Windows.Forms.Label();
            this.lblDrugName2 = new System.Windows.Forms.Label();
            this.btnCounter2 = new System.Windows.Forms.Button();
            this.lblDrugQuantityPlaceholder2 = new System.Windows.Forms.Label();
            this.lblDrugNamePlaceholder2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDrugQuantity3 = new System.Windows.Forms.Label();
            this.lblDrugName3 = new System.Windows.Forms.Label();
            this.btnCounter3 = new System.Windows.Forms.Button();
            this.lblDrugQuantityPlaceholder3 = new System.Windows.Forms.Label();
            this.lblDrugNamePlaceholder3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(20, 200);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(115, 37);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Display Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(141, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDrugQuantity1);
            this.groupBox1.Controls.Add(this.lblDrugName1);
            this.groupBox1.Controls.Add(this.btnCounter1);
            this.groupBox1.Controls.Add(this.lblDrugQuantityPlaceholder1);
            this.groupBox1.Controls.Add(this.lblDrugNamePlaceholder1);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group1";
            // 
            // lblDrugQuantity1
            // 
            this.lblDrugQuantity1.AutoSize = true;
            this.lblDrugQuantity1.Location = new System.Drawing.Point(76, 61);
            this.lblDrugQuantity1.Name = "lblDrugQuantity1";
            this.lblDrugQuantity1.Size = new System.Drawing.Size(16, 17);
            this.lblDrugQuantity1.TabIndex = 8;
            this.lblDrugQuantity1.Text = "0";
            // 
            // lblDrugName1
            // 
            this.lblDrugName1.AutoSize = true;
            this.lblDrugName1.Location = new System.Drawing.Point(76, 34);
            this.lblDrugName1.Name = "lblDrugName1";
            this.lblDrugName1.Size = new System.Drawing.Size(106, 17);
            this.lblDrugName1.TabIndex = 7;
            this.lblDrugName1.Text = "Acetaminophen";
            // 
            // btnCounter1
            // 
            this.btnCounter1.Location = new System.Drawing.Point(9, 97);
            this.btnCounter1.Name = "btnCounter1";
            this.btnCounter1.Size = new System.Drawing.Size(91, 37);
            this.btnCounter1.TabIndex = 6;
            this.btnCounter1.Text = "Increment";
            this.btnCounter1.UseVisualStyleBackColor = true;
            this.btnCounter1.Click += new System.EventHandler(this.btnCounter1_Click);
            // 
            // lblDrugQuantityPlaceholder1
            // 
            this.lblDrugQuantityPlaceholder1.AutoSize = true;
            this.lblDrugQuantityPlaceholder1.Location = new System.Drawing.Point(6, 60);
            this.lblDrugQuantityPlaceholder1.Name = "lblDrugQuantityPlaceholder1";
            this.lblDrugQuantityPlaceholder1.Size = new System.Drawing.Size(65, 17);
            this.lblDrugQuantityPlaceholder1.TabIndex = 1;
            this.lblDrugQuantityPlaceholder1.Text = "Quantity:";
            // 
            // lblDrugNamePlaceholder1
            // 
            this.lblDrugNamePlaceholder1.AutoSize = true;
            this.lblDrugNamePlaceholder1.Location = new System.Drawing.Point(6, 32);
            this.lblDrugNamePlaceholder1.Name = "lblDrugNamePlaceholder1";
            this.lblDrugNamePlaceholder1.Size = new System.Drawing.Size(49, 17);
            this.lblDrugNamePlaceholder1.TabIndex = 0;
            this.lblDrugNamePlaceholder1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDrugQuantity2);
            this.groupBox2.Controls.Add(this.lblDrugName2);
            this.groupBox2.Controls.Add(this.btnCounter2);
            this.groupBox2.Controls.Add(this.lblDrugQuantityPlaceholder2);
            this.groupBox2.Controls.Add(this.lblDrugNamePlaceholder2);
            this.groupBox2.Location = new System.Drawing.Point(244, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group 2";
            // 
            // lblDrugQuantity2
            // 
            this.lblDrugQuantity2.AutoSize = true;
            this.lblDrugQuantity2.Location = new System.Drawing.Point(75, 59);
            this.lblDrugQuantity2.Name = "lblDrugQuantity2";
            this.lblDrugQuantity2.Size = new System.Drawing.Size(16, 17);
            this.lblDrugQuantity2.TabIndex = 10;
            this.lblDrugQuantity2.Text = "0";
            // 
            // lblDrugName2
            // 
            this.lblDrugName2.AutoSize = true;
            this.lblDrugName2.Location = new System.Drawing.Point(75, 32);
            this.lblDrugName2.Name = "lblDrugName2";
            this.lblDrugName2.Size = new System.Drawing.Size(62, 17);
            this.lblDrugName2.TabIndex = 9;
            this.lblDrugName2.Text = "Oxycotin";
            // 
            // btnCounter2
            // 
            this.btnCounter2.Location = new System.Drawing.Point(9, 97);
            this.btnCounter2.Name = "btnCounter2";
            this.btnCounter2.Size = new System.Drawing.Size(91, 37);
            this.btnCounter2.TabIndex = 6;
            this.btnCounter2.Text = "Increment";
            this.btnCounter2.UseVisualStyleBackColor = true;
            this.btnCounter2.Click += new System.EventHandler(this.btnCounter2_Click);
            // 
            // lblDrugQuantityPlaceholder2
            // 
            this.lblDrugQuantityPlaceholder2.AutoSize = true;
            this.lblDrugQuantityPlaceholder2.Location = new System.Drawing.Point(6, 60);
            this.lblDrugQuantityPlaceholder2.Name = "lblDrugQuantityPlaceholder2";
            this.lblDrugQuantityPlaceholder2.Size = new System.Drawing.Size(65, 17);
            this.lblDrugQuantityPlaceholder2.TabIndex = 1;
            this.lblDrugQuantityPlaceholder2.Text = "Quantity:";
            // 
            // lblDrugNamePlaceholder2
            // 
            this.lblDrugNamePlaceholder2.AutoSize = true;
            this.lblDrugNamePlaceholder2.Location = new System.Drawing.Point(6, 32);
            this.lblDrugNamePlaceholder2.Name = "lblDrugNamePlaceholder2";
            this.lblDrugNamePlaceholder2.Size = new System.Drawing.Size(49, 17);
            this.lblDrugNamePlaceholder2.TabIndex = 0;
            this.lblDrugNamePlaceholder2.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDrugQuantity3);
            this.groupBox3.Controls.Add(this.lblDrugName3);
            this.groupBox3.Controls.Add(this.btnCounter3);
            this.groupBox3.Controls.Add(this.lblDrugQuantityPlaceholder3);
            this.groupBox3.Controls.Add(this.lblDrugNamePlaceholder3);
            this.groupBox3.Location = new System.Drawing.Point(466, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 159);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group 3";
            // 
            // lblDrugQuantity3
            // 
            this.lblDrugQuantity3.AutoSize = true;
            this.lblDrugQuantity3.Location = new System.Drawing.Point(75, 60);
            this.lblDrugQuantity3.Name = "lblDrugQuantity3";
            this.lblDrugQuantity3.Size = new System.Drawing.Size(16, 17);
            this.lblDrugQuantity3.TabIndex = 12;
            this.lblDrugQuantity3.Text = "0";
            // 
            // lblDrugName3
            // 
            this.lblDrugName3.AutoSize = true;
            this.lblDrugName3.Location = new System.Drawing.Point(75, 33);
            this.lblDrugName3.Name = "lblDrugName3";
            this.lblDrugName3.Size = new System.Drawing.Size(68, 17);
            this.lblDrugName3.TabIndex = 11;
            this.lblDrugName3.Text = "Ibuprofen";
            // 
            // btnCounter3
            // 
            this.btnCounter3.Location = new System.Drawing.Point(9, 97);
            this.btnCounter3.Name = "btnCounter3";
            this.btnCounter3.Size = new System.Drawing.Size(91, 37);
            this.btnCounter3.TabIndex = 6;
            this.btnCounter3.Text = "Increment";
            this.btnCounter3.UseVisualStyleBackColor = true;
            this.btnCounter3.Click += new System.EventHandler(this.btnCounter3_Click);
            // 
            // lblDrugQuantityPlaceholder3
            // 
            this.lblDrugQuantityPlaceholder3.AutoSize = true;
            this.lblDrugQuantityPlaceholder3.Location = new System.Drawing.Point(6, 60);
            this.lblDrugQuantityPlaceholder3.Name = "lblDrugQuantityPlaceholder3";
            this.lblDrugQuantityPlaceholder3.Size = new System.Drawing.Size(65, 17);
            this.lblDrugQuantityPlaceholder3.TabIndex = 1;
            this.lblDrugQuantityPlaceholder3.Text = "Quantity:";
            // 
            // lblDrugNamePlaceholder3
            // 
            this.lblDrugNamePlaceholder3.AutoSize = true;
            this.lblDrugNamePlaceholder3.Location = new System.Drawing.Point(6, 32);
            this.lblDrugNamePlaceholder3.Name = "lblDrugNamePlaceholder3";
            this.lblDrugNamePlaceholder3.Size = new System.Drawing.Size(49, 17);
            this.lblDrugNamePlaceholder3.TabIndex = 0;
            this.lblDrugNamePlaceholder3.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 259);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCounter1;
        private System.Windows.Forms.Label lblDrugQuantityPlaceholder1;
        private System.Windows.Forms.Label lblDrugNamePlaceholder1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCounter2;
        private System.Windows.Forms.Label lblDrugQuantityPlaceholder2;
        private System.Windows.Forms.Label lblDrugNamePlaceholder2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCounter3;
        private System.Windows.Forms.Label lblDrugQuantityPlaceholder3;
        private System.Windows.Forms.Label lblDrugNamePlaceholder3;
        private System.Windows.Forms.Label lblDrugQuantity1;
        private System.Windows.Forms.Label lblDrugName1;
        private System.Windows.Forms.Label lblDrugQuantity2;
        private System.Windows.Forms.Label lblDrugName2;
        private System.Windows.Forms.Label lblDrugQuantity3;
        private System.Windows.Forms.Label lblDrugName3;
    }
}