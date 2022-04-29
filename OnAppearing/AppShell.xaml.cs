namespace OnAppearing;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void OnMenuItemClicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new AppShell());
        await Current.GoToAsync("//loginpage");

    }
}
