#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using System.Collections.Generic;
using InterviewQuestions.Views;
using Prism.Mvvm;
using Prism.Navigation;

#endregion

namespace InterviewQuestions.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        private List<string> _pages;
        private string _selectedPage;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            Pages = new List<string>()
            {
                nameof(P1),
                nameof(P2),
                nameof(P3)
            };
        }

        public List<string> Pages
        {
            get => _pages;
            set => SetProperty(ref _pages, value);
        }

        public string SelectedPage
        {
            get => _selectedPage;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _navigationService.NavigateAsync(value);
                }
            }
        }
    }
}