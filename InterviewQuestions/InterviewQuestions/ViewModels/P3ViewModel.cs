#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using System;
using System.Collections.Generic;
using System.Timers;

#endregion

namespace InterviewQuestions.ViewModels
{
    public class P3ViewModel : PageViewModelBase
    {
        private List<string> _items = new List<string>();

        public P3ViewModel() : base(true)
        {
        }

        public List<string> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        protected override void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            base.TimerOnElapsed(sender, e);

            Items.Add(Guid.NewGuid().ToString());
        }
    }
}