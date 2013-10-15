namespace Vehicle_investigation_system
{
    partial class NEW
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
            this.button1 = new System.Windows.Forms.Button();
            this.CHECK = new System.Windows.Forms.Button();
            this.CHANGE = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.REGISTER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO CAB BOOKING SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(215, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEW REGISTRATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHECK
            // 
            this.CHECK.AllowDrop = true;
            this.CHECK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CHECK.Location = new System.Drawing.Point(215, 175);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(321, 23);
            this.CHECK.TabIndex = 2;
            this.CHECK.Text = "CHECK REGISTRATION NO";
            this.CHECK.UseVisualStyleBackColor = true;
            this.CHECK.Click += new System.EventHandler(this.CHECK_Click);
            // 
            // CHANGE
            // 
            this.CHANGE.AllowDrop = true;
            this.CHANGE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CHANGE.Location = new System.Drawing.Point(215, 273);
            this.CHANGE.Name = "CHANGE";
            this.CHANGE.Size = new System.Drawing.Size(321, 23);
            this.CHANGE.TabIndex = 3;
            this.CHANGE.Text = "CHANGE OWNER DETAILS";
            this.CHANGE.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(189, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 4;
            this.button4.Text = "NEW REGISTRATION";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // REGISTER
            // 
            this.REGISTER.AllowDrop = true;
            this.REGISTER.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.REGISTER.Location = new System.Drawing.Point(215, 227);
            this.REGISTER.Name = "REGISTER";
            this.REGISTER.Size = new System.Drawing.Size(321, 23);
            this.REGISTER.TabIndex = 5;
            this.REGISTER.Text = "REGISTER COMPLAINT";
            this.REGISTER.UseVisualStyleBackColor = true;
            // 
            // NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 525);
            this.Controls.Add(this.REGISTER);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CHANGE);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "NEW";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CHECK;
        private System.Windows.Forms.Button CHANGE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button REGISTER;
    }
}