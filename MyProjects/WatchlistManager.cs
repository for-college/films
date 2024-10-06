using System.Collections.ObjectModel;

namespace MyProjects
{
  public static class WatchlistManager
  {
    public static ObservableCollection<WatchList> Watchlists { get; } =
    [
        new WatchList { Name = "Смотрю" },
            new WatchList { Name = "Обязательно посмотрю" },
            new WatchList { Name = "Посмотрел" }
    ];
  }
}