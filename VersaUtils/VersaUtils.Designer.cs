namespace VersaUtils
{
    partial class VersaUtils
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersaUtils));
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Main_Menu = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DevMode_CheckBox = new System.Windows.Forms.CheckBox();
            this.Pc_Info = new System.Windows.Forms.TabPage();
            this.PCINFO_INFO_ip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PCINFO_INFO_totalspace = new System.Windows.Forms.Label();
            this.PCINFO_INFO_freespace = new System.Windows.Forms.Label();
            this.PCINFO_INFO_username = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PCINFO_INFO_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.UpdateFrequency = new System.Windows.Forms.NumericUpDown();
            this.PCINFO_Active = new System.Windows.Forms.CheckBox();
            this.PCINFO_log = new System.Windows.Forms.CheckBox();
            this.StorageKiler = new System.Windows.Forms.TabPage();
            this.DeleteTempFiles_Button = new System.Windows.Forms.Button();
            this.Password_Gen = new System.Windows.Forms.TabPage();
            this.PasswordGen_OutputField = new System.Windows.Forms.RichTextBox();
            this.PasswordGen_h_symbols = new System.Windows.Forms.CheckBox();
            this.PasswordGen_h_numbers = new System.Windows.Forms.CheckBox();
            this.PasswordGen_h_lowercase = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordGen_h_uppercase = new System.Windows.Forms.CheckBox();
            this.PasswordGen_Generate = new System.Windows.Forms.Button();
            this.PasswordGen_Length = new System.Windows.Forms.NumericUpDown();
            this.CamMic_Test = new System.Windows.Forms.TabPage();
            this.ScriptClicker = new System.Windows.Forms.TabPage();
            this.ScriptClicker_help_Button = new System.Windows.Forms.Button();
            this.ScriptClicker_new_Button = new System.Windows.Forms.Button();
            this.ScriptClicker_open_Button = new System.Windows.Forms.Button();
            this.ScriptClicker_start_Button = new System.Windows.Forms.Button();
            this.ScriptClicker_save_Button = new System.Windows.Forms.Button();
            this.ScriptClicker_ScriptArea = new System.Windows.Forms.RichTextBox();
            this.Log_f = new System.Windows.Forms.TabPage();
            this.ClearLog_Button = new System.Windows.Forms.Button();
            this.SaveLog_Button = new System.Windows.Forms.Button();
            this.log_text = new System.Windows.Forms.RichTextBox();
            this.Info = new System.Windows.Forms.Timer(this.components);
            this.saveLog_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveScriptClicker_script_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveScriptClicker_script_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Main_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Pc_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateFrequency)).BeginInit();
            this.StorageKiler.SuspendLayout();
            this.Password_Gen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordGen_Length)).BeginInit();
            this.ScriptClicker.SuspendLayout();
            this.Log_f.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Snow;
            this.Title.Location = new System.Drawing.Point(480, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 33);
            this.Title.TabIndex = 1;
            this.Title.Text = "VersaUtils";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VersaUtils.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(420, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VersaUtils.Properties.Resources.Line21;
            this.pictureBox1.Location = new System.Drawing.Point(30, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.Main_Menu);
            this.tabControl.Controls.Add(this.Pc_Info);
            this.tabControl.Controls.Add(this.StorageKiler);
            this.tabControl.Controls.Add(this.Password_Gen);
            this.tabControl.Controls.Add(this.CamMic_Test);
            this.tabControl.Controls.Add(this.ScriptClicker);
            this.tabControl.Controls.Add(this.Log_f);
            this.tabControl.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(30, 100);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(970, 690);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Main_Menu
            // 
            this.Main_Menu.BackColor = System.Drawing.Color.LavenderBlush;
            this.Main_Menu.Controls.Add(this.pictureBox3);
            this.Main_Menu.Controls.Add(this.label3);
            this.Main_Menu.Controls.Add(this.label2);
            this.Main_Menu.Controls.Add(this.DevMode_CheckBox);
            this.Main_Menu.Location = new System.Drawing.Point(4, 33);
            this.Main_Menu.Name = "Main_Menu";
            this.Main_Menu.Size = new System.Drawing.Size(962, 653);
            this.Main_Menu.TabIndex = 0;
            this.Main_Menu.Text = "Main Menu";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VersaUtils.Properties.Resources.logo2;
            this.pictureBox3.Location = new System.Drawing.Point(360, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(430, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "VersaUtils";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to";
            // 
            // DevMode_CheckBox
            // 
            this.DevMode_CheckBox.AutoSize = true;
            this.DevMode_CheckBox.Location = new System.Drawing.Point(0, 630);
            this.DevMode_CheckBox.Name = "DevMode_CheckBox";
            this.DevMode_CheckBox.Size = new System.Drawing.Size(78, 25);
            this.DevMode_CheckBox.TabIndex = 5;
            this.DevMode_CheckBox.Text = "Dev mode";
            this.DevMode_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Pc_Info
            // 
            this.Pc_Info.BackColor = System.Drawing.Color.LavenderBlush;
            this.Pc_Info.Controls.Add(this.PCINFO_INFO_ip);
            this.Pc_Info.Controls.Add(this.label5);
            this.Pc_Info.Controls.Add(this.PCINFO_INFO_totalspace);
            this.Pc_Info.Controls.Add(this.PCINFO_INFO_freespace);
            this.Pc_Info.Controls.Add(this.PCINFO_INFO_username);
            this.Pc_Info.Controls.Add(this.label10);
            this.Pc_Info.Controls.Add(this.label8);
            this.Pc_Info.Controls.Add(this.label7);
            this.Pc_Info.Controls.Add(this.PCINFO_INFO_time);
            this.Pc_Info.Controls.Add(this.label4);
            this.Pc_Info.Controls.Add(this.label1);
            this.Pc_Info.Controls.Add(this.pictureBox4);
            this.Pc_Info.Controls.Add(this.UpdateFrequency);
            this.Pc_Info.Controls.Add(this.PCINFO_Active);
            this.Pc_Info.Controls.Add(this.PCINFO_log);
            this.Pc_Info.Location = new System.Drawing.Point(4, 33);
            this.Pc_Info.Name = "Pc_Info";
            this.Pc_Info.Size = new System.Drawing.Size(962, 653);
            this.Pc_Info.TabIndex = 1;
            this.Pc_Info.Text = "Pc Info";
            // 
            // PCINFO_INFO_ip
            // 
            this.PCINFO_INFO_ip.AutoSize = true;
            this.PCINFO_INFO_ip.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.PCINFO_INFO_ip.Location = new System.Drawing.Point(90, 130);
            this.PCINFO_INFO_ip.Name = "PCINFO_INFO_ip";
            this.PCINFO_INFO_ip.Size = new System.Drawing.Size(142, 28);
            this.PCINFO_INFO_ip.TabIndex = 8;
            this.PCINFO_INFO_ip.Text = "PCINFO_INFO_ip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.label5.Location = new System.Drawing.Point(40, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP:";
            // 
            // PCINFO_INFO_totalspace
            // 
            this.PCINFO_INFO_totalspace.AutoSize = true;
            this.PCINFO_INFO_totalspace.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.PCINFO_INFO_totalspace.Location = new System.Drawing.Point(730, 600);
            this.PCINFO_INFO_totalspace.Name = "PCINFO_INFO_totalspace";
            this.PCINFO_INFO_totalspace.Size = new System.Drawing.Size(199, 28);
            this.PCINFO_INFO_totalspace.TabIndex = 8;
            this.PCINFO_INFO_totalspace.Text = "PCINFO_INFO_totalspace";
            // 
            // PCINFO_INFO_freespace
            // 
            this.PCINFO_INFO_freespace.AutoSize = true;
            this.PCINFO_INFO_freespace.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.PCINFO_INFO_freespace.Location = new System.Drawing.Point(760, 570);
            this.PCINFO_INFO_freespace.Name = "PCINFO_INFO_freespace";
            this.PCINFO_INFO_freespace.Size = new System.Drawing.Size(196, 28);
            this.PCINFO_INFO_freespace.TabIndex = 8;
            this.PCINFO_INFO_freespace.Text = "PCINFO_INFO_freespace";
            // 
            // PCINFO_INFO_username
            // 
            this.PCINFO_INFO_username.AutoSize = true;
            this.PCINFO_INFO_username.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.PCINFO_INFO_username.Location = new System.Drawing.Point(360, 100);
            this.PCINFO_INFO_username.Name = "PCINFO_INFO_username";
            this.PCINFO_INFO_username.Size = new System.Drawing.Size(194, 28);
            this.PCINFO_INFO_username.TabIndex = 8;
            this.PCINFO_INFO_username.Text = "PCINFO_INFO_username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.label10.Location = new System.Drawing.Point(640, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total space:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.label8.Location = new System.Drawing.Point(640, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Free space in %:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.label7.Location = new System.Drawing.Point(270, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Name:";
            // 
            // PCINFO_INFO_time
            // 
            this.PCINFO_INFO_time.AutoSize = true;
            this.PCINFO_INFO_time.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.PCINFO_INFO_time.Location = new System.Drawing.Point(90, 100);
            this.PCINFO_INFO_time.Name = "PCINFO_INFO_time";
            this.PCINFO_INFO_time.Size = new System.Drawing.Size(158, 28);
            this.PCINFO_INFO_time.TabIndex = 8;
            this.PCINFO_INFO_time.Text = "PCINFO_INFO_time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Reem Kufi", 11.25F);
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 8.25F);
            this.label1.Location = new System.Drawing.Point(130, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update frequency(In ms):";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VersaUtils.Properties.Resources.Line21;
            this.pictureBox4.Location = new System.Drawing.Point(10, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(320, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // UpdateFrequency
            // 
            this.UpdateFrequency.BackColor = System.Drawing.Color.LavenderBlush;
            this.UpdateFrequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateFrequency.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UpdateFrequency.Location = new System.Drawing.Point(270, 10);
            this.UpdateFrequency.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpdateFrequency.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UpdateFrequency.Name = "UpdateFrequency";
            this.UpdateFrequency.Size = new System.Drawing.Size(40, 24);
            this.UpdateFrequency.TabIndex = 1;
            this.UpdateFrequency.Tag = "";
            this.UpdateFrequency.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UpdateFrequency.ValueChanged += new System.EventHandler(this.UpdateFrequency_ValueChanged);
            // 
            // PCINFO_Active
            // 
            this.PCINFO_Active.AutoSize = true;
            this.PCINFO_Active.Checked = true;
            this.PCINFO_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PCINFO_Active.Location = new System.Drawing.Point(30, 10);
            this.PCINFO_Active.Name = "PCINFO_Active";
            this.PCINFO_Active.Size = new System.Drawing.Size(61, 25);
            this.PCINFO_Active.TabIndex = 0;
            this.PCINFO_Active.Text = "Active";
            this.PCINFO_Active.UseVisualStyleBackColor = true;
            this.PCINFO_Active.CheckedChanged += new System.EventHandler(this.PCINFO_Active_CheckedChanged);
            // 
            // PCINFO_log
            // 
            this.PCINFO_log.AutoSize = true;
            this.PCINFO_log.Location = new System.Drawing.Point(30, 30);
            this.PCINFO_log.Name = "PCINFO_log";
            this.PCINFO_log.Size = new System.Drawing.Size(49, 25);
            this.PCINFO_log.TabIndex = 6;
            this.PCINFO_log.Text = "Log";
            this.PCINFO_log.UseVisualStyleBackColor = true;
            // 
            // StorageKiler
            // 
            this.StorageKiler.BackColor = System.Drawing.Color.LavenderBlush;
            this.StorageKiler.Controls.Add(this.DeleteTempFiles_Button);
            this.StorageKiler.Location = new System.Drawing.Point(4, 33);
            this.StorageKiler.Name = "StorageKiler";
            this.StorageKiler.Size = new System.Drawing.Size(962, 653);
            this.StorageKiler.TabIndex = 3;
            this.StorageKiler.Text = "StorageKiler";
            // 
            // DeleteTempFiles_Button
            // 
            this.DeleteTempFiles_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTempFiles_Button.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.DeleteTempFiles_Button.Location = new System.Drawing.Point(20, 20);
            this.DeleteTempFiles_Button.Name = "DeleteTempFiles_Button";
            this.DeleteTempFiles_Button.Size = new System.Drawing.Size(180, 140);
            this.DeleteTempFiles_Button.TabIndex = 0;
            this.DeleteTempFiles_Button.Text = "Delete Temp files";
            this.DeleteTempFiles_Button.UseVisualStyleBackColor = true;
            this.DeleteTempFiles_Button.Click += new System.EventHandler(this.DeleteTempFiles_Button_Click);
            // 
            // Password_Gen
            // 
            this.Password_Gen.BackColor = System.Drawing.Color.LavenderBlush;
            this.Password_Gen.Controls.Add(this.PasswordGen_OutputField);
            this.Password_Gen.Controls.Add(this.PasswordGen_h_symbols);
            this.Password_Gen.Controls.Add(this.PasswordGen_h_numbers);
            this.Password_Gen.Controls.Add(this.PasswordGen_h_lowercase);
            this.Password_Gen.Controls.Add(this.label6);
            this.Password_Gen.Controls.Add(this.PasswordGen_h_uppercase);
            this.Password_Gen.Controls.Add(this.PasswordGen_Generate);
            this.Password_Gen.Controls.Add(this.PasswordGen_Length);
            this.Password_Gen.Location = new System.Drawing.Point(4, 33);
            this.Password_Gen.Name = "Password_Gen";
            this.Password_Gen.Size = new System.Drawing.Size(962, 653);
            this.Password_Gen.TabIndex = 4;
            this.Password_Gen.Text = "Password Gen";
            // 
            // PasswordGen_OutputField
            // 
            this.PasswordGen_OutputField.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGen_OutputField.Location = new System.Drawing.Point(220, 10);
            this.PasswordGen_OutputField.Name = "PasswordGen_OutputField";
            this.PasswordGen_OutputField.ReadOnly = true;
            this.PasswordGen_OutputField.Size = new System.Drawing.Size(730, 320);
            this.PasswordGen_OutputField.TabIndex = 6;
            this.PasswordGen_OutputField.Text = "";
            // 
            // PasswordGen_h_symbols
            // 
            this.PasswordGen_h_symbols.AutoSize = true;
            this.PasswordGen_h_symbols.Location = new System.Drawing.Point(30, 140);
            this.PasswordGen_h_symbols.Name = "PasswordGen_h_symbols";
            this.PasswordGen_h_symbols.Size = new System.Drawing.Size(71, 25);
            this.PasswordGen_h_symbols.TabIndex = 5;
            this.PasswordGen_h_symbols.Text = "Symbols";
            this.PasswordGen_h_symbols.UseVisualStyleBackColor = true;
            // 
            // PasswordGen_h_numbers
            // 
            this.PasswordGen_h_numbers.AutoSize = true;
            this.PasswordGen_h_numbers.Location = new System.Drawing.Point(120, 80);
            this.PasswordGen_h_numbers.Name = "PasswordGen_h_numbers";
            this.PasswordGen_h_numbers.Size = new System.Drawing.Size(75, 25);
            this.PasswordGen_h_numbers.TabIndex = 5;
            this.PasswordGen_h_numbers.Text = "Numbers";
            this.PasswordGen_h_numbers.UseVisualStyleBackColor = true;
            // 
            // PasswordGen_h_lowercase
            // 
            this.PasswordGen_h_lowercase.AutoSize = true;
            this.PasswordGen_h_lowercase.Location = new System.Drawing.Point(30, 110);
            this.PasswordGen_h_lowercase.Name = "PasswordGen_h_lowercase";
            this.PasswordGen_h_lowercase.Size = new System.Drawing.Size(82, 25);
            this.PasswordGen_h_lowercase.TabIndex = 5;
            this.PasswordGen_h_lowercase.Text = "Lowercase";
            this.PasswordGen_h_lowercase.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lenght: ";
            // 
            // PasswordGen_h_uppercase
            // 
            this.PasswordGen_h_uppercase.AutoSize = true;
            this.PasswordGen_h_uppercase.Location = new System.Drawing.Point(30, 80);
            this.PasswordGen_h_uppercase.Name = "PasswordGen_h_uppercase";
            this.PasswordGen_h_uppercase.Size = new System.Drawing.Size(84, 25);
            this.PasswordGen_h_uppercase.TabIndex = 2;
            this.PasswordGen_h_uppercase.Text = "Uppercase";
            this.PasswordGen_h_uppercase.UseVisualStyleBackColor = true;
            // 
            // PasswordGen_Generate
            // 
            this.PasswordGen_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGen_Generate.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGen_Generate.Location = new System.Drawing.Point(70, 180);
            this.PasswordGen_Generate.Name = "PasswordGen_Generate";
            this.PasswordGen_Generate.Size = new System.Drawing.Size(75, 23);
            this.PasswordGen_Generate.TabIndex = 1;
            this.PasswordGen_Generate.Text = "Generate";
            this.PasswordGen_Generate.UseVisualStyleBackColor = true;
            this.PasswordGen_Generate.Click += new System.EventHandler(this.PasswordGen_Generate_Click);
            // 
            // PasswordGen_Length
            // 
            this.PasswordGen_Length.Location = new System.Drawing.Point(80, 30);
            this.PasswordGen_Length.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PasswordGen_Length.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PasswordGen_Length.Name = "PasswordGen_Length";
            this.PasswordGen_Length.Size = new System.Drawing.Size(60, 28);
            this.PasswordGen_Length.TabIndex = 0;
            this.PasswordGen_Length.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // CamMic_Test
            // 
            this.CamMic_Test.BackColor = System.Drawing.Color.LavenderBlush;
            this.CamMic_Test.Location = new System.Drawing.Point(4, 33);
            this.CamMic_Test.Name = "CamMic_Test";
            this.CamMic_Test.Size = new System.Drawing.Size(962, 653);
            this.CamMic_Test.TabIndex = 5;
            this.CamMic_Test.Text = "Cam/Mic Test";
            // 
            // ScriptClicker
            // 
            this.ScriptClicker.BackColor = System.Drawing.Color.LavenderBlush;
            this.ScriptClicker.Controls.Add(this.ScriptClicker_help_Button);
            this.ScriptClicker.Controls.Add(this.ScriptClicker_new_Button);
            this.ScriptClicker.Controls.Add(this.ScriptClicker_open_Button);
            this.ScriptClicker.Controls.Add(this.ScriptClicker_start_Button);
            this.ScriptClicker.Controls.Add(this.ScriptClicker_save_Button);
            this.ScriptClicker.Controls.Add(this.ScriptClicker_ScriptArea);
            this.ScriptClicker.Location = new System.Drawing.Point(4, 33);
            this.ScriptClicker.Name = "ScriptClicker";
            this.ScriptClicker.Size = new System.Drawing.Size(962, 653);
            this.ScriptClicker.TabIndex = 6;
            this.ScriptClicker.Text = "ScriptClicker";
            // 
            // ScriptClicker_help_Button
            // 
            this.ScriptClicker_help_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptClicker_help_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptClicker_help_Button.Location = new System.Drawing.Point(870, 10);
            this.ScriptClicker_help_Button.Name = "ScriptClicker_help_Button";
            this.ScriptClicker_help_Button.Size = new System.Drawing.Size(75, 23);
            this.ScriptClicker_help_Button.TabIndex = 6;
            this.ScriptClicker_help_Button.Text = "Help";
            this.ScriptClicker_help_Button.UseVisualStyleBackColor = true;
            this.ScriptClicker_help_Button.Click += new System.EventHandler(this.ScriptClicker_help_Button_Click);
            // 
            // ScriptClicker_new_Button
            // 
            this.ScriptClicker_new_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptClicker_new_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptClicker_new_Button.Location = new System.Drawing.Point(170, 10);
            this.ScriptClicker_new_Button.Name = "ScriptClicker_new_Button";
            this.ScriptClicker_new_Button.Size = new System.Drawing.Size(75, 23);
            this.ScriptClicker_new_Button.TabIndex = 5;
            this.ScriptClicker_new_Button.Text = "New";
            this.ScriptClicker_new_Button.UseVisualStyleBackColor = true;
            this.ScriptClicker_new_Button.Click += new System.EventHandler(this.ScriptClicker_new_Button_Click);
            // 
            // ScriptClicker_open_Button
            // 
            this.ScriptClicker_open_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptClicker_open_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptClicker_open_Button.Location = new System.Drawing.Point(90, 10);
            this.ScriptClicker_open_Button.Name = "ScriptClicker_open_Button";
            this.ScriptClicker_open_Button.Size = new System.Drawing.Size(75, 23);
            this.ScriptClicker_open_Button.TabIndex = 4;
            this.ScriptClicker_open_Button.Text = "Open";
            this.ScriptClicker_open_Button.UseVisualStyleBackColor = true;
            this.ScriptClicker_open_Button.Click += new System.EventHandler(this.ScriptClicker_open_Button_Click);
            // 
            // ScriptClicker_start_Button
            // 
            this.ScriptClicker_start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptClicker_start_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptClicker_start_Button.Location = new System.Drawing.Point(10, 620);
            this.ScriptClicker_start_Button.Name = "ScriptClicker_start_Button";
            this.ScriptClicker_start_Button.Size = new System.Drawing.Size(75, 23);
            this.ScriptClicker_start_Button.TabIndex = 3;
            this.ScriptClicker_start_Button.Text = "Start";
            this.ScriptClicker_start_Button.UseVisualStyleBackColor = true;
            this.ScriptClicker_start_Button.Click += new System.EventHandler(this.ScriptClicker_start_Button_Click);
            // 
            // ScriptClicker_save_Button
            // 
            this.ScriptClicker_save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptClicker_save_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptClicker_save_Button.Location = new System.Drawing.Point(10, 10);
            this.ScriptClicker_save_Button.Name = "ScriptClicker_save_Button";
            this.ScriptClicker_save_Button.Size = new System.Drawing.Size(75, 23);
            this.ScriptClicker_save_Button.TabIndex = 2;
            this.ScriptClicker_save_Button.Text = "Save";
            this.ScriptClicker_save_Button.UseVisualStyleBackColor = true;
            this.ScriptClicker_save_Button.Click += new System.EventHandler(this.ScriptClicker_save_Button_Click);
            // 
            // ScriptClicker_ScriptArea
            // 
            this.ScriptClicker_ScriptArea.Location = new System.Drawing.Point(10, 40);
            this.ScriptClicker_ScriptArea.Name = "ScriptClicker_ScriptArea";
            this.ScriptClicker_ScriptArea.Size = new System.Drawing.Size(940, 560);
            this.ScriptClicker_ScriptArea.TabIndex = 0;
            this.ScriptClicker_ScriptArea.Text = "";
            // 
            // Log_f
            // 
            this.Log_f.BackColor = System.Drawing.Color.LavenderBlush;
            this.Log_f.Controls.Add(this.ClearLog_Button);
            this.Log_f.Controls.Add(this.SaveLog_Button);
            this.Log_f.Controls.Add(this.log_text);
            this.Log_f.Location = new System.Drawing.Point(4, 33);
            this.Log_f.Name = "Log_f";
            this.Log_f.Size = new System.Drawing.Size(962, 653);
            this.Log_f.TabIndex = 2;
            this.Log_f.Text = "Log";
            // 
            // ClearLog_Button
            // 
            this.ClearLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLog_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLog_Button.Location = new System.Drawing.Point(80, 620);
            this.ClearLog_Button.Name = "ClearLog_Button";
            this.ClearLog_Button.Size = new System.Drawing.Size(60, 23);
            this.ClearLog_Button.TabIndex = 2;
            this.ClearLog_Button.Text = "Clear";
            this.ClearLog_Button.UseVisualStyleBackColor = true;
            this.ClearLog_Button.Click += new System.EventHandler(this.ClearLog_Button_Click);
            // 
            // SaveLog_Button
            // 
            this.SaveLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLog_Button.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLog_Button.Location = new System.Drawing.Point(10, 620);
            this.SaveLog_Button.Name = "SaveLog_Button";
            this.SaveLog_Button.Size = new System.Drawing.Size(60, 23);
            this.SaveLog_Button.TabIndex = 1;
            this.SaveLog_Button.Text = "Save";
            this.SaveLog_Button.UseVisualStyleBackColor = true;
            this.SaveLog_Button.Click += new System.EventHandler(this.SaveLog_Button_Click);
            // 
            // log_text
            // 
            this.log_text.BackColor = System.Drawing.Color.LavenderBlush;
            this.log_text.Location = new System.Drawing.Point(10, 10);
            this.log_text.Name = "log_text";
            this.log_text.ReadOnly = true;
            this.log_text.Size = new System.Drawing.Size(940, 610);
            this.log_text.TabIndex = 0;
            this.log_text.Text = "";
            // 
            // Info
            // 
            this.Info.Enabled = true;
            this.Info.Tick += new System.EventHandler(this.Info_Tick);
            // 
            // saveLog_SaveFileDialog
            // 
            this.saveLog_SaveFileDialog.FileName = "log";
            this.saveLog_SaveFileDialog.Filter = "Textdocument|*.log\n";
            // 
            // saveScriptClicker_script_SaveFileDialog
            // 
            this.saveScriptClicker_script_SaveFileDialog.FileName = "script";
            this.saveScriptClicker_script_SaveFileDialog.Filter = "ScriptClicker Versa Utils File|*.scvu";
            // 
            // VersaUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1033, 825);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VersaUtils";
            this.Opacity = 0.95D;
            this.Text = "VersaUtils";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Main_Menu.ResumeLayout(false);
            this.Main_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Pc_Info.ResumeLayout(false);
            this.Pc_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateFrequency)).EndInit();
            this.StorageKiler.ResumeLayout(false);
            this.Password_Gen.ResumeLayout(false);
            this.Password_Gen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordGen_Length)).EndInit();
            this.ScriptClicker.ResumeLayout(false);
            this.Log_f.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Main_Menu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Pc_Info;
        private System.Windows.Forms.Timer Info;
        private System.Windows.Forms.TabPage Log_f;
        private System.Windows.Forms.RichTextBox log_text;
        private System.Windows.Forms.Button SaveLog_Button;
        private System.Windows.Forms.SaveFileDialog saveLog_SaveFileDialog;
        private System.Windows.Forms.Button ClearLog_Button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown UpdateFrequency;
        private System.Windows.Forms.CheckBox PCINFO_Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox PCINFO_log;
        private System.Windows.Forms.Label PCINFO_INFO_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PCINFO_INFO_ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage StorageKiler;
        private System.Windows.Forms.Button DeleteTempFiles_Button;
        private System.Windows.Forms.TabPage Password_Gen;
        private System.Windows.Forms.TabPage CamMic_Test;
        private System.Windows.Forms.TabPage ScriptClicker;
        private System.Windows.Forms.CheckBox DevMode_CheckBox;
        private System.Windows.Forms.CheckBox PasswordGen_h_symbols;
        private System.Windows.Forms.CheckBox PasswordGen_h_numbers;
        private System.Windows.Forms.CheckBox PasswordGen_h_lowercase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox PasswordGen_h_uppercase;
        private System.Windows.Forms.Button PasswordGen_Generate;
        private System.Windows.Forms.NumericUpDown PasswordGen_Length;
        private System.Windows.Forms.RichTextBox PasswordGen_OutputField;
        private System.Windows.Forms.Button ScriptClicker_help_Button;
        private System.Windows.Forms.Button ScriptClicker_new_Button;
        private System.Windows.Forms.Button ScriptClicker_open_Button;
        private System.Windows.Forms.Button ScriptClicker_start_Button;
        private System.Windows.Forms.Button ScriptClicker_save_Button;
        private System.Windows.Forms.RichTextBox ScriptClicker_ScriptArea;
        private System.Windows.Forms.SaveFileDialog saveScriptClicker_script_SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog saveScriptClicker_script_OpenFileDialog;
        private System.Windows.Forms.Label PCINFO_INFO_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PCINFO_INFO_totalspace;
        private System.Windows.Forms.Label PCINFO_INFO_freespace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}

