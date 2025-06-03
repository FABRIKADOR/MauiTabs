using Act4.Models;

namespace Act4.Views.Characters;

public partial class CharacterDetailPage : ContentPage
{
    public Character Character { get; set; }

    public CharacterDetailPage(Character character)
    {
        InitializeComponent();
        Character = character;
        BindingContext = this;
    }

    private async void OnFavoriteClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Favorito", $"{Character.Name} agregado a favoritos!", "OK");
    }

    private async void OnShareClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Compartir", $"Compartiendo información de {Character.Name}", "OK");
    }
}