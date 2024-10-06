namespace MyProjects;

public partial class FilmsPage 
{
    public FilmsPage()
    {
        InitializeComponent();
        var viewModel = FilmsViewModel.Instance;
        BindingContext = viewModel;
    }

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var film = (Film)button?.BindingContext!;
        await Navigation.PushModalAsync(new FilmDetailsModalPage(film));
    }
}