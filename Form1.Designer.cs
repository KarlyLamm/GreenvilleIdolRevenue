namespace GreenvilleRevenueGUI
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
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.lastYeartxt = new System.Windows.Forms.MaskedTextBox();
            this.thisYeartxt = new System.Windows.Forms.TextBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContestants = new System.Windows.Forms.Label();
            this.lblTurnouttxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.Location = new System.Drawing.Point(55, 44);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(182, 13);
            this.lastYearLabel.TabIndex = 0;
            this.lastYearLabel.Text = "Enter number of contestants last year";
            this.lastYearLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.Location = new System.Drawing.Point(58, 75);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(200, 13);
            this.thisYearLabel.TabIndex = 1;
            this.thisYearLabel.Text = "Enter the number of contestants this year";
            // 
            // lastYeartxt
            // 
            this.lastYeartxt.AccessibleName = "txtLastYear";
            this.lastYeartxt.Location = new System.Drawing.Point(258, 44);
            this.lastYeartxt.Name = "lastYeartxt";
            this.lastYeartxt.Size = new System.Drawing.Size(43, 20);
            this.lastYeartxt.TabIndex = 2;
            this.lastYeartxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // thisYeartxt
            // 
            this.thisYeartxt.AccessibleName = "txtThisYear";
            this.thisYeartxt.Location = new System.Drawing.Point(258, 75);
            this.thisYeartxt.Name = "thisYeartxt";
            this.thisYeartxt.Size = new System.Drawing.Size(42, 20);
            this.thisYeartxt.TabIndex = 3;
            // 
            // btnRevenue
            // 
            this.btnRevenue.AccessibleName = "btnRevenue";
            this.btnRevenue.Location = new System.Drawing.Point(88, 111);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(162, 23);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "Display data";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(85, 194);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(35, 13);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.Text = "label1";
            this.lblResponse.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lblContestants
            // 
            this.lblContestants.AutoSize = true;
            this.lblContestants.Location = new System.Drawing.Point(85, 158);
            this.lblContestants.Name = "lblContestants";
            this.lblContestants.Size = new System.Drawing.Size(35, 13);
            this.lblContestants.TabIndex = 7;
            this.lblContestants.Text = "label2";
            // 
            // lblTurnouttxt
            // 
            this.lblTurnouttxt.AutoSize = true;
            this.lblTurnouttxt.Location = new System.Drawing.Point(85, 231);
            this.lblTurnouttxt.Name = "lblTurnouttxt";
            this.lblTurnouttxt.Size = new System.Drawing.Size(35, 13);
            this.lblTurnouttxt.TabIndex = 8;
            this.lblTurnouttxt.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTurnouttxt);
            this.Controls.Add(this.lblContestants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.thisYeartxt);
            this.Controls.Add(this.lastYeartxt);
            this.Controls.Add(this.thisYearLabel);
            this.Controls.Add(this.lastYearLabel);
            this.Name = "Form1";
            this.Text = "Greenville Idol Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastYearLabel;
        private System.Windows.Forms.Label thisYearLabel;
        private System.Windows.Forms.MaskedTextBox lastYeartxt;
        private System.Windows.Forms.TextBox thisYeartxt;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContestants;
        private System.Windows.Forms.Label lblTurnouttxt;
    }
}

