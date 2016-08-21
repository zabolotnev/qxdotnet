using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qxDotNet;

namespace DemoApplication
{
    public partial class MainForm
    {

        private qxDotNet.UI.Indicator.ProgressBar progressBar;
        private qxDotNet.Event.Timer timer;

        private qxDotNet.UI.Tabview.Page loadPage3()
        {
            var page = new qxDotNet.UI.Tabview.Page();
            page.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Label = "Progress bar and timer";

            progressBar = new qxDotNet.UI.Indicator.ProgressBar();
            page.Add(progressBar, new Map()
                .Add("left", 10)
                .Add("top", 10));
            progressBar.Width = 300;

            progressBar.Maximum = 100;

            var btnStart = new qxDotNet.UI.Form.Button();
            btnStart.Label = "Start";
            page.Add(btnStart, new Map()
                .Add("left", 10)
                .Add("top", 50));
            btnStart.Execute += new EventHandler(btnStart_Execute);

            var btnStop = new qxDotNet.UI.Form.Button();
            btnStop.Label = "Stop";
            page.Add(btnStop, new Map()
                .Add("left", 60)
                .Add("top", 50));
            btnStop.Execute += new EventHandler(btnStop_Execute);

            timer = new qxDotNet.Event.Timer();
            timer.Enabled = false;
            timer.IntervalElapsed += new EventHandler(timer_IntervalElapsed);
            

            return page;
        }

        private void timer_IntervalElapsed(object sender, EventArgs e)
        {
            var v = progressBar.Value;
            v += 10;
            if (v > 100)
            {
                v = 0;
            }
            progressBar.Value = v;
        }

        private void btnStart_Execute(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void btnStop_Execute(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }

}
