using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyslogTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            var config = new NLog.Config.LoggingConfiguration();
            var logServerTarget = new NLog.Targets.Syslog.SyslogTarget();
            logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local1;
            logServerTarget.MessageCreation.Rfc = NLog.Targets.Syslog.Settings.RfcNumber.Rfc5424;
            logServerTarget.MessageCreation.Rfc5424.AppName = "SyslogTester";
            logServerTarget.MessageCreation.Rfc5424.Hostname = "${machinename}";
            logServerTarget.MessageSend.Udp.Server = "127.0.0.1";
            logServerTarget.MessageSend.Udp.Port = 514;
            logServerTarget.Name = "*";
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logServerTarget);

            NLog.LogManager.Configuration = config;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void updateDestination()
        {
            var syslogServer = textBoxHostname.Text;
            var syslogPort = 514;

            try
            {
                syslogPort = int.Parse(textBoxPort.Text);
            } catch (Exception ex)
            {
                labelStatusBar.Text = "Error when parsing port";
                textBoxPort.Text = "514";
                syslogPort = 514;
            }

            var config = new NLog.Config.LoggingConfiguration();
            var logServerTarget = new NLog.Targets.Syslog.SyslogTarget();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local0;
                    break;

                case 1:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local1;
                    break;

                case 2:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local2;
                    break;

                case 3:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local3;
                    break;

                case 4:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local4;
                    break;

                case 5:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local5;
                    break;

                case 6:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local6;
                    break;

                case 7:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local7;
                    break;

                default:
                    logServerTarget.MessageCreation.Facility = NLog.Targets.Syslog.Settings.Facility.Local0;
                    break;
            }


            logServerTarget.MessageCreation.Rfc = NLog.Targets.Syslog.Settings.RfcNumber.Rfc5424;
            logServerTarget.MessageCreation.Rfc5424.AppName = "SyslogTester";
            logServerTarget.MessageCreation.Rfc5424.Hostname = "${machinename}";
            logServerTarget.MessageSend.Udp.Server = syslogServer;
            logServerTarget.MessageSend.Udp.Port = syslogPort;
            logServerTarget.Name = "*";
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logServerTarget);

            NLog.LogManager.Configuration = config;
        }

        private void textBoxHostname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateDestination();

            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info(textBoxMessage.ToString);
            labelStatusBar.Text = "Message sent";
        }


    }
}
