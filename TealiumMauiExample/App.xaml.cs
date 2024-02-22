using TealiumMauiExample.Services;

namespace TealiumMauiExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
	}
}

