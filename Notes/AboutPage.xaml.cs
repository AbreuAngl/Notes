namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void EnviarGitBtn_Clicked(object sender, EventArgs e)
    {
		Launcher.Default.OpenAsync("https://https://github.com/angelowhtz");
    }
}