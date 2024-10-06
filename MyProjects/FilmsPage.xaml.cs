namespace MyProjects;

public partial class FilmsPage : ContentPage
{
    private readonly FilmsViewModel _viewModel;

    public FilmsPage()
    {
        InitializeComponent();
        _viewModel = FilmsViewModel.Instance;
        BindingContext = _viewModel;
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var film = button.BindingContext as Film;
        await Navigation.PushModalAsync(new FilmDetailsModalPage(film));
    }
}