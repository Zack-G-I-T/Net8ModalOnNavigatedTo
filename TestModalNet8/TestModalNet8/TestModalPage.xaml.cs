namespace TestModalNet8
{
    public partial class TestModalPage : ContentPage
    {
        public TestModalPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }
        private void GoToModal2(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("TestModalPage2");
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }
    }

}
