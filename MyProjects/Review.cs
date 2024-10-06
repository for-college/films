using System.ComponentModel;

namespace MyProjects;

public class Review : INotifyPropertyChanged
{
    private string _movieTitle = "";
    private int _rating;
    private string _comment = "";

    public string MovieTitle
    {
        get => _movieTitle;
        set
        {
            if (_movieTitle != value)
            {
                _movieTitle = value;
                OnPropertyChanged(nameof(MovieTitle));
            }
        }
    }

    public int Rating
    {
        get => _rating;
        set
        {
            if (_rating == value) return;
            _rating = value;
            OnPropertyChanged(nameof(Rating));
        }
    }

    public string Comment
    {
        get => _comment;
        set
        {
            if (_comment == value) return;
            _comment = value;
            OnPropertyChanged(nameof(Comment));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}