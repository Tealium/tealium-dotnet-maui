using Foundation;
using Tealium;
using Tealium.iOS;
using Tealium.Platform.iOS;
using Tealium.RemoteCommands.Firebase.iOS;

namespace TealiumMauiExample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    [Export("application:didFinishLaunchingWithOptions:")]
    override public bool FinishedLaunching(UIKit.UIApplication application, NSDictionary launchOptions)
    {
        Teal.Helper.SetInstanceManager(new TealiumInstanceManager(new TealiumInstanceFactoryIOS()));
        var command = new FirebaseRemoteCommandIOS(new RemoteCommandTypeWrapper("firebase", NSBundle.MainBundle));
        Console.WriteLine(command.Name);
        Teal.Helper.RemoteCommands.Add(command);
        Teal.Helper.Init();
        return base.FinishedLaunching(application, launchOptions);
    }
}

