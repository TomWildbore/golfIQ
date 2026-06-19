namespace golfIQ
{
    using golfIQ.Views;
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NewRoundPage), typeof(NewRoundPage));
        }
    }
}
