using System.ComponentModel;

namespace MyProjects;

public class Review : INotifyPropertyChanged
{
    private string movieTitle = "";
    private int rating;
    private string comment = "";

    public string MovieTitle
    {
        get => movieTitle;
        set
        {
            if (movieTitle != value)
            {
                movieTitle = value;
                OnPropertyChanged(nameof(MovieTitle));
            }
        }
    }

    public int Rating
    {
        get => rating;
        set
        {
            if (rating != value)
            {
                rating = value;
                OnPropertyChanged(nameof(Rating));
            }
        }
    }

    public string Comment
    {
        get => comment;
        set
        {
            if (comment != value)
            {
                comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}