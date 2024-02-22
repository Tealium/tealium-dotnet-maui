using Tealium;
using TealiumMauiExample.ViewModels;

namespace TealiumMauiExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        this.BindingContext = new LoginViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Teal.Helper.DefaultInstance.Track(new TealiumView("Login"));
    }
}
