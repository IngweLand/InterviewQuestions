#region Author

// Author ILLIA GOLOVACH (aka IngweLand)
// http://ingweland.com
// ingweland@gmail.com

#endregion

#region

using Xamarin.Forms;

#endregion

namespace InterviewQuestions.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MyList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MyList.SelectedItem = null;
        }
    }
}