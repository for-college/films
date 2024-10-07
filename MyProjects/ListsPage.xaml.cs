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
        var newListName = await DisplayPromptAsync("Создать новый список", "Введите имя списка:");
        if (!string.IsNullOrWhiteSpace(newListName)) ListsViewModel.Instance.CreateNewList(newListName);
    }

    private void OnPointerEntered(object sender, PointerEventArgs e)
    {
        if (sender is StackLayout stackLayout) stackLayout.BackgroundColor = Color.FromHex("#D0D0D0");
    }

    private void OnPointerExited(object sender, PointerEventArgs e)
    {
        if (sender is StackLayout stackLayout) stackLayout.BackgroundColor = Color.FromHex("#F0F0F0");
    }
}