namespace TestModalNet8
{
    public partial class TestModalPage3 : ContentPage
    {
        public TestModalPage3()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }
    }

}
