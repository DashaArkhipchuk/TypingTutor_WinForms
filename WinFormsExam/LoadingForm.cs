using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsExam
{
    public partial class LoadingForm : Form
    {
        private Random random = new Random();

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomValue = random.Next(0, 21);

            if (progressBar1.Value + randomValue >= progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                Thread.Sleep(200);
            }
            else
                progressBar1.Value += randomValue;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();

                int waitTime = random.Next(1000, 3001);

                Thread.Sleep(waitTime);


                this.Close();

            }
        }

    }
}
