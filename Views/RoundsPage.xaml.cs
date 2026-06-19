using golfIQ.Views;

namespace golfIQ.Views;

public partial class RoundsPage : ContentPage
{
    public RoundsPage()
    {
        InitializeComponent();
    }

    private async void OnAddRoundClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewRoundPage));
    }
}