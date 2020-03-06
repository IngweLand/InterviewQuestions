#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using InterviewQuestions.ViewModels;
using Xamarin.Forms;

#endregion

namespace InterviewQuestions.Views
{
    public partial class P2 : ContentPage
    {
        private Timer _timer;

        public P2()
        {
            InitializeComponent();

            _timer = new Timer(1000);
            _timer.Elapsed += timerOnElapsed;
            _timer.Start();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Elapsed -= timerOnElapsed;
                _timer.Close();
            }
        }

        private void timerOnElapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine($"<||> {nameof(PageViewModelBase)} | {nameof(timerOnElapsed)}");

            Task.Run(async () =>
            {
                await Task.Delay(1000);
                MyLabel.Text = Guid.NewGuid().ToString();
            });
        }
    }
}