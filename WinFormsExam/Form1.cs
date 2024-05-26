using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsExam
{
    public partial class Form1 : Form
    {
        private int tempTimer = 0;
        private Random randChar = new Random();
        private string allKeysString = "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
        private bool flagCapsLock = false;
        private bool flagBackspace = true;
        private bool mesStop = true;
        private Timer timer = null;
        private int avgSpeed = 0;
        private int count = 0;
        private int fails = 0;
        private int speed = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            Failstb.Text = fails.ToString();
            labelDifficulty.Text = SliderDifficulty.Value.ToString();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
        }

        private void CapitalLetters()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (allKeysString.Contains(button.Text))
                    {
                        button.Text = button.Text.ToUpper();
                    }
                }
            }
        }

        private void LowerLetters()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (allKeysString.Contains(button.Text))
                    {
                        button.Text = button.Text.ToLower();
                    }
                }
            }
        }

        private void CapitalSymbol()
        {
            this.Oemtilde.Text = "~";
            this.D1.Text = "!";
            this.D2.Text = "@";
            this.D3.Text = "#";
            this.D4.Text = "$";
            this.D5.Text = "%";
            this.D6.Text = "^";
            this.D7.Text = "&&";
            this.D8.Text = "*";
            this.D9.Text = "(";
            this.D0.Text = ")";
            this.OemMinus.Text = "_";
            this.Oemplus.Text = "+";
            this.OemOpenBrackets.Text = "{";
            this.Oem6.Text = "}";
            this.Oem5.Text = "|";
            this.Oem1.Text = ":";
            this.Oem7.Text = "\"";
            this.Oemcomma.Text = "<";
            this.OemPeriod.Text = ">";
            this.OemQuestion.Text = "?";
        }
        private void LowerSymbol()
        {
            this.Oemtilde.Text = "`";
            this.D1.Text = "1";
            this.D2.Text = "2";
            this.D3.Text = "3";
            this.D4.Text = "4";
            this.D5.Text = "5";
            this.D6.Text = "6";
            this.D7.Text = "7";
            this.D8.Text = "8";
            this.D9.Text = "9";
            this.D0.Text = "0";
            this.OemMinus.Text = "-";
            this.Oemplus.Text = "=";
            this.OemOpenBrackets.Text = "[";
            this.Oem6.Text = "]";
            this.Oem5.Text = "\\";
            this.Oem1.Text = ";";
            this.Oem7.Text = "'";
            this.Oemcomma.Text = ",";
            this.OemPeriod.Text = ".";
            this.OemQuestion.Text = "/";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    Console.WriteLine(e.KeyCode.ToString());
                    if (button.Name == e.KeyCode.ToString() || 
                        (button.Name == "LeftShift" && e.KeyCode.ToString() == Keys.ShiftKey.ToString()) ||
                        (button.Name == "RightShift" && e.KeyCode.ToString() == Keys.ShiftKey.ToString()) || 
                        (button.Name=="LeftCtrl" && (e.KeyCode.ToString()==Keys.ControlKey.ToString())) || 
                        (button.Name == "RightCtrl" && (e.KeyCode.ToString() == Keys.ControlKey.ToString())) ||
                        (button.Name == "LAlt" && (e.KeyCode.ToString()==Keys.Menu.ToString())) ||
                        (button.Name == "RAlt" && (e.KeyCode.ToString() == Keys.Menu.ToString()))
                        )
                    {
                        button.FlatStyle = FlatStyle.Popup;

                        if (e.KeyCode.ToString() == Keys.ShiftKey.ToString())
                        {
                            CapitalSymbol();
                            if (flagCapsLock)
                            {
                                LowerLetters();
                            }
                            else
                            {
                                CapitalLetters();
                            }
                        }
                        if (e.KeyCode == Keys.Tab)
                        {
                            this.Tab.FlatStyle = FlatStyle.Popup;
                        }
                        else if (e.KeyCode == Keys.Capital)
                        {
                            flagCapsLock = !flagCapsLock;
                            if (flagCapsLock)
                            {
                                CapitalLetters();
                            }
                            else
                            {
                                LowerLetters();
                            }
                        }
                        else if (e.KeyCode == Keys.Back)
                        {
                            flagBackspace = false;
                        }
                        else
                        {
                            flagBackspace = true;
                        }
                    }
                }
            }
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            lineUser.Focus();

            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    if (button.Name == e.KeyCode.ToString() || 
                        (button.Name == "LeftShift" && e.KeyCode.ToString() == Keys.ShiftKey.ToString()) || 
                        (button.Name == "RightShift" && e.KeyCode.ToString() == Keys.ShiftKey.ToString()) ||
                        (button.Name == "LeftCtrl" && (e.KeyCode.ToString() == Keys.ControlKey.ToString())) ||
                        (button.Name == "RightCtrl" && (e.KeyCode.ToString() == Keys.ControlKey.ToString())) ||
                        (button.Name == "LAlt" && (e.KeyCode.ToString() == Keys.Menu.ToString())) ||
                        (button.Name == "RAlt" && (e.KeyCode.ToString() == Keys.Menu.ToString()))
                        )
                    {
                        button.FlatStyle = FlatStyle.Standard;

                        if (e.KeyCode == Keys.ShiftKey)
                        {
                            LowerSymbol();
                            if (!flagCapsLock)
                            {
                                LowerLetters();
                            }
                            else
                            {
                                CapitalLetters();
                            }
                        }
                    }
                }
            }
            if (!mesStop)
            {
                int res = (int)avgSpeed / count;
                MessageBox.Show($"Task completed.\n Number of symbols {linePrograms.Text.Length}.\n Average speed: {res} chars/min\n Number of fails {fails}.\nTo finish the task press button \"Stop\"", "Task Completed", MessageBoxButtons.OK);
                if (MessageBox.Show($"Do you want to save the result?", "Task Completed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FormResults formResults = new FormResults(res,fails,tempTimer,DateTime.Now);
                    formResults.Show();
                }

                mesStop = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempTimer++;
            SpeedSet();
        }

        private void SpeedSet()
        {
            count++;
            avgSpeed += speed;
            speed = (int)Math.Round(((double)lineUser.Text.Length / tempTimer) * 60);

            SpeedChar.Text = speed.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            SliderDifficulty.Enabled = false;
            CaseSensitive.Enabled = false;
            StopButton.Enabled = true;
            tempTimer = 0;
            timer.Start();
            CollectString((int)SliderDifficulty.Value, allKeysString, !CaseSensitive.Checked);
            lineUser.ReadOnly = false;
            lineUser.Enabled = true;
            lineUser.Focus();
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            SliderDifficulty.Enabled = true;
            CaseSensitive.Enabled = true;
            StopButton.Enabled = false;
            lineUser.Text = "";
            linePrograms.Text = "";
            speed = 0;
            fails = 0;
            lineUser.ReadOnly = true;
            lineUser.Enabled = false;
            timer.Stop();
            tempTimer = 0;
            stopToolStripMenuItem.Enabled = false;
            startToolStripMenuItem.Enabled = true;
        }

        private void lineUser_TextChanged(object sender, EventArgs e)
        {
            string strProgram = linePrograms.Text.Substring(0, lineUser.Text.Length);
            string strUser = CaseSensitive.Checked == true ? lineUser.Text : lineUser.Text.ToLower();
            if (CaseSensitive.Checked == false)
            {
                strProgram.ToLower();
                lineUser.Text.ToLower();
            }
            if (strUser.Equals(strProgram))
            {
                if (flagBackspace)
                {
                    SpeedSet();
                }
                lineUser.ForeColor = Color.Black;
            }
            else
            {
                if (flagBackspace)
                {
                    SpeedSet();
                    fails++;
                    Failstb.Text = fails.ToString();
                }
                lineUser.ForeColor = Color.Red;
            }
            if (lineUser.Text.Length == linePrograms.Text.Length)
            {
                timer.Stop();
                SpeedSet();
                lineUser.ReadOnly = true;
                mesStop = false;
            }
        }

        private void CaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if (CaseSensitive.Checked)
            {
                SliderDifficulty.Maximum = 94;
            }
            else
            {
                SliderDifficulty.Maximum = 47;
            }
        }

        private void CollectString(int countChar, string baseString, bool flagSensitive)
        {
            string chars = "";
            int sensitive = (flagSensitive) ? 47 : 0;
            for (int i = 0; i < countChar; i++)
            {
                chars += baseString[randChar.Next(sensitive, baseString.Length)];
            }
            chars += " ";
            int countString = (flagSensitive) ? 75 : 70;
            for (int i = 0; i < countString; i++)
            {
                linePrograms.Text += chars[randChar.Next(0, chars.Length)];
            }
        }

        private void SliderDifficulty_Scroll(object sender, EventArgs e)
        {
            this.labelDifficulty.Text= this.SliderDifficulty.Value.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Click(sender, e);
        }

        private void viewResultsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResults form=new FormResults();
            form.Show();
        }
    }
}
