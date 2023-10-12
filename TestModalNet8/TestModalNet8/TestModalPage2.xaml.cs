namespace TestModalNet8
{
    public partial class TestModalPage2 : ContentPage
    {
        public TestModalPage2()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }
        private void GoToModal3(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("TestModalPage3");
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }
    }

}
