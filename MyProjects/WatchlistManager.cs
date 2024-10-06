using System.Collections.ObjectModel;

namespace MyProjects;

public static class WatchlistManager
{
    public static ObservableCollection<WatchList> Watchlists { get; } =
    [
        new() { Name = "Смотрю" },
        new() { Name = "Обязательно посмотрю" },
        new() { Name = "Посмотрел" }
    ];
}