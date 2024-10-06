namespace MyProjects;

public partial class ListsPage : ContentPage
{
  public ListsPage()
  {
    InitializeComponent();
    BindingContext = ListsViewModel.Instance;
  }

  private async void OnCreateNewListClicked(object sender, EventArgs e)
  {
    await DisplayAlert("Не-а", "Не сегодня.", "OK");
  }
}