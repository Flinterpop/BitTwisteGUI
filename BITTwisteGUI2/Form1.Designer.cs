namespace BITTwisteGUI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bn_InputFile = new Button();
            tb_InputFile = new TextBox();
            tb_OutputFile = new TextBox();
            groupBox1 = new GroupBox();
            tb_DestPort = new TextBox();
            label3 = new Label();
            tb_DestIP = new TextBox();
            label4 = new Label();
            tb_SourcePort = new TextBox();
            label2 = new Label();
            tb_SourceIP = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tb_DestPortOut = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            tb_DestIPOut = new TextBox();
            tb_SourceIPOut = new TextBox();
            label7 = new Label();
            tb_SourcePortOut = new TextBox();
            tb_Debug = new TextBox();
            cb_CLIOnly = new TextBox();
            bn_Go = new Button();
            bn_Quit = new Button();
            openFileDialog2 = new OpenFileDialog();
            cb_CLI = new CheckBox();
            bn_SaveConfig = new Button();
            bn_LoadConfig = new Button();
            cb_SourceIP = new CheckBox();
            cb_SourcePort = new CheckBox();
            cb_DestPort = new CheckBox();
            cb_DestIP = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // bn_InputFile
            // 
            bn_InputFile.Location = new Point(12, 12);
            bn_InputFile.Name = "bn_InputFile";
            bn_InputFile.Size = new Size(112, 34);
            bn_InputFile.TabIndex = 0;
            bn_InputFile.Text = "Input File";
            bn_InputFile.UseVisualStyleBackColor = true;
            bn_InputFile.Click += bn_InputFile_Click;
            // 
            // tb_InputFile
            // 
            tb_InputFile.Location = new Point(130, 14);
            tb_InputFile.Name = "tb_InputFile";
            tb_InputFile.Size = new Size(328, 31);
            tb_InputFile.TabIndex = 2;
            tb_InputFile.Text = "impact-gmti.pcap";
            // 
            // tb_OutputFile
            // 
            tb_OutputFile.Location = new Point(130, 60);
            tb_OutputFile.Name = "tb_OutputFile";
            tb_OutputFile.Size = new Size(328, 31);
            tb_OutputFile.TabIndex = 3;
            tb_OutputFile.Text = "impact-gmti_OUT.pcap";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_DestPort);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_DestIP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_SourcePort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_SourceIP);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 357);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input File";
            // 
            // tb_DestPort
            // 
            tb_DestPort.Location = new Point(20, 292);
            tb_DestPort.Name = "tb_DestPort";
            tb_DestPort.Size = new Size(250, 31);
            tb_DestPort.TabIndex = 12;
            tb_DestPort.Text = "2004";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 264);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 11;
            label3.Text = "Dest Port";
            // 
            // tb_DestIP
            // 
            tb_DestIP.Location = new Point(20, 214);
            tb_DestIP.Name = "tb_DestIP";
            tb_DestIP.Size = new Size(250, 31);
            tb_DestIP.TabIndex = 10;
            tb_DestIP.Text = "234.3.3.3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 186);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 9;
            label4.Text = "Dest IP";
            // 
            // tb_SourcePort
            // 
            tb_SourcePort.Location = new Point(20, 142);
            tb_SourcePort.Name = "tb_SourcePort";
            tb_SourcePort.Size = new Size(250, 31);
            tb_SourcePort.TabIndex = 8;
            tb_SourcePort.Text = "2004";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 114);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 7;
            label2.Text = "Source Port";
            // 
            // tb_SourceIP
            // 
            tb_SourceIP.Location = new Point(20, 64);
            tb_SourceIP.Name = "tb_SourceIP";
            tb_SourceIP.Size = new Size(250, 31);
            tb_SourceIP.TabIndex = 6;
            tb_SourceIP.Text = "172.16.10.180";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Source IP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_DestPortOut);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tb_DestIPOut);
            groupBox2.Controls.Add(tb_SourceIPOut);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tb_SourcePortOut);
            groupBox2.Location = new Point(427, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 357);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output File";
            // 
            // tb_DestPortOut
            // 
            tb_DestPortOut.Location = new Point(17, 292);
            tb_DestPortOut.Name = "tb_DestPortOut";
            tb_DestPortOut.Size = new Size(256, 31);
            tb_DestPortOut.TabIndex = 20;
            tb_DestPortOut.Text = "50060";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 186);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 17;
            label6.Text = "Dest IP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 264);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 19;
            label5.Text = "Dest Port";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 36);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 13;
            label8.Text = "Source IP";
            // 
            // tb_DestIPOut
            // 
            tb_DestIPOut.Location = new Point(17, 214);
            tb_DestIPOut.Name = "tb_DestIPOut";
            tb_DestIPOut.Size = new Size(256, 31);
            tb_DestIPOut.TabIndex = 18;
            tb_DestIPOut.Text = "24.1.1.7";
            // 
            // tb_SourceIPOut
            // 
            tb_SourceIPOut.Location = new Point(17, 64);
            tb_SourceIPOut.Name = "tb_SourceIPOut";
            tb_SourceIPOut.Size = new Size(256, 31);
            tb_SourceIPOut.TabIndex = 14;
            tb_SourceIPOut.Text = "1.3.235.5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 114);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 15;
            label7.Text = "Source Port";
            // 
            // tb_SourcePortOut
            // 
            tb_SourcePortOut.Location = new Point(17, 142);
            tb_SourcePortOut.Name = "tb_SourcePortOut";
            tb_SourcePortOut.Size = new Size(256, 31);
            tb_SourcePortOut.TabIndex = 16;
            tb_SourcePortOut.Text = "5000";
            // 
            // tb_Debug
            // 
            tb_Debug.Location = new Point(12, 476);
            tb_Debug.Multiline = true;
            tb_Debug.Name = "tb_Debug";
            tb_Debug.Size = new Size(1040, 136);
            tb_Debug.TabIndex = 6;
            // 
            // cb_CLIOnly
            // 
            cb_CLIOnly.CausesValidation = false;
            cb_CLIOnly.Location = new Point(803, 17);
            cb_CLIOnly.Multiline = true;
            cb_CLIOnly.Name = "cb_CLIOnly";
            cb_CLIOnly.ReadOnly = true;
            cb_CLIOnly.Size = new Size(427, 369);
            cb_CLIOnly.TabIndex = 3;
            cb_CLIOnly.Text = resources.GetString("cb_CLIOnly.Text");
            // 
            // bn_Go
            // 
            bn_Go.Location = new Point(1068, 476);
            bn_Go.Name = "bn_Go";
            bn_Go.Size = new Size(112, 54);
            bn_Go.TabIndex = 8;
            bn_Go.Text = "GO";
            bn_Go.UseVisualStyleBackColor = true;
            bn_Go.Click += bn_Go_Click;
            // 
            // bn_Quit
            // 
            bn_Quit.Location = new Point(1132, 561);
            bn_Quit.Name = "bn_Quit";
            bn_Quit.Size = new Size(112, 54);
            bn_Quit.TabIndex = 9;
            bn_Quit.Text = "Quit";
            bn_Quit.UseVisualStyleBackColor = true;
            bn_Quit.Click += bn_Quit_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // cb_CLI
            // 
            cb_CLI.AutoSize = true;
            cb_CLI.Location = new Point(948, 441);
            cb_CLI.Name = "cb_CLI";
            cb_CLI.Size = new Size(104, 29);
            cb_CLI.TabIndex = 10;
            cb_CLI.Text = "CLI Only";
            cb_CLI.UseVisualStyleBackColor = true;
            // 
            // bn_SaveConfig
            // 
            bn_SaveConfig.Location = new Point(623, 20);
            bn_SaveConfig.Name = "bn_SaveConfig";
            bn_SaveConfig.Size = new Size(112, 60);
            bn_SaveConfig.TabIndex = 11;
            bn_SaveConfig.Text = "Save Config";
            bn_SaveConfig.UseVisualStyleBackColor = true;
            bn_SaveConfig.Click += bn_SaveConfig_Click_1;
            // 
            // bn_LoadConfig
            // 
            bn_LoadConfig.Location = new Point(505, 20);
            bn_LoadConfig.Name = "bn_LoadConfig";
            bn_LoadConfig.Size = new Size(112, 60);
            bn_LoadConfig.TabIndex = 12;
            bn_LoadConfig.Text = "Reload Config";
            bn_LoadConfig.UseVisualStyleBackColor = true;
            bn_LoadConfig.Click += bn_LoadConfig_Click;
            // 
            // cb_SourceIP
            // 
            cb_SourceIP.AutoSize = true;
            cb_SourceIP.Checked = true;
            cb_SourceIP.CheckState = CheckState.Checked;
            cb_SourceIP.Location = new Point(345, 161);
            cb_SourceIP.Name = "cb_SourceIP";
            cb_SourceIP.Size = new Size(57, 29);
            cb_SourceIP.TabIndex = 13;
            cb_SourceIP.Text = "->";
            cb_SourceIP.UseVisualStyleBackColor = true;
            // 
            // cb_SourcePort
            // 
            cb_SourcePort.AutoSize = true;
            cb_SourcePort.Checked = true;
            cb_SourcePort.CheckState = CheckState.Checked;
            cb_SourcePort.Location = new Point(345, 239);
            cb_SourcePort.Name = "cb_SourcePort";
            cb_SourcePort.Size = new Size(57, 29);
            cb_SourcePort.TabIndex = 14;
            cb_SourcePort.Text = "->";
            cb_SourcePort.UseVisualStyleBackColor = true;
            // 
            // cb_DestPort
            // 
            cb_DestPort.AutoSize = true;
            cb_DestPort.Checked = true;
            cb_DestPort.CheckState = CheckState.Checked;
            cb_DestPort.Location = new Point(345, 389);
            cb_DestPort.Name = "cb_DestPort";
            cb_DestPort.Size = new Size(57, 29);
            cb_DestPort.TabIndex = 16;
            cb_DestPort.Text = "->";
            cb_DestPort.UseVisualStyleBackColor = true;
            // 
            // cb_DestIP
            // 
            cb_DestIP.AutoSize = true;
            cb_DestIP.Checked = true;
            cb_DestIP.CheckState = CheckState.Checked;
            cb_DestIP.Location = new Point(345, 311);
            cb_DestIP.Name = "cb_DestIP";
            cb_DestIP.Size = new Size(57, 29);
            cb_DestIP.TabIndex = 15;
            cb_DestIP.Text = "->";
            cb_DestIP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 627);
            Controls.Add(cb_DestPort);
            Controls.Add(cb_DestIP);
            Controls.Add(cb_SourcePort);
            Controls.Add(cb_SourceIP);
            Controls.Add(bn_LoadConfig);
            Controls.Add(bn_SaveConfig);
            Controls.Add(cb_CLIOnly);
            Controls.Add(cb_CLI);
            Controls.Add(bn_Quit);
            Controls.Add(bn_Go);
            Controls.Add(tb_Debug);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb_OutputFile);
            Controls.Add(tb_InputFile);
            Controls.Add(bn_InputFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BitTwistGUI V0.9 / 29 Sep 2023 / B.Graham";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bn_InputFile;
        private TextBox tb_InputFile;
        private TextBox tb_OutputFile;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tb_DestPort;
        private Label label3;
        private TextBox tb_DestIP;
        private Label label4;
        private TextBox tb_SourcePort;
        private Label label2;
        private TextBox tb_SourceIP;
        private TextBox tb_DestPortOut;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox tb_DestIPOut;
        private TextBox tb_SourceIPOut;
        private Label label7;
        private TextBox tb_SourcePortOut;
        private TextBox tb_Debug;
        private Panel panel1;
        private TextBox cb_CLIOnly;
        private Button bn_Go;
        private Button bn_Quit;
        private OpenFileDialog openFileDialog2;
        private CheckBox cb_CLI;
        private Button bn_SaveConfig;
        private Button bn_LoadConfig;
        private CheckBox cb_SourceIP;
        private CheckBox cb_SourcePort;
        private CheckBox cb_DestPort;
        private CheckBox cb_DestIP;
    }
}