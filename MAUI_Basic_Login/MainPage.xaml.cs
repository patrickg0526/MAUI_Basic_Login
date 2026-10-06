namespace MAUI_Basic_Login;

public partial class MainPage : ContentPage
{
	private const string ValidUserId = "Gonzalez";
	private const string ValidPassword = "Password1";

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnLoginClicked(object? sender, EventArgs e)
	{
		string userId = txtUserName.Text?.Trim() ?? string.Empty;
		string password = txtPassword.Text ?? string.Empty;

		if (userId == ValidUserId && password == ValidPassword)
		{
			lblMessage.Text = $"Login successful: {userId}";
			lblMessage.TextColor = Colors.LimeGreen;
		}
		else
		{
			lblMessage.Text = $"Login failed: {userId}";
			lblMessage.TextColor = Colors.Red;
		}
	}

	private void OnCancelClicked(object? sender, EventArgs e)
	{
		txtUserName.Text = string.Empty;
		txtPassword.Text = string.Empty;
		lblMessage.Text = string.Empty;
	}
}
