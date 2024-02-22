using Tealium;

namespace TealiumMauiExample.Views;

public partial class ConsentManagerPage : ContentPage
{
    readonly ITealium tealium;

    public ConsentManagerPage()
    {
        this.tealium = Teal.Helper.DefaultInstance;
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        tealium.Track(new TealiumView("Consent Manager Page"));
    }
}
