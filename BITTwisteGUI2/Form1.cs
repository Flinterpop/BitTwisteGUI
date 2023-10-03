using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace BITTwisteGUI2
{
    public partial class Form1 : Form
    {

        string argument = "-I impact-gmti.pcap -O TEMP.PCAP -T ip -s 172.16.10.180,172.16.10.180 -d 234.3.3.3,234.3.3.3";
        public Form1()
        {
            InitializeComponent();
            LoadConfig();
        }

        void UpdateAppConfig()
        {
            AddUpdateAppSettings("Source IP", tb_SourceIP.Text);
            AddUpdateAppSettings("Dest IP", tb_DestIP.Text);
            AddUpdateAppSettings("Output Source IP", tb_SourceIPOut.Text);
            AddUpdateAppSettings("Output Dest IP", tb_DestIPOut.Text);
            AddUpdateAppSettings("Source Port", tb_SourcePort.Text);
            AddUpdateAppSettings("Dest Port", tb_DestPort.Text);
            AddUpdateAppSettings("Output Source Port", tb_SourcePortOut.Text);
            AddUpdateAppSettings("Output Dest Port", tb_DestPortOut.Text);
            AddUpdateAppSettings("InputFileName", tb_InputFile.Text);
            AddUpdateAppSettings("OutputFileName", tb_OutputFile.Text);

            if (cb_SourceIP.Checked) AddUpdateAppSettings("ChangeSourceIP", "Checked");
            else AddUpdateAppSettings("ChangeSourceIP", "NotChecked");
            if (cb_SourcePort.Checked) AddUpdateAppSettings("ChangeSourcePort", "Checked");
            else AddUpdateAppSettings("ChangeSourcePort", "NotChecked");

            if (cb_DestIP.Checked) AddUpdateAppSettings("ChangeDestIP", "Checked");
            else AddUpdateAppSettings("ChangeDestIP", "NotChecked");
            if (cb_DestPort.Checked) AddUpdateAppSettings("ChangeDestPort", "Checked");
            else AddUpdateAppSettings("ChangeDestPort", "NotChecked");


        }

        void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                    pme("Added value");
                }
                else
                {
                    settings[key].Value = value;
                    pme("Updated value");

                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }


        void LoadConfig()
        {
            string setting = ConfigurationManager.AppSettings["Source IP"];
            if (setting != null) tb_SourceIP.Text = setting;
            setting = ConfigurationManager.AppSettings["Dest IP"];
            if (setting != null) tb_DestIP.Text = setting;
            setting = ConfigurationManager.AppSettings["Output Source IP"];
            if (setting != null) tb_SourceIPOut.Text = setting;
            setting = ConfigurationManager.AppSettings["Output Dest IP"];
            if (setting != null) tb_DestIPOut.Text = setting;

            setting = ConfigurationManager.AppSettings["Source Port"];
            if (setting != null) tb_SourcePort.Text = setting;
            setting = ConfigurationManager.AppSettings["Dest Port"];
            if (setting != null) tb_DestPort.Text = setting;
            setting = ConfigurationManager.AppSettings["Output Source Port"];
            if (setting != null) tb_SourcePortOut.Text = setting;
            setting = ConfigurationManager.AppSettings["Output Dest Port"];
            if (setting != null) tb_DestPortOut.Text = setting;

            setting = ConfigurationManager.AppSettings["InputFileName"];
            if (setting != null) tb_InputFile.Text = setting;
            setting = ConfigurationManager.AppSettings["OutputFileName"];
            if (setting != null) tb_OutputFile.Text = setting;

            setting = ConfigurationManager.AppSettings["ChangeSourceIP"];
            if (setting != null)
            {
                if (setting=="Checked") cb_SourceIP.Checked = true;
                else cb_SourceIP.Checked = false;
            }
            setting = ConfigurationManager.AppSettings["ChangeSourcePort"];
            if (setting != null)
            {
                if (setting == "Checked") cb_SourcePort.Checked = true;
                else cb_SourcePort.Checked = false;
            }

            setting = ConfigurationManager.AppSettings["ChangeDestIP"];
            if (setting != null)
            {
                if (setting == "Checked") cb_DestIP.Checked = true;
                else cb_DestIP.Checked = false;
            }
            setting = ConfigurationManager.AppSettings["ChangeDestPort"];
            if (setting != null)
            {
                if (setting == "Checked") cb_DestPort.Checked = true;
                else cb_DestPort.Checked = false;
            }


        }
        private void bn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bn_InputFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = tb_InputFile.Text;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog2.FileName;
                    using (Stream str = openFileDialog2.OpenFile())
                    {
                        tb_InputFile.Text = filePath;

                        string fname = Path.GetFileName(filePath);
                        string path = Path.GetDirectoryName(filePath);

                        tb_OutputFile.Text = path + "\\_" + fname;
                        //Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


        private void bn_Go_Click(object sender, EventArgs e)
        {
            bool ChangeAtLeastOneIP = buildArgument();
            if (ChangeAtLeastOneIP) pme(argument);
            if (!cb_CLI.Checked) Process.Start("bittwiste.exe", argument);

            bool ChangeAtLeastOnePort = false;
            if (ChangeAtLeastOneIP) ChangeAtLeastOnePort = buildArgument2("TEMP.PCAP");
            else ChangeAtLeastOnePort =  buildArgument2(tb_InputFile.Text);
            if (ChangeAtLeastOnePort) pme(argument);
            if (!cb_CLI.Checked) Process.Start("bittwiste.exe", argument);
            

        }

        private bool buildArgument()
        {
            if ((cb_DestIP.Checked) && (cb_SourceIP.Checked))
            {
                    argument = "-I " + tb_InputFile.Text + " -O TEMP.PCAP -T ip -s " + tb_SourceIP.Text + "," + tb_SourceIPOut.Text + " -d " + tb_DestIP.Text + "," + tb_DestIPOut.Text;
                    return true;
            }
            if (cb_SourceIP.Checked)
            {
                argument = "-I " + tb_InputFile.Text + " -O TEMP.PCAP -T ip -s " + tb_SourceIP.Text + "," + tb_SourceIPOut.Text;
                return true;
            }
            if (cb_DestIP.Checked)
            {
                argument = "-I " + tb_InputFile.Text + " -O TEMP.PCAP -T ip -d " + tb_DestIP.Text + "," + tb_DestIPOut.Text;
                return true;
            }
            return false; //neither was checked

        }
        private bool buildArgument2(string InputFileName)
        {
            if ((cb_DestPort.Checked) && (cb_SourcePort.Checked))
            {
                argument = "-I "+ InputFileName+ " -O " + tb_OutputFile.Text + " -T udp -s " + tb_SourcePort.Text + "," + tb_SourcePortOut.Text +
               " -d " + tb_DestPort.Text + "," + tb_DestPortOut.Text;
                return true;
            }
            if (cb_SourcePort.Checked)
            {
                argument = "-I " + InputFileName+ " -O " + tb_OutputFile.Text + " -T udp -s " + tb_SourcePort.Text + "," + tb_SourcePortOut.Text;
                return true;
            }
            if (cb_DestPort.Checked)
            {
                argument = "-I " + InputFileName + " -O " + tb_OutputFile.Text + " -T udp -d " + tb_DestPort.Text + "," + tb_DestPortOut.Text;
                return true;
            }
            return false;
        }

        void pme(string s)
        {
            tb_Debug.AppendText(s + "\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAppConfig();
        }

        private void bn_SaveConfig_Click_1(object sender, EventArgs e)
        {
            UpdateAppConfig();
        }

        private void bn_LoadConfig_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }
    }
}