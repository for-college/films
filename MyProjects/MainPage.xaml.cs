
namespace MyProjects;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnViewMoviesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FilmsPage());
    }

    private async void OnMyListsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListsPage());
    }
}