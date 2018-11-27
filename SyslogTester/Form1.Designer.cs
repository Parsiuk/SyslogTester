﻿namespace SyslogTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelStatusBar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(78, 42);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(268, 20);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = "Test message";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(78, 14);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(176, 20);
            this.textBoxHostname.TabIndex = 4;
            this.textBoxHostname.Text = "127.0.0.1";
            this.textBoxHostname.TextChanged += new System.EventHandler(this.textBoxHostname_TextChanged);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(260, 14);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(85, 20);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "514";
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelStatusBar
            // 
            this.labelStatusBar.AutoSize = true;
            this.labelStatusBar.Location = new System.Drawing.Point(12, 73);
            this.labelStatusBar.Name = "labelStatusBar";
            this.labelStatusBar.Size = new System.Drawing.Size(37, 13);
            this.labelStatusBar.TabIndex = 7;
            this.labelStatusBar.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "local0",
            "local1",
            "local2",
            "local3",
            "local4",
            "local5",
            "local6",
            "local7"});
            this.comboBox1.Location = new System.Drawing.Point(352, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 109);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelStatusBar);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxHostname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 148);
            this.MinimumSize = new System.Drawing.Size(512, 148);
            this.Name = "Form1";
            this.Text = "Syslog Tester v0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelStatusBar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

