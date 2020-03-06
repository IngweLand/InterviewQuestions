#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using System.Diagnostics;
using System.Timers;
using Prism.Mvvm;
using Prism.Navigation;

#endregion

namespace InterviewQuestions.ViewModels
{
    public abstract class PageViewModelBase : BindableBase, INavigationAware
    {
        private Timer _timer;

        public PageViewModelBase()
        {
        }

        public PageViewModelBase(bool shouldInitTimer) : this()
        {
            if (shouldInitTimer)
            {
                _timer = new Timer(1000);
                _timer.Elapsed += TimerOnElapsed;
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Elapsed -= TimerOnElapsed;
                _timer.Close();
            }
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            _timer?.Start();
        }

        protected virtual void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine($"<||> {nameof(PageViewModelBase)} | {nameof(TimerOnElapsed)}");
        }
    }
}