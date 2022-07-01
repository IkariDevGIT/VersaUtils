using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VersaUtils
{
    public partial class VersaUtils : Form
    {
        public VersaUtils()
        {
            InitializeComponent();
            PCINFO_INFO_totalspace.Visible = false;
            PCINFO_INFO_freespace.Visible = false;
            label8.Visible = false;
            label10.Visible = false;

        }

        void Log(string str)
        {

            log_text.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + str + "\r\n");
            log_text.ScrollToCaret();

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DevMode_CheckBox.Checked)
            {
                //|
                int index = tabControl.SelectedIndex;
                if (index == 4){
                    tabControl.SelectedIndex = 0;
                    MessageBox.Show("Sorry, under construction!", "Stop!");
                }else if(index == 5) {
                    tabControl.SelectedIndex = 0;
                    MessageBox.Show("This feature is not available at this time! It is likely not going to be finished, and will be removed!", "Stop!");
                }
            }
        }







        private void InfoWindow()
        {
            MessageBox.Show("Made with ❤ by ikaridev.", "Info");
        }

        private void Title_Click(object sender, EventArgs e)
        {
            InfoWindow();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InfoWindow();
        }

        private void Info_Tick(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            if (PCINFO_log.Checked)
            {
                Log("PCINFO: " + "Time: " + DateTime.Now.ToString());
                Log("PCINFO: " + "IP: " + GetLocalIPAddress());
            }
            PCINFO_INFO_time.Text = DateTime.Now.ToString();
            PCINFO_INFO_ip.Text = GetLocalIPAddress();
            PCINFO_INFO_username.Text = userName;
            if (false)
            {
                DriveInfo dInfo = new DriveInfo("D");


                // When the drive is accessible..
                if (dInfo.IsReady)
                {


                    //freeSpacePerc
                    Double pc = (dInfo.AvailableFreeSpace / (float)dInfo.TotalSize) * 100;

                    // Calculate the percentage free space


                    //PCINFO_INFO_totalspace.Text = Math.Round(pc) + "%.";
                    PCINFO_INFO_freespace.Text = "Round: " + Math.Round(pc) + "%. Not round: " + pc;
                }
            }

        }

        private void SaveLog_Button_Click(object sender, EventArgs e)
        {
            if (saveLog_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //log.WriteAllText(saveFileDialog1.FileName);

                //Use StreamWriter class.
                StreamWriter sw = new StreamWriter(saveLog_SaveFileDialog.FileName);

                //Use write method to write the text
                sw.Write(log_text.Text);

                //always close your stream
                sw.Close();
                Log("Log was saved in " + saveLog_SaveFileDialog.FileName);
            }
        }

        private void ClearLog_Button_Click(object sender, EventArgs e)
        {
            log_text.Clear();
        }

        private void PCINFO_Active_CheckedChanged(object sender, EventArgs e)
        {
            if (PCINFO_Active.Checked)
            {
                Info.Enabled = true;
            }
            else if (!PCINFO_Active.Checked)
            {
                Info.Enabled = false;
            }
        }

        private void UpdateFrequency_ValueChanged(object sender, EventArgs e)
        {
            Info.Interval = (int)UpdateFrequency.Value;
        }

        private void DeleteTempFiles_Button_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete all temp files?",
                                     "Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Log("Deleting Temp Files...");
                string userName = Environment.UserName;
                var dir = new DirectoryInfo("C:\\Users\\" + userName + "\\AppData\\Local\\Temp");
                var d = new DirectoryInfo("C:\\Windows\\Temp");


                foreach (var file in Directory.GetFiles(dir.ToString()))
                {

                    try
                    {
                        File.Delete(file);
                        Log("Deleted file: " + file);
                    }
                    catch (Exception error)
                    {
                        Log("Could not delete file: " + file + " - Maybe its already in use by another program!");
                        //Log("ERROR: " + error);
                    }
                }


                foreach (var file in Directory.GetFiles(d.ToString()))
                {

                    try
                    {
                        File.Delete(file);
                        Log("Deleted file: " + file);
                    }
                    catch (Exception error)
                    {
                        Log("Could not delete file: " + file + " - Maybe its already in use by another program!");
                        //Log("ERROR: " + error);
                    }
                }
                Log("Temp Files were deleted!");

            }

        }

        void PasswordGen_Gen()
        {
            try
            {
                int length = (int)PasswordGen_Length.Value;
                //var words = new List<string> { };
                StringBuilder words = new StringBuilder();

                const string valid = "abcdefghijklmnopqrstuvwxyz";
                const string valid2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string valid3 = "1234567890";
                const string valid4 = @"!§$%&/()=?`_:;-.,´}][{*+";


                if (PasswordGen_h_lowercase.Checked) { words.Append(valid); }
                if (PasswordGen_h_uppercase.Checked) { words.Append(valid2); }
                if (PasswordGen_h_numbers.Checked) { words.Append(valid3); }
                if (PasswordGen_h_symbols.Checked) { words.Append(valid4); }





                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(words[rnd.Next(words.Length)]);
                }


                PasswordGen_OutputField.Text = res.ToString();

                Log("password was gemerated!");

            }
            catch (Exception ex)
            {
                var code = ex.HResult;
                if (!code.Equals(2146233080) | code != 2146233080)
                {
                    PasswordGen_OutputField.Text = "Please select at least one generation option!";
                }
                else
                {
                    Log("Error: " + code + ": " + ex);
                }
            }
        }


        private void PasswordGen_Generate_Click(object sender, EventArgs e)
        {

            int length = (int)PasswordGen_Length.Value;

            if (length > 999999)
            {
                var confirmResult = MessageBox.Show("Everything over 1.000.000 is highly unstable! Do you want to continue?",
                "Warning!!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes) { PasswordGen_Gen(); }

            } else { PasswordGen_Gen(); }


        }






        //////////////////////////////////////////////////////////////////////
        ////////////////////////////Script Clicker////////////////////////////
        //////////////////////////////////////////////////////////////////////

        private void ScriptClicker_new_Button_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to make a new file?",
            "Warning!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) { ScriptClicker_ScriptArea.Text = ""; Log("New ScriptClicker File was created!"); }

        
        }

        private void ScriptClicker_open_Button_Click(object sender, EventArgs e)
        {
            if (saveScriptClicker_script_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(saveScriptClicker_script_OpenFileDialog.FileName);
                ScriptClicker_ScriptArea.Text = text;
                Log("ScriptClicker file " + saveScriptClicker_script_OpenFileDialog.FileName + " was opened!");
            }
        }

        private void ScriptClicker_save_Button_Click(object sender, EventArgs e)
        {
            if (saveScriptClicker_script_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //log.WriteAllText(saveFileDialog1.FileName);

                //Use StreamWriter class.
                StreamWriter sw = new StreamWriter(saveScriptClicker_script_SaveFileDialog.FileName);

                //Use write method to write the text
                sw.Write(ScriptClicker_ScriptArea.Text);

                //always close your stream
                sw.Close();
                Log("ScriptClicker file " + saveScriptClicker_script_SaveFileDialog.FileName + " was saved!");
            }
        }

        private void ScriptClicker_help_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help lol.", "Help");
        }

        private void ScriptClicker_start_Button_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ScriptClicker_ScriptArea.Lines.Length; i++)
            {
                string text = (string)ScriptClicker_ScriptArea.Lines[i];
                if (text.StartsWith(""))
                {

                }
            }
            //ScriptClicker_ScriptArea.Lines.Length
            //while (ScriptClicker_ScriptArea.TextLength < length--)
            //{
            //}
        }
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////


    }
}
