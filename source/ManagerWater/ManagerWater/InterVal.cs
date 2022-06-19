using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    class InterVal
    {
        public System.Timers.Timer interval(Action action, int millis)
        {
            var timer = new System.Timers.Timer(millis);
            timer.Elapsed += (s, e) =>
            {
                timer.Enabled = false;
                action();
                timer.Enabled = true;
            };
            timer.Enabled = true;
            return timer;
        }

        public void removeInterval(System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
