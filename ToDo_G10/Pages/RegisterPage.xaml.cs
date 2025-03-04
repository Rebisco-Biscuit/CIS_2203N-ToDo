namespace ToDo_G10.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnLoginTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Navigate back to login page
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Perform registration logic here
        await DisplayAlert("Success", "You are now registered!", "OK");

        // Navigate back to MainPage after registration
        await Navigation.PopAsync();
    }
}
