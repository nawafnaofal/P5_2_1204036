﻿namespace P5_2_XXXXXXX_TestClock
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
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.digitalClock2 = new P5_2_1204036.DigitalClock();
            this.digitalClock1 = new P5_2_1204036.DigitalClock();
            this.SuspendLayout();
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.AutoSize = true;
            this.UniversalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversalTimeLabel.Location = new System.Drawing.Point(19, 117);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(95, 13);
            this.UniversalTimeLabel.TabIndex = 1;
            this.UniversalTimeLabel.Text = "Uneversal Time";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(231, 179);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 2;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Label";
            // 
            // digitalClock2
            // 
            this.digitalClock2.LocalTimeLabel_BackColor = System.Drawing.SystemColors.ControlDark;
            this.digitalClock2.Location = new System.Drawing.Point(188, 94);
            this.digitalClock2.Name = "digitalClock2";
            this.digitalClock2.Size = new System.Drawing.Size(130, 45);
            this.digitalClock2.TabIndex = 4;
            this.digitalClock2.Timer1_Enabled = false;
            // 
            // digitalClock1
            // 
            this.digitalClock1.LocalTimeLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalClock1.Location = new System.Drawing.Point(188, 46);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(130, 42);
            this.digitalClock1.TabIndex = 0;
            this.digitalClock1.Timer1_Enabled = false;
            this.digitalClock1.RaiseTimer1_Tick += new System.EventHandler(this.digitalClock1_RaiseTimer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.digitalClock2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.digitalClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private P5_2_1204036.DigitalClock digitalClock1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Label label1;
        private P5_2_1204036.DigitalClock digitalClock2;
    }
}

