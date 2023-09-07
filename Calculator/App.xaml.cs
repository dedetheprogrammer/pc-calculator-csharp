
namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState) {
		var window = base.CreateWindow(activationState);

		const int new_width  = 400;
		const int new_height = 450;
		
		window.MinimumWidth  = window.MaximumWidth  = window.Width  = new_width;
		window.MinimumHeight = window.MaximumHeight = window.Height = new_height;

		return window;
	}
}
