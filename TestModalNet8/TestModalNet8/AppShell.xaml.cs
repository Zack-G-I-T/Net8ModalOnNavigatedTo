namespace TestModalNet8
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TestModalPage), typeof(TestModalPage));
            Routing.RegisterRoute(nameof(TestModalPage2), typeof(TestModalPage2));
            Routing.RegisterRoute(nameof(TestModalPage3), typeof(TestModalPage3));
        }
    }
}
