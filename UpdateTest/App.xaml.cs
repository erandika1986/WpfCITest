using Squirrel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UpdateTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Set this code once in App.xaml.cs or application startup
            //SciChartSurface.SetRuntimeLicenseKey("FDqs1EPN/0q8Sb/GrmmcGYgt2WfywzkAX8VjrtXOAplNrlMwNz9a35Vd2NKIH3msLLUx+ROS6LLSt8Dk9coSQq7NbGzPzRO8D/CXBPj6N+VtUonxE6X3rjlyNq/TP+jslA9QPCxKXu0jzpmfnzc4yMBabWRVZ/7e5Febk2tKmmTLGAp/RnaqvKi02rjssq+gNJZtbANOn7CF9m39y2ULWRnDa/UVo87bQPuuzHoDzZflxIbCwdrcFxRNOV7O3nU235QQI8MaPZsl6ZQmCakvV2WbDC00hIp04tYM9A5nV/zQITweL3sR7aiTrRdk1DXqO6mEfiFrTHnkKpLwpNZeETEfQDzpTtsk8GgOUxVH5bcFx2NXWjHN0rKUnf/lTLoYgIlMpq1sD/MEsVOgYLmgP44XkXWyB/3MG2bsoH61XPh5dIeOKYKpwD6IWmBi4/hm4i6G4o9nrxdKS+aOgsyXSKyTWSzqG3Ez9EwjOGYZb+0I/g3TUuPZ90hIeIJinBX9XpLzu2LrQJOteAuBEBM3EBlx4BqWlK+qUcC+32simkSwRwc8AtKL4ps/Uy9TNHypk1XTlQEQlay2hg==");

            System.Timers.Timer updateTimer = new System.Timers.Timer();
            updateTimer.Elapsed += UpdateTimer_Elapsed;
            updateTimer.Interval = 1000;
            updateTimer.Enabled = true;

            base.OnStartup(e);
        }

        private async void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            using (var manager = new UpdateManager(@"https://igreetingdiag482.blob.core.windows.net/updatetest"))
            {
                try
                {
                    await manager.UpdateApp();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
