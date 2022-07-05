
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace VersaUtils
{
    public partial class VersaUtils : Form
    {

        //if (Settings.Default.DevMode){Log(""); }
        public String VersaFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VersaUtils";
        public String VersaConfig = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VersaUtils\Config.txt";
        public Boolean DontActivateCheckBoxState = true;

        void Log(string str)
        {

            log_text.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + str + "\r\n");
            log_text.ScrollToCaret();

        }

        public VersaUtils()
        {
            InitializeComponent();
            //Task.Delay(1000).Wait();
            if (Settings.Default.DevMode) { Log("Initializing..."); }
            if (Settings.Default.DevMode) { Log("Disabling elements..."); }
            PCINFO_INFO_totalspace.Visible = false;
            PCINFO_INFO_freespace.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            if (Settings.Default.DevMode) { Log("Elements disabled."); }
            //AutoShutdown_progressBar.ForeColor(Color.Brown);
            // AutoShutdown_progressBar.BackColor(Color.Brown);
            //if (DevMode_CheckBox.Checked) { Log("Disabling Storage killer clear download folder for IkariDev"); }
            if (Environment.UserName.ToString() == "einea")
            {
                if (Settings.Default.DevMode) { Log("Disabling Storage killer clear download folder for IkariDev"); }
                StorageKiller_ClearDownloadFolder_Button.Enabled = false;
                if (Settings.Default.DevMode) { Log("Disabled"); }
            }
            //if (DevMode_CheckBox.Checked) { Log("Disabled"); }
            //Log(Environment.UserName.ToString());
            /*
            Log(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            System.IO.Directory.CreateDirectory(VersaFolder);
            if (!File.Exists(VersaConfig))
            {
                File.WriteAllText(VersaConfig, String.Empty);
            }
            */

            if(Settings.Default.EnableAnimeGirlsSetting == false)
            {if (Settings.Default.DevMode) { Log("Anime girls Disabling..."); }}
            EnableAnimeGirls.Checked = Settings.Default.EnableAnimeGirlsSetting;
            DevMode_CheckBox.Checked = Settings.Default.DevMode;
            Vis(pictureBox6, Settings.Default.EnableAnimeGirlsSetting);
             Vis(pictureBox7, Settings.Default.EnableAnimeGirlsSetting);
             Vis(pictureBox8, Settings.Default.EnableAnimeGirlsSetting);
             label14.Visible = Settings.Default.EnableAnimeGirlsSetting;
             label15.Visible = Settings.Default.EnableAnimeGirlsSetting;
            if (Settings.Default.EnableAnimeGirlsSetting == false)
            { if (Settings.Default.DevMode) { Log("Anime girls Disabled."); } }

            if (Settings.Default.VUFETemp.Length != 0)
            {
                var confirmResult2 = MessageBox.Show("Do you want to load your unsaved VUFE document? You can only do this once. When you click NO the Temporarily saved document will be deleted!", "WARNING!!!", MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                { 
                    VUFE_richTextBox.Text = Settings.Default.VUFETemp;
                    Settings.Default.VUFETemp = null;
                    if (Settings.Default.DevMode) { Log("Temp VUFE document was pasted."); }
                }
                else { Settings.Default.VUFETemp = null; }
            }






            DontActivateCheckBoxState = false;
            if (Settings.Default.DevMode) { Log("Initializing end."); }
        }

        private void DisableAnimeGirls_CheckedChanged(object sender, EventArgs e)
        {
            if (DontActivateCheckBoxState == false)
            {
                if (EnableAnimeGirls.Checked)
                {
                    Settings.Default.EnableAnimeGirlsSetting = true;
                    Settings.Default.Save();
                    MessageBox.Show("Restart to apply settings!");
                }
                else
                {
                    Settings.Default.EnableAnimeGirlsSetting = false;
                    Settings.Default.Save();
                    MessageBox.Show("Restart to apply settings!");
                }
            }


        }

        private void DevMode_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DontActivateCheckBoxState == false)
            {
                Settings.Default.DevMode = DevMode_CheckBox.Checked;
                Settings.Default.Save();
                MessageBox.Show("Restart to apply settings!");
            }
        }

        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask confirmation
            SHRB_NOPROGRESSUI = 0x00000002, // Don't show any windows dialog
            SHRB_NOSOUND = 0x00000004 // Don't make sound, ninja mode enabled :v
        }

        
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        public string GetLocalIPAddress()
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
            if (!Settings.Default.DevMode)
            {
                //|
                int index = tabControl.SelectedIndex;
                if (index == 4 | index == 6)
                {
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
            MessageBox.Show("Made with ❤ by ikaridev.\n\n ////Help////\nlol", "Info");
        }

        private void ClearRecycleBin()
        {
            var confirmResult = MessageBox.Show("Are you sure to delete all recycle bin files?",
                                   "Delete!",
                                   MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Log("Deleting recycle bin Files...");

                try
                {
                    // Execute the method with the required parameters
                    uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                    MessageBox.Show("The recycle bin has been succesfully recycled !", "Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log("The recycle bin has been succesfully recycled!");
                }
                catch (Exception error)
                {
                    Log(@"The recycle bin couldn't be recycled");
                    //Log("ERROR: " + error);
                }
                
                //Log("Temp Files were deleted!");

            }
        }

        private void DeleteTempFiles()
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

        private void Vis(PictureBox pic, Boolean bol)
        {
            if (bol == true)
            {
                pic.Enabled = true; pic.Visible = true;
            }
            else
            {
                pic.Enabled = false; pic.Visible = false;
            }

        }








        private void label9_Click(object sender, EventArgs e)
        {
            InfoWindow();
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
            DeleteTempFiles();
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





        //////////////////////////////////////////////////////////////////////
        /////////////////////////VUFE - File Editor///////////////////////////
        //////////////////////////////////////////////////////////////////////

        private void VUFE_new_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to make a new file?",
            "Warning!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) { VUFE_richTextBox.Text = ""; Log("New VUFE File was created!"); }
        }

        private void VUFE_open_Click(object sender, EventArgs e)
        {
            if (VUFE_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(VUFE_OpenFileDialog.FileName);
                VUFE_richTextBox.Text = text;
                Log("VUFE file " + VUFE_OpenFileDialog.FileName + " was opened!");
            }
        }

        private void VUFE_save_Click(object sender, EventArgs e)
        {
            try
            {
                Random rndr = new Random();
                int number = rndr.Next(10, 20);
                int length = (int)number;
                //var words = new List<string> { };
                StringBuilder words = new StringBuilder();

                const string valid = "abcdefghijklmnopqrstuvwxyz";
                const string valid2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string valid3 = "1234567890";
                const string valid4 = @"!§$%&/()=?`_:;-.,´}][{*+";

                if (true) { words.Append(valid); }
                if (true) { words.Append(valid2); }
                if (true) { words.Append(valid3); }
                if (false) { words.Append(valid4); }


                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(words[rnd.Next(words.Length)]);
                }



                //Random rnd = new Random();
                //int number = rnd.Next(1, 2147483647);
                VUFE_SaveFileDialog.FileName = "VUFE File" + " fileid_" + res.ToString();
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }

            if (VUFE_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //log.WriteAllText(saveFileDialog1.FileName);

                //Use StreamWriter class.
                
                StreamWriter sw = new StreamWriter(VUFE_SaveFileDialog.FileName);

                //Use write method to write the text
                sw.Write(VUFE_richTextBox.Text);

                //always close your stream
                sw.Close();
                Log("VUFE file " + VUFE_SaveFileDialog.FileName + " was saved!");
                
            }
        }

        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////

        public int vala;
        private void AutoShutdown_Start_Click(object sender, EventArgs e)
        {
            int minu = (int)AutoShutdown_S.Value;
            int sec = minu * 60;
            var confirmResult = MessageBox.Show("Do you really want to shut down you pc in " + minu + "minutes(" + sec + "seconds)?",
                "Warning!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) {
                vala = sec;
                AutoShutdown.Enabled = true;
                AutoShutdown_SL.Text = "none";
                AutoShutdown_S.Enabled = false;
                AutoShutdown_Start.Enabled = false;
                AutoShutdown_progressBar.Maximum = vala;
                AutoShutdown_progressBar.Value = vala;
                AutoShutdown_Cancel.Enabled = true;
                Log("AutoShutdown Started!");
                //Process.Start("shutdown", "/s /t " + sec);
            }

        }
        
        private void AutoShutdown_Tick(object sender, EventArgs e)
        {
            vala--;
            AutoShutdown_SL.Text = vala.ToString() + " Seconds(" + Math.Floor((double)vala / 60).ToString() + " Minutes)";
            AutoShutdown_progressBar.Value = vala;
            if (vala == 0)
            {
                AutoShutdown.Enabled = false;
                Process.Start("shutdown", "/s /t 0");
                Log("AutoShutdown!");
            }
        }

        private void AutoShutdown_Cancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to stop the AutoShutdown Process??",
                "Warning!!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                AutoShutdown.Enabled = false;
                vala = 0;
                AutoShutdown_SL.Text = "none";
                AutoShutdown_S.Enabled = true;
                AutoShutdown_Start.Enabled = true;
                AutoShutdown_progressBar.Maximum = 0;
                AutoShutdown_progressBar.Value = 0;
                AutoShutdown_Cancel.Enabled = false;
                Log("AutoShutdown Stopped!");
            }
        }
        bool rainbow = false;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (rainbow == false)
            {
                pictureBox7.Image = Properties.Resources.AnimeGirl_Rainbow;
                pictureBox7.Refresh();
                rainbow = true;
            }

            else if(rainbow == true) {
                pictureBox7.Image = Properties.Resources.AnimeGirl_Normal;
                pictureBox7.Refresh();
                rainbow = false;
            }
            
        }

        private void StorageKiller_ClearRecycleBin_Button_Click(object sender, EventArgs e)
        {
            ClearRecycleBin();
        }

        private void StorageKiller_ClearDownloadFolder_Button_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete all files in the download folder?",
                                    "Delete!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                var confirmResult2 = MessageBox.Show("All the files will be deleted forever and cannot be saved. ARE YOU SURE YOU WANT TO DELETE ALL FILES IN THE DOWNLOAD FOLDER??",
                                        "WARNING!!!",
                                        MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                {
                    Log("Deleting Download Files...");
                    string userName = Environment.UserName;
                    var dir = new DirectoryInfo("C:\\Users\\" + userName + "\\Downloads");


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

                    Log("Download Files were deleted!");
                }

            }
        }

        private void StorageKiller_DeleteAllJunkFiles_Button_Click(object sender, EventArgs e)
        {
            DeleteTempFiles();
            ClearRecycleBin();
        }

        private void VersaUtils_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AutoShutdown.Enabled)
            {
                var confirmResult2 = MessageBox.Show("Auto shutdown is active, do you really wanna quit the application?", "WARNING!!!", MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                { Application.ExitThread(); }
                else { e.Cancel = true; }
            }
            if(VUFE_richTextBox.TextLength != 0){
                var confirmResult2 = MessageBox.Show("Your VUFE document isn´t saved, do you really wanna quit the application? ", "WARNING!!!", MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                { Application.ExitThread();
                    //Settings.Default.VUFETemp = VUFE_richTextBox.Text;
                   // Settings.Default.Save();
                }
                else { e.Cancel = true; }
            }


        }

        private void VUFE_richTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.VUFETemp = VUFE_richTextBox.Text;
            Settings.Default.Save();
            try
            {
                if (Settings.Default.DevMode && VUFE_richTextBox.Text != null) { Log("VUFE text was temp saved! Char:" + VUFE_richTextBox.Text.Substring(VUFE_richTextBox.Text.Length - 1)); }
            }
            catch (Exception error)
            {
                //Log(error.GetType().ToString());
                if(error.GetType().ToString() != "System.ArgumentOutOfRangeException")
                {
                    Log(error.ToString());
                }
            }
          }

        private void FastOptions_FuckProcess_Button_Click(object sender, EventArgs e)
        {
            Process[] workers = Process.GetProcessesByName(FastOptions_FuckProcess_TextBox.Text);
            foreach (Process worker in workers)
            {
                worker.Kill();
                //worker.WaitForExit();
                worker.Dispose();
            }
        }

        private void FastOptions_ForceCloseAllApps_Button_Click(object sender, EventArgs e)
        {
            // I mean it! This will cause badness!
            

            Process me = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcesses())
            {
                if (p.Id != me.Id)
                    p.CloseMainWindow(); // Sends WM_CLOSE; less gentle methods available too
            }
        }
    }
}
