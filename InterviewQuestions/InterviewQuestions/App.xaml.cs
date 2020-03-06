#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using InterviewQuestions.ViewModels;
using InterviewQuestions.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

#endregion

namespace InterviewQuestions
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
        }

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<P1, P1ViewModel>();
            containerRegistry.RegisterForNavigation<P2, P2ViewModel>();
            containerRegistry.RegisterForNavigation<P3, P3ViewModel>();
        }
    }
}