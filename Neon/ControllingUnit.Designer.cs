﻿namespace Neon
{
    partial class ControllingUnit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllingUnit));
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Direction_bar = new System.Windows.Forms.TrackBar();
            this.Engine_status = new System.Windows.Forms.Label();
            this.Port_txt = new System.Windows.Forms.TextBox();
            this.Connected_lbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Battery = new System.Windows.Forms.ProgressBar();
            this.Battery_checker = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Direction_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(285, 5);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(100, 28);
            this.Connect_btn.TabIndex = 0;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Engine Status:";
            // 
            // Direction_bar
            // 
            this.Direction_bar.Location = new System.Drawing.Point(124, 82);
            this.Direction_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Direction_bar.Maximum = 2;
            this.Direction_bar.Name = "Direction_bar";
            this.Direction_bar.Size = new System.Drawing.Size(296, 56);
            this.Direction_bar.TabIndex = 3;
            this.Direction_bar.Value = 1;
            this.Direction_bar.ValueChanged += new System.EventHandler(this.Direction_bar_ValueChanged);
            // 
            // Engine_status
            // 
            this.Engine_status.AutoSize = true;
            this.Engine_status.Location = new System.Drawing.Point(189, 47);
            this.Engine_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Engine_status.Name = "Engine_status";
            this.Engine_status.Size = new System.Drawing.Size(35, 17);
            this.Engine_status.TabIndex = 4;
            this.Engine_status.Text = "OFF";
            // 
            // Port_txt
            // 
            this.Port_txt.Location = new System.Drawing.Point(132, 7);
            this.Port_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Port_txt.Name = "Port_txt";
            this.Port_txt.Size = new System.Drawing.Size(132, 22);
            this.Port_txt.TabIndex = 5;
            this.Port_txt.Text = "4";
            // 
            // Connected_lbl
            // 
            this.Connected_lbl.AutoSize = true;
            this.Connected_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connected_lbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.Connected_lbl.Location = new System.Drawing.Point(281, 47);
            this.Connected_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Connected_lbl.Name = "Connected_lbl";
            this.Connected_lbl.Size = new System.Drawing.Size(89, 17);
            this.Connected_lbl.TabIndex = 6;
            this.Connected_lbl.Text = "Connected!";
            this.Connected_lbl.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(410, 175);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Battery
            // 
            this.Battery.Location = new System.Drawing.Point(124, 130);
            this.Battery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Battery.Maximum = 8000;
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(296, 28);
            this.Battery.TabIndex = 9;
            // 
            // Battery_checker
            // 
            this.Battery_checker.Tick += new System.EventHandler(this.Battary_checker_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Neon Direction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Battery Level:";
            // 
            // ControllingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Battery);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Connected_lbl);
            this.Controls.Add(this.Port_txt);
            this.Controls.Add(this.Engine_status);
            this.Controls.Add(this.Direction_bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ControllingUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neon";
            ((System.ComponentModel.ISupportInitialize)(this.Direction_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Direction_bar;
        private System.Windows.Forms.Label Engine_status;
        private System.Windows.Forms.TextBox Port_txt;
        private System.Windows.Forms.Label Connected_lbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar Battery;
        private System.Windows.Forms.Timer Battery_checker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

