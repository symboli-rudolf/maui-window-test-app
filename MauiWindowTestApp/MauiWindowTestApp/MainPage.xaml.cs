namespace MauiWindowTestApp;

public partial class MainPage : ContentPage
{
	readonly SubPage subPage;

	public MainPage(SubPage subPage)
	{
		InitializeComponent();

        this.subPage = subPage;
    }

	private void OnNewWindowClicked(object sender, EventArgs e)
	{
        Window newWindow = new()
		{
			Page = this.subPage,
			Width = 250,
            Height = 300,
        };
        Application.Current?.OpenWindow(newWindow);
    }
}

