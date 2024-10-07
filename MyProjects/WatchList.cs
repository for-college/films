using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyProjects;

public class WatchList : INotifyPropertyChanged
{
    public string? Name { get; set; }
    public ObservableCollection<Film> Movies { get; } = [];

    public event PropertyChangedEventHandler? PropertyChanged;
    //
    // protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    // {
    //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    // }
}