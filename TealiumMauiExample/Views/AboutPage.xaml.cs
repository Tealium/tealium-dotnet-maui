using Tealium;

namespace TealiumMauiExample.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Teal.Helper.DefaultInstance.Track(new TealiumView("About"));
    }
}
