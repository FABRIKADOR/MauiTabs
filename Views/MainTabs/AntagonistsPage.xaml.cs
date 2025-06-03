using Act4.Models;
using Act4.Services;
using Act4.Views.Characters;

namespace Act4.Views.MainTabs;

public partial class AntagonistsPage : ContentPage
{
    public AntagonistsPage()
    {
        InitializeComponent();
        LoadCharacters();
    }

    private void LoadCharacters()
    {
        CharactersCollectionView.ItemsSource = CharacterService.GetAntagonists();
    }

    private async void OnCharacterTapped(object sender, EventArgs e)
    {
        var frame = sender as Frame;
        var character = frame?.BindingContext as Character;

        if (character != null)
        {
            await Navigation.PushAsync(new CharacterDetailPage(character));
        }
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Animación de entrada para las cards
        CharactersCollectionView.Opacity = 0;
        CharactersCollectionView.TranslationY = 50;

        await Task.WhenAll(
            CharactersCollectionView.FadeTo(1, 500),
            CharactersCollectionView.TranslateTo(0, 0, 500, Easing.CubicOut)
        );
    }
}