using TealiumMauiExample.Services;

namespace TealiumMauiExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        DependencyService.Register<MockDataStore>();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		return new Window(new AppShell());
	}
}

