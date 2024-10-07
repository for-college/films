using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyProjects;

public class ListsViewModel : INotifyPropertyChanged
{
    private static ListsViewModel? _instance;
    public static ListsViewModel Instance => _instance ?? (_instance = new ListsViewModel());

    public ObservableCollection<WatchList> Watchlists => WatchlistManager.Watchlists;
    public ICommand ViewListCommand { get; }
    public ICommand RemoveFromListCommand { get; }

    private ListsViewModel()
    {
        ViewListCommand = new Command<WatchList>(ViewList);
        RemoveFromListCommand = new Command<Film>((film) => RemoveFromList(film));
    }

    private void ViewList(WatchList watchlist)
    {
        System.Diagnostics.Debug.WriteLine($"Просмотр списка: {watchlist.Name}");
    }

    private void RemoveFromList(Film film)
    {
        foreach (var list in Watchlists)
            if (list.Movies.Remove(film))
                if (film.CurrentList == list)
                    film.CurrentList = null;
    }

    public void CreateNewList(string listName)
    {
        Watchlists.Add(new WatchList { Name = listName });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}