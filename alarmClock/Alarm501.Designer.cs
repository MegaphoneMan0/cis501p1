namespace alarmClock
{
    partial class Alarm501
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(49, 83);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 62);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.Location = new System.Drawing.Point(312, 82);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(134, 62);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // snoozeButton
            // 
            this.snoozeButton.Enabled = false;
            this.snoozeButton.Location = new System.Drawing.Point(49, 475);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(134, 62);
            this.snoozeButton.TabIndex = 0;
            this.snoozeButton.Text = "snooze";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(310, 476);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(134, 62);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(49, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 319);
            this.listBox1.TabIndex = 1;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 594);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.editButton);
            this.Name = "Alarm501";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

