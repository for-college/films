using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyProjects;

public class FilmsViewModel : INotifyPropertyChanged
{
    private static FilmsViewModel _instance;
    public static FilmsViewModel Instance => _instance ?? (_instance = new FilmsViewModel());

    public ObservableCollection<Film> Films { get; set; }
    public ObservableCollection<WatchList> Watchlists => WatchlistManager.Watchlists;
    public ICommand AddToWatchlistCommand { get; }

    private FilmsViewModel()
    {
        Films =
        [
            new Film { ImageUrl = "callolaz.jpg", Title = "Калолаз", Genre = "Комедия" },
            new Film { ImageUrl = "mouth.jpg", Title = "Девятый Рот", Genre = "Боевик" },
            new Film { ImageUrl = "sunrise.jpg", Title = "От зарплаты до рассвета", Genre = "Хоррор" }
        ];

        AddToWatchlistCommand = new Command<Film>(async (film) => await AddToWatchlist(film));
    }

    private async Task AddToWatchlist(Film film)
    {
        if (film == null) return;

        var action = await Application.Current.MainPage.DisplayActionSheet("Добавить в список", "Отмена", null,
            Watchlists.Select(wl => wl.Name).ToArray());

        if (action == "Отмена") return;

        var selectedList = Watchlists.FirstOrDefault(wl => wl.Name == action);

        if (selectedList == null) return;

        // Удаляем фильм из всех других списков
        foreach (var list in Watchlists)
            if (list != selectedList)
                list.Movies.Remove(film);

        // Добавляем фильм в выбранный список, если его там еще нет
        if (!selectedList.Movies.Contains(film))
        {
            selectedList.Movies.Add(film);
            film.CurrentList = selectedList;
            film.OnPropertyChanged(nameof(film.CurrentList)); // Уведомляем об изменении CurrentList
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}