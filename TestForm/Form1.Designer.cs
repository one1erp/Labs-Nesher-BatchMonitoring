﻿namespace TestForm
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
            this.batchMonitoring1 = new BatchMonitoring.BatchMonitoring();
            this.SuspendLayout();
            // 
            // batchMonitoring1
            // 
            this.batchMonitoring1.BackColor = System.Drawing.SystemColors.Control;
            this.batchMonitoring1.Location = new System.Drawing.Point(49, 24);
            this.batchMonitoring1.Margin = new System.Windows.Forms.Padding(4);
            this.batchMonitoring1.Name = "batchMonitoring1";
            this.batchMonitoring1.Size = new System.Drawing.Size(995, 791);
            this.batchMonitoring1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 877);
            this.Controls.Add(this.batchMonitoring1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BatchMonitoring.BatchMonitoring batchMonitoring1;

    }
}

