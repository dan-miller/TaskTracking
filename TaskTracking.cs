using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracking
{
    public partial class TaskTracking : Form
    {
        private System.Timers.Timer timer;
        private Stopwatch stopwatch;
        private List<string> tasks;
        public TaskTracking()
        {
            InitializeComponent();

            this.TopLevel = true;

            stopwatch = new Stopwatch();
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += Timer_Elapsed;

            var fdr = new StreamReader("tasks.ini");
            tasks = new List<string>();

            while (!fdr.EndOfStream)
            {
                tasks.Add(fdr.ReadLine().Trim());
            }

            fdr.Close();
            tasks.Sort();
            c_TaskSelection.Items.AddRange(tasks.ToArray());
        }

        delegate void SetTimerTextCallback(string text);

        private void SetTimerText(string text)
        {
            if (this.l_Time.InvokeRequired)
            {
                var _dispatcher_ = new SetTimerTextCallback(SetTimerText);
                this.Invoke(_dispatcher_, new object[] { text });
            }
            else
            {
                this.l_Time.Text = text;
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var timerText = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff");
            SetTimerText(timerText);
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            timer.Start();
            stopwatch.Reset();
            stopwatch.Start();
        }

        private void b_Stop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer.Stop();

            var messageTimer = new System.Timers.Timer() { Interval = 15000, AutoReset = false };
            messageTimer.Elapsed += MessageTimer_Elapsed;

            if (stopwatch.ElapsedMilliseconds == 0) return;

            if (c_TaskSelection.SelectedItem == null || c_TaskSelection.SelectedItem.ToString() == string.Empty)
            {
                l_WriteSuccess.Text = "No data written";
                messageTimer.Start();
            }
            else
            {
                var elapsedHours = (int)Math.Ceiling((double)stopwatch.ElapsedMilliseconds / 1000 / 60 / 60);
                var fdw = new StreamWriter("tasks.csv", true);
                fdw.WriteLine($"{DateTime.Today.ToShortDateString()},{c_TaskSelection.SelectedItem.ToString()},{elapsedHours.ToString()}");

                l_WriteSuccess.Text = $"{elapsedHours} hours -> {c_TaskSelection.SelectedItem}";
                messageTimer.Start();
                fdw.Close();

            }

        }

        delegate void ClearMessageTimerCallback();

        private void ClearMessageTimer()
        {
            if (this.l_WriteSuccess.InvokeRequired)
            {
                var _dispatcher_ = new ClearMessageTimerCallback(ClearMessageTimer);
                this.Invoke(_dispatcher_);
            }
            else
            {
                this.l_WriteSuccess.Text = string.Empty;
            }

        }

        private void MessageTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ClearMessageTimer();
        }
    }
}
