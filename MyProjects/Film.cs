using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyProjects;

public class Film : INotifyPropertyChanged
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    private WatchList _currentList;

    public WatchList CurrentList
    {
        get => _currentList;
        set
        {
            if (_currentList != value)
            {
                _currentList = value;
                OnPropertyChanged(nameof(CurrentList));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}