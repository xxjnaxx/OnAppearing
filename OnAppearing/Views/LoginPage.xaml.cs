namespace OnAppearing;
using OnAppearing.ViewModels;

public partial class LoginPage : ContentPage
{
	
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel();
		NavigationPage.SetHasNavigationBar(this, false);
		

		

		



	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		var loggedin = true;
		if (loggedin)
			await Shell.Current.GoToAsync("//suche");
    }









}
