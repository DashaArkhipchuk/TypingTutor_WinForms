using System.Drawing;
using System.Windows.Forms;

namespace WinFormsExam
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
        /// 


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedChar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Failstb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SliderDifficulty = new System.Windows.Forms.TrackBar();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.linePrograms = new System.Windows.Forms.TextBox();
            this.lineUser = new System.Windows.Forms.TextBox();
            this.Oemtilde = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.D5 = new System.Windows.Forms.Button();
            this.D6 = new System.Windows.Forms.Button();
            this.D7 = new System.Windows.Forms.Button();
            this.D8 = new System.Windows.Forms.Button();
            this.D9 = new System.Windows.Forms.Button();
            this.D0 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.OemOpenBrackets = new System.Windows.Forms.Button();
            this.Oem6 = new System.Windows.Forms.Button();
            this.Oem5 = new System.Windows.Forms.Button();
            this.OemMinus = new System.Windows.Forms.Button();
            this.Oemplus = new System.Windows.Forms.Button();
            this.Capital = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.Oem1 = new System.Windows.Forms.Button();
            this.Oem7 = new System.Windows.Forms.Button();
            this.LeftShift = new System.Windows.Forms.Button();
            this.RightShift = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.Oemcomma = new System.Windows.Forms.Button();
            this.OemPeriod = new System.Windows.Forms.Button();
            this.OemQuestion = new System.Windows.Forms.Button();
            this.LeftCtrl = new System.Windows.Forms.Button();
            this.RightCtrl = new System.Windows.Forms.Button();
            this.FnFn = new System.Windows.Forms.Button();
            this.RWin = new System.Windows.Forms.Button();
            this.LAlt = new System.Windows.Forms.Button();
            this.RAlt = new System.Windows.Forms.Button();
            this.Space = new System.Windows.Forms.Button();
            this.CaseSensitive = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keyboardTrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SliderDifficulty)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "chars/min";
            // 
            // SpeedChar
            // 
            this.SpeedChar.AutoSize = true;
            this.SpeedChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedChar.Location = new System.Drawing.Point(70, 32);
            this.SpeedChar.Name = "SpeedChar";
            this.SpeedChar.Size = new System.Drawing.Size(0, 20);
            this.SpeedChar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(213, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fails:";
            // 
            // Failstb
            // 
            this.Failstb.AutoSize = true;
            this.Failstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Failstb.Location = new System.Drawing.Point(265, 32);
            this.Failstb.Name = "Failstb";
            this.Failstb.Size = new System.Drawing.Size(0, 20);
            this.Failstb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(290, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Difficulty:";
            // 
            // SliderDifficulty
            // 
            this.SliderDifficulty.Location = new System.Drawing.Point(400, 32);
            this.SliderDifficulty.Maximum = 47;
            this.SliderDifficulty.Minimum = 1;
            this.SliderDifficulty.Name = "SliderDifficulty";
            this.SliderDifficulty.Size = new System.Drawing.Size(325, 45);
            this.SliderDifficulty.TabIndex = 6;
            this.SliderDifficulty.TabStop = false;
            this.SliderDifficulty.Value = 1;
            this.SliderDifficulty.Scroll += new System.EventHandler(this.SliderDifficulty_Scroll);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDifficulty.Location = new System.Drawing.Point(370, 35);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(0, 20);
            this.labelDifficulty.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(294, 66);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(182, 28);
            this.StartButton.TabIndex = 8;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(482, 66);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(182, 28);
            this.StopButton.TabIndex = 9;
            this.StopButton.TabStop = false;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // linePrograms
            // 
            this.linePrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(239)))));
            this.linePrograms.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linePrograms.Location = new System.Drawing.Point(0, 100);
            this.linePrograms.Name = "linePrograms";
            this.linePrograms.ReadOnly = true;
            this.linePrograms.Size = new System.Drawing.Size(847, 26);
            this.linePrograms.TabIndex = 10;
            this.linePrograms.TabStop = false;
            // 
            // lineUser
            // 
            this.lineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(239)))));
            this.lineUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineUser.Location = new System.Drawing.Point(0, 123);
            this.lineUser.Name = "lineUser";
            this.lineUser.ReadOnly = true;
            this.lineUser.Size = new System.Drawing.Size(847, 26);
            this.lineUser.TabIndex = 11;
            this.lineUser.TabStop = false;
            this.lineUser.TextChanged += new System.EventHandler(this.lineUser_TextChanged);
            // 
            // Oemtilde
            // 
            this.Oemtilde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.Oemtilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oemtilde.Location = new System.Drawing.Point(8, 166);
            this.Oemtilde.Name = "Oemtilde";
            this.Oemtilde.Size = new System.Drawing.Size(50, 50);
            this.Oemtilde.TabIndex = 12;
            this.Oemtilde.TabStop = false;
            this.Oemtilde.Text = "`";
            this.Oemtilde.UseVisualStyleBackColor = false;
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D1.Location = new System.Drawing.Point(64, 166);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(50, 50);
            this.D1.TabIndex = 53;
            this.D1.TabStop = false;
            this.D1.Text = "1";
            this.D1.UseVisualStyleBackColor = false;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.D2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D2.Location = new System.Drawing.Point(120, 165);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(50, 50);
            this.D2.TabIndex = 14;
            this.D2.TabStop = false;
            this.D2.Text = "2";
            this.D2.UseVisualStyleBackColor = false;
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.D3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D3.Location = new System.Drawing.Point(176, 166);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(50, 50);
            this.D3.TabIndex = 14;
            this.D3.TabStop = false;
            this.D3.Text = "3";
            this.D3.UseVisualStyleBackColor = false;
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D4.Location = new System.Drawing.Point(232, 166);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(50, 50);
            this.D4.TabIndex = 14;
            this.D4.TabStop = false;
            this.D4.Text = "4";
            this.D4.UseVisualStyleBackColor = false;
            // 
            // D5
            // 
            this.D5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.D5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D5.Location = new System.Drawing.Point(288, 166);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(50, 50);
            this.D5.TabIndex = 14;
            this.D5.TabStop = false;
            this.D5.Text = "5";
            this.D5.UseVisualStyleBackColor = false;
            // 
            // D6
            // 
            this.D6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.D6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D6.Location = new System.Drawing.Point(344, 166);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(50, 50);
            this.D6.TabIndex = 14;
            this.D6.TabStop = false;
            this.D6.Text = "6";
            this.D6.UseVisualStyleBackColor = false;
            // 
            // D7
            // 
            this.D7.BackColor = System.Drawing.Color.Turquoise;
            this.D7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D7.Location = new System.Drawing.Point(400, 165);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(50, 50);
            this.D7.TabIndex = 14;
            this.D7.TabStop = false;
            this.D7.Text = "7";
            this.D7.UseVisualStyleBackColor = false;
            // 
            // D8
            // 
            this.D8.BackColor = System.Drawing.Color.Turquoise;
            this.D8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D8.Location = new System.Drawing.Point(456, 166);
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(50, 50);
            this.D8.TabIndex = 52;
            this.D8.TabStop = false;
            this.D8.Text = "8";
            this.D8.UseVisualStyleBackColor = false;
            // 
            // D9
            // 
            this.D9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.D9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D9.Location = new System.Drawing.Point(512, 166);
            this.D9.Name = "D9";
            this.D9.Size = new System.Drawing.Size(50, 50);
            this.D9.TabIndex = 51;
            this.D9.TabStop = false;
            this.D9.Text = "9";
            this.D9.UseVisualStyleBackColor = false;
            // 
            // D0
            // 
            this.D0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.D0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D0.Location = new System.Drawing.Point(568, 165);
            this.D0.Name = "D0";
            this.D0.Size = new System.Drawing.Size(50, 50);
            this.D0.TabIndex = 50;
            this.D0.TabStop = false;
            this.D0.Text = "0";
            this.D0.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(736, 166);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 50);
            this.Back.TabIndex = 49;
            this.Back.TabStop = false;
            this.Back.Text = "Backspace";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tab.Location = new System.Drawing.Point(8, 222);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(81, 49);
            this.Tab.TabIndex = 48;
            this.Tab.TabStop = false;
            this.Tab.Text = "Tab";
            this.Tab.UseVisualStyleBackColor = true;
            // 
            // Q
            // 
            this.Q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q.Location = new System.Drawing.Point(95, 221);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(50, 50);
            this.Q.TabIndex = 47;
            this.Q.TabStop = false;
            this.Q.Text = "q";
            this.Q.UseVisualStyleBackColor = false;
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W.Location = new System.Drawing.Point(151, 221);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(50, 50);
            this.W.TabIndex = 46;
            this.W.TabStop = false;
            this.W.Text = "w";
            this.W.UseVisualStyleBackColor = false;
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.E.Location = new System.Drawing.Point(207, 222);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(50, 50);
            this.E.TabIndex = 45;
            this.E.TabStop = false;
            this.E.Text = "e";
            this.E.UseVisualStyleBackColor = false;
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R.Location = new System.Drawing.Point(263, 222);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(50, 50);
            this.R.TabIndex = 44;
            this.R.TabStop = false;
            this.R.Text = "r";
            this.R.UseVisualStyleBackColor = false;
            // 
            // T
            // 
            this.T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T.Location = new System.Drawing.Point(319, 222);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(50, 50);
            this.T.TabIndex = 43;
            this.T.TabStop = false;
            this.T.Text = "t";
            this.T.UseVisualStyleBackColor = false;
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.Turquoise;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(375, 222);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(50, 50);
            this.Y.TabIndex = 42;
            this.Y.TabStop = false;
            this.Y.Text = "y";
            this.Y.UseVisualStyleBackColor = false;
            // 
            // U
            // 
            this.U.BackColor = System.Drawing.Color.Turquoise;
            this.U.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.U.Location = new System.Drawing.Point(431, 222);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(50, 50);
            this.U.TabIndex = 41;
            this.U.TabStop = false;
            this.U.Text = "u";
            this.U.UseVisualStyleBackColor = false;
            // 
            // I
            // 
            this.I.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.I.Location = new System.Drawing.Point(486, 222);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(50, 50);
            this.I.TabIndex = 40;
            this.I.TabStop = false;
            this.I.Text = "i";
            this.I.UseVisualStyleBackColor = false;
            // 
            // O
            // 
            this.O.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.O.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.O.Location = new System.Drawing.Point(542, 222);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(50, 50);
            this.O.TabIndex = 39;
            this.O.TabStop = false;
            this.O.Text = "o";
            this.O.UseVisualStyleBackColor = false;
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P.Location = new System.Drawing.Point(598, 221);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(50, 50);
            this.P.TabIndex = 38;
            this.P.TabStop = false;
            this.P.Text = "p";
            this.P.UseVisualStyleBackColor = false;
            // 
            // OemOpenBrackets
            // 
            this.OemOpenBrackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.OemOpenBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OemOpenBrackets.Location = new System.Drawing.Point(654, 221);
            this.OemOpenBrackets.Name = "OemOpenBrackets";
            this.OemOpenBrackets.Size = new System.Drawing.Size(50, 50);
            this.OemOpenBrackets.TabIndex = 37;
            this.OemOpenBrackets.TabStop = false;
            this.OemOpenBrackets.Text = "[";
            this.OemOpenBrackets.UseVisualStyleBackColor = false;
            // 
            // Oem6
            // 
            this.Oem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.Oem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oem6.Location = new System.Drawing.Point(710, 221);
            this.Oem6.Name = "Oem6";
            this.Oem6.Size = new System.Drawing.Size(50, 50);
            this.Oem6.TabIndex = 36;
            this.Oem6.TabStop = false;
            this.Oem6.Text = "]";
            this.Oem6.UseVisualStyleBackColor = false;
            // 
            // Oem5
            // 
            this.Oem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.Oem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oem5.Location = new System.Drawing.Point(766, 222);
            this.Oem5.Name = "Oem5";
            this.Oem5.Size = new System.Drawing.Size(73, 50);
            this.Oem5.TabIndex = 35;
            this.Oem5.TabStop = false;
            this.Oem5.Text = "\\";
            this.Oem5.UseVisualStyleBackColor = false;
            // 
            // OemMinus
            // 
            this.OemMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.OemMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OemMinus.Location = new System.Drawing.Point(624, 165);
            this.OemMinus.Name = "OemMinus";
            this.OemMinus.Size = new System.Drawing.Size(50, 50);
            this.OemMinus.TabIndex = 34;
            this.OemMinus.TabStop = false;
            this.OemMinus.Text = "-";
            this.OemMinus.UseVisualStyleBackColor = false;
            // 
            // Oemplus
            // 
            this.Oemplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.Oemplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oemplus.Location = new System.Drawing.Point(680, 165);
            this.Oemplus.Name = "Oemplus";
            this.Oemplus.Size = new System.Drawing.Size(50, 50);
            this.Oemplus.TabIndex = 33;
            this.Oemplus.TabStop = false;
            this.Oemplus.Text = "=";
            this.Oemplus.UseVisualStyleBackColor = false;
            // 
            // Capital
            // 
            this.Capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capital.Location = new System.Drawing.Point(8, 277);
            this.Capital.Name = "Capital";
            this.Capital.Size = new System.Drawing.Size(106, 49);
            this.Capital.TabIndex = 32;
            this.Capital.TabStop = false;
            this.Capital.Text = "Caps Lock";
            this.Capital.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.Location = new System.Drawing.Point(736, 276);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(103, 50);
            this.Return.TabIndex = 31;
            this.Return.TabStop = false;
            this.Return.Text = "Enter";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(120, 277);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(50, 50);
            this.A.TabIndex = 30;
            this.A.TabStop = false;
            this.A.Text = "a";
            this.A.UseVisualStyleBackColor = false;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(176, 278);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(50, 50);
            this.S.TabIndex = 29;
            this.S.TabStop = false;
            this.S.Text = "s";
            this.S.UseVisualStyleBackColor = false;
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.Location = new System.Drawing.Point(232, 278);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(50, 50);
            this.D.TabIndex = 28;
            this.D.TabStop = false;
            this.D.Text = "d";
            this.D.UseVisualStyleBackColor = false;
            // 
            // F
            // 
            this.F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F.Location = new System.Drawing.Point(288, 278);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(50, 50);
            this.F.TabIndex = 27;
            this.F.TabStop = false;
            this.F.Text = "f";
            this.F.UseVisualStyleBackColor = false;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.G.Location = new System.Drawing.Point(344, 278);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(50, 50);
            this.G.TabIndex = 26;
            this.G.TabStop = false;
            this.G.Text = "g";
            this.G.UseVisualStyleBackColor = false;
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.Color.Turquoise;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.H.Location = new System.Drawing.Point(400, 278);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(50, 50);
            this.H.TabIndex = 25;
            this.H.TabStop = false;
            this.H.Text = "h";
            this.H.UseVisualStyleBackColor = false;
            // 
            // J
            // 
            this.J.BackColor = System.Drawing.Color.Turquoise;
            this.J.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J.Location = new System.Drawing.Point(456, 278);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(50, 50);
            this.J.TabIndex = 24;
            this.J.TabStop = false;
            this.J.Text = "j";
            this.J.UseVisualStyleBackColor = false;
            // 
            // K
            // 
            this.K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.K.Location = new System.Drawing.Point(512, 278);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(50, 50);
            this.K.TabIndex = 23;
            this.K.TabStop = false;
            this.K.Text = "k";
            this.K.UseVisualStyleBackColor = false;
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L.Location = new System.Drawing.Point(568, 277);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(50, 50);
            this.L.TabIndex = 22;
            this.L.TabStop = false;
            this.L.Text = "l";
            this.L.UseVisualStyleBackColor = false;
            // 
            // Oem1
            // 
            this.Oem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.Oem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oem1.Location = new System.Drawing.Point(624, 277);
            this.Oem1.Name = "Oem1";
            this.Oem1.Size = new System.Drawing.Size(50, 50);
            this.Oem1.TabIndex = 21;
            this.Oem1.TabStop = false;
            this.Oem1.Text = ";";
            this.Oem1.UseVisualStyleBackColor = false;
            // 
            // Oem7
            // 
            this.Oem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.Oem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oem7.Location = new System.Drawing.Point(680, 277);
            this.Oem7.Name = "Oem7";
            this.Oem7.Size = new System.Drawing.Size(50, 50);
            this.Oem7.TabIndex = 20;
            this.Oem7.TabStop = false;
            this.Oem7.Text = "\'";
            this.Oem7.UseVisualStyleBackColor = false;
            // 
            // LeftShift
            // 
            this.LeftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftShift.Location = new System.Drawing.Point(8, 332);
            this.LeftShift.Name = "LeftShift";
            this.LeftShift.Size = new System.Drawing.Size(137, 49);
            this.LeftShift.TabIndex = 19;
            this.LeftShift.TabStop = false;
            this.LeftShift.Text = "Shift";
            this.LeftShift.UseVisualStyleBackColor = true;
            // 
            // RightShift
            // 
            this.RightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightShift.Location = new System.Drawing.Point(710, 333);
            this.RightShift.Name = "RightShift";
            this.RightShift.Size = new System.Drawing.Size(129, 50);
            this.RightShift.TabIndex = 18;
            this.RightShift.TabStop = false;
            this.RightShift.Text = "Shift";
            this.RightShift.UseVisualStyleBackColor = true;
            // 
            // Z
            // 
            this.Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(151, 332);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(50, 50);
            this.Z.TabIndex = 17;
            this.Z.TabStop = false;
            this.Z.Text = "z";
            this.Z.UseVisualStyleBackColor = false;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(206, 334);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(50, 50);
            this.X.TabIndex = 16;
            this.X.TabStop = false;
            this.X.Text = "x";
            this.X.UseVisualStyleBackColor = false;
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(262, 334);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 50);
            this.C.TabIndex = 15;
            this.C.TabStop = false;
            this.C.Text = "c";
            this.C.UseVisualStyleBackColor = false;
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.V.Location = new System.Drawing.Point(318, 334);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(50, 50);
            this.V.TabIndex = 14;
            this.V.TabStop = false;
            this.V.Text = "v";
            this.V.UseVisualStyleBackColor = false;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B.Location = new System.Drawing.Point(374, 334);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(50, 50);
            this.B.TabIndex = 13;
            this.B.TabStop = false;
            this.B.Text = "b";
            this.B.UseVisualStyleBackColor = false;
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.Color.Turquoise;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(430, 334);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(50, 50);
            this.N.TabIndex = 12;
            this.N.TabStop = false;
            this.N.Text = "n";
            this.N.UseVisualStyleBackColor = false;
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.Color.Turquoise;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M.Location = new System.Drawing.Point(486, 334);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(50, 50);
            this.M.TabIndex = 11;
            this.M.TabStop = false;
            this.M.Text = "m";
            this.M.UseVisualStyleBackColor = false;
            // 
            // Oemcomma
            // 
            this.Oemcomma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(116)))));
            this.Oemcomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oemcomma.Location = new System.Drawing.Point(542, 334);
            this.Oemcomma.Name = "Oemcomma";
            this.Oemcomma.Size = new System.Drawing.Size(50, 50);
            this.Oemcomma.TabIndex = 10;
            this.Oemcomma.TabStop = false;
            this.Oemcomma.Text = ",";
            this.Oemcomma.UseVisualStyleBackColor = false;
            // 
            // OemPeriod
            // 
            this.OemPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(216)))));
            this.OemPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OemPeriod.Location = new System.Drawing.Point(598, 333);
            this.OemPeriod.Name = "OemPeriod";
            this.OemPeriod.Size = new System.Drawing.Size(50, 50);
            this.OemPeriod.TabIndex = 9;
            this.OemPeriod.TabStop = false;
            this.OemPeriod.Text = ".";
            this.OemPeriod.UseVisualStyleBackColor = false;
            // 
            // OemQuestion
            // 
            this.OemQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(116)))));
            this.OemQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OemQuestion.Location = new System.Drawing.Point(654, 333);
            this.OemQuestion.Name = "OemQuestion";
            this.OemQuestion.Size = new System.Drawing.Size(50, 50);
            this.OemQuestion.TabIndex = 8;
            this.OemQuestion.TabStop = false;
            this.OemQuestion.Text = "/";
            this.OemQuestion.UseVisualStyleBackColor = false;
            // 
            // LeftCtrl
            // 
            this.LeftCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftCtrl.Location = new System.Drawing.Point(8, 387);
            this.LeftCtrl.Name = "LeftCtrl";
            this.LeftCtrl.Size = new System.Drawing.Size(81, 49);
            this.LeftCtrl.TabIndex = 7;
            this.LeftCtrl.TabStop = false;
            this.LeftCtrl.Text = "Ctrl";
            this.LeftCtrl.UseVisualStyleBackColor = true;
            // 
            // RightCtrl
            // 
            this.RightCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightCtrl.Location = new System.Drawing.Point(758, 389);
            this.RightCtrl.Name = "RightCtrl";
            this.RightCtrl.Size = new System.Drawing.Size(81, 49);
            this.RightCtrl.TabIndex = 6;
            this.RightCtrl.TabStop = false;
            this.RightCtrl.Text = "Ctrl";
            this.RightCtrl.UseVisualStyleBackColor = true;
            // 
            // FnFn
            // 
            this.FnFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FnFn.Location = new System.Drawing.Point(95, 389);
            this.FnFn.Name = "FnFn";
            this.FnFn.Size = new System.Drawing.Size(81, 49);
            this.FnFn.TabIndex = 5;
            this.FnFn.TabStop = false;
            this.FnFn.Text = "Fn";
            this.FnFn.UseVisualStyleBackColor = true;
            // 
            // RWin
            // 
            this.RWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RWin.Location = new System.Drawing.Point(671, 389);
            this.RWin.Name = "RWin";
            this.RWin.Size = new System.Drawing.Size(81, 49);
            this.RWin.TabIndex = 4;
            this.RWin.TabStop = false;
            this.RWin.Text = "Win";
            this.RWin.UseVisualStyleBackColor = true;
            // 
            // LAlt
            // 
            this.LAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAlt.Location = new System.Drawing.Point(182, 390);
            this.LAlt.Name = "LAlt";
            this.LAlt.Size = new System.Drawing.Size(81, 49);
            this.LAlt.TabIndex = 3;
            this.LAlt.TabStop = false;
            this.LAlt.Text = "Alt";
            this.LAlt.UseVisualStyleBackColor = true;
            // 
            // RAlt
            // 
            this.RAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAlt.Location = new System.Drawing.Point(584, 390);
            this.RAlt.Name = "RAlt";
            this.RAlt.Size = new System.Drawing.Size(81, 49);
            this.RAlt.TabIndex = 2;
            this.RAlt.TabStop = false;
            this.RAlt.Text = "Alt";
            this.RAlt.UseVisualStyleBackColor = true;
            // 
            // Space
            // 
            this.Space.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(187)))), ((int)(((byte)(114)))));
            this.Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Space.Location = new System.Drawing.Point(269, 390);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(309, 49);
            this.Space.TabIndex = 1;
            this.Space.TabStop = false;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = false;
            // 
            // CaseSensitive
            // 
            this.CaseSensitive.AutoSize = true;
            this.CaseSensitive.Location = new System.Drawing.Point(736, 39);
            this.CaseSensitive.Name = "CaseSensitive";
            this.CaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.CaseSensitive.TabIndex = 0;
            this.CaseSensitive.TabStop = false;
            this.CaseSensitive.Text = "Case Sensitive";
            this.CaseSensitive.UseVisualStyleBackColor = true;
            this.CaseSensitive.CheckedChanged += new System.EventHandler(this.CaseSensitive_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.keyboardTrainerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keyboardTrainerToolStripMenuItem
            // 
            this.keyboardTrainerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.viewResultsTableToolStripMenuItem});
            this.keyboardTrainerToolStripMenuItem.Name = "keyboardTrainerToolStripMenuItem";
            this.keyboardTrainerToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.keyboardTrainerToolStripMenuItem.Text = "Keyboard trainer";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // viewResultsTableToolStripMenuItem
            // 
            this.viewResultsTableToolStripMenuItem.Name = "viewResultsTableToolStripMenuItem";
            this.viewResultsTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewResultsTableToolStripMenuItem.Text = "View Results Table";
            this.viewResultsTableToolStripMenuItem.Click += new System.EventHandler(this.viewResultsTableToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Close window";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(845, 475);
            this.Controls.Add(this.CaseSensitive);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.RAlt);
            this.Controls.Add(this.LAlt);
            this.Controls.Add(this.RWin);
            this.Controls.Add(this.FnFn);
            this.Controls.Add(this.RightCtrl);
            this.Controls.Add(this.LeftCtrl);
            this.Controls.Add(this.OemQuestion);
            this.Controls.Add(this.OemPeriod);
            this.Controls.Add(this.Oemcomma);
            this.Controls.Add(this.M);
            this.Controls.Add(this.N);
            this.Controls.Add(this.B);
            this.Controls.Add(this.V);
            this.Controls.Add(this.C);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.RightShift);
            this.Controls.Add(this.LeftShift);
            this.Controls.Add(this.Oem7);
            this.Controls.Add(this.Oem1);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Capital);
            this.Controls.Add(this.Oemplus);
            this.Controls.Add(this.OemMinus);
            this.Controls.Add(this.Oem5);
            this.Controls.Add(this.Oem6);
            this.Controls.Add(this.OemOpenBrackets);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.I);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.T);
            this.Controls.Add(this.R);
            this.Controls.Add(this.E);
            this.Controls.Add(this.W);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.D0);
            this.Controls.Add(this.D9);
            this.Controls.Add(this.D8);
            this.Controls.Add(this.D7);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.D5);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.Oemtilde);
            this.Controls.Add(this.lineUser);
            this.Controls.Add(this.linePrograms);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.SliderDifficulty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Failstb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeedChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.SliderDifficulty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label SpeedChar;
        private Label label3;
        private Label Failstb;
        private Label label4;
        private TrackBar SliderDifficulty;
        private Label labelDifficulty;
        private Button StartButton;
        private Button StopButton;
        private TextBox linePrograms;
        private TextBox lineUser;
        private Button Oemtilde;
        private Button D1;
        private Button D2;
        private Button D3;
        private Button D4;
        private Button D5;
        private Button D6;
        private Button D7;
        private Button D8;
        private Button D9;
        private Button D0;
        private Button Back;
        private Button Tab;
        private Button Q;
        private Button W;
        private Button E;
        private Button R;
        private Button T;
        private Button Y;
        private Button U;
        private Button I;
        private Button O;
        private Button P;
        private Button OemOpenBrackets;
        private Button Oem6;
        private Button Oem5;
        private Button OemMinus;
        private Button Oemplus;
        private Button Capital;
        private Button Return;
        private Button A;
        private Button S;
        private Button D;
        private Button F;
        private Button G;
        private Button H;
        private Button J;
        private Button K;
        private Button L;
        private Button Oem1;
        private Button Oem7;
        private Button LeftShift;
        private Button RightShift;
        private Button Z;
        private Button X;
        private Button C;
        private Button V;
        private Button B;
        private Button N;
        private Button M;
        private Button Oemcomma;
        private Button OemPeriod;
        private Button OemQuestion;
        private Button LeftCtrl;
        private Button RightCtrl;
        private Button FnFn;
        private Button RWin;
        private Button LAlt;
        private Button RAlt;
        private Button Space;
        private CheckBox CaseSensitive;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem keyboardTrainerToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewResultsTableToolStripMenuItem;
    }
}

