namespace MAUIControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //var navPage = new NavigationPage(new MainPage());
            //navPage.BarBackground = Colors.Green;
            //navPage.BarTextColor = Colors.White;
            //MainPage = navPage;
            MainPage = new StackPageDemo();
        }
    }
}
