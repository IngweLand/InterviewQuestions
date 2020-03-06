using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Prism.Navigation;

namespace InterviewQuestions.ViewModels
{
    public class P1ViewModel : PageViewModelBase
    {
        public P1ViewModel():base(true)
        {

        }

        private string _labelValue;

        public string LabelValue
        {
            get => _labelValue;
            set => SetProperty(ref _labelValue, value);
        }

        protected override void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            base.TimerOnElapsed(sender, e);

            Task.Run(async () =>
            {
                await Task.Delay(1000);
                LabelValue = Guid.NewGuid().ToString();
            });
        }
    }
}
