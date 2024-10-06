using System;
using Microsoft.Maui.Controls;

namespace MyProjects;

public partial class FilmDetailsModalPage : ContentPage
{
    public FilmDetailsModalPage(Film film)
    {
        InitializeComponent();
        BindingContext = film;
    }

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}