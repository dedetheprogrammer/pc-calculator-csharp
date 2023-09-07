namespace Calculator;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	/*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	*/

	private void CalculatorRes(object sender, EventArgs e) {
		LabelRes.Text = "Hola, byenas tardes";
		SemanticScreenReader.Announce(LabelRes.Text);
	}

}

