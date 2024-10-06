namespace MyProjects;

public partial class ReviewsPage
{
    private ReviewViewModel ViewModel { get; set; }

    public ReviewsPage()
    {
        InitializeComponent();
        ViewModel = new ReviewViewModel();
        BindingContext = ViewModel;
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        RatingSlider.Value = Math.Round(e.NewValue);
    }

    private async void OnSubmitReviewClicked(object sender, EventArgs e)
    {
        ViewModel.Review.MovieTitle = "Тайтл";
        ViewModel.Review.Rating = (int)RatingSlider.Value;
        ViewModel.Review.Comment = CommentEditor.Text;

        await DisplayAlert("Ау", "Ау!", "OK");

        CommentEditor.Text = string.Empty;
        RatingSlider.Value = 1;
    }
}