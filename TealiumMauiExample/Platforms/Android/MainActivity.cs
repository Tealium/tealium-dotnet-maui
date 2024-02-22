using Android.App;
using Android.Content.PM;
using Android.OS;

using Tealium;
using Tealium.Droid;
using Tealium.RemoteCommands.Firebase.Droid;

namespace TealiumMauiExample;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Teal.Helper.SetInstanceManager(new TealiumInstanceManager(new TealiumInstanceFactoryDroid(this.Application)));
        var command = new FirebaseRemoteCommandDroid(this.Application, "firebase.json", null);
        Console.WriteLine("Remote Command added: " + command.Name);
        Teal.Helper.RemoteCommands.Add(command);
        Teal.Helper.Init();
    }
}

