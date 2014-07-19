using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Dikkenek_WindowsPhone8._1.Common;
using System;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle Application Hub, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641
using Dikkenek_WindowsPhone8._1.Models;
using Dikkenek_WindowsPhone8._1.ViewModels;

namespace Dikkenek_WindowsPhone8._1
{
    /// <summary>
    /// Page affichant une collection groupée d'éléments.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public AppViewModel ViewModel { get; set; }

        /// <summary>
        /// Obtient le <see cref="NavigationHelper"/> associé à ce <see cref="Page"/>.
        /// </summary>
        private readonly NavigationHelper navigationHelper;
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }
        
        public HomePage()
        {
            ViewModel = (App.Current as App).ViewModel;

            this.InitializeComponent();

            // Hub est pris en charge uniquement en mode Portrait
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

            this.NavigationCacheMode = NavigationCacheMode.Required;

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Remplit la page à l'aide du contenu passé lors de la navigation. Tout état enregistré est également
        /// fourni lorsqu'une page est recréée à partir d'une session antérieure.
        /// </summary>
        /// <param name="sender">
        /// La source de l'événement ; en général <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Données d'événement qui fournissent le paramètre de navigation transmis à
        /// <see cref="Frame.Navigate(Type, Object)"/> lors de la requête initiale de cette page et
        /// un dictionnaire d'état conservé par cette page durant une session
        /// antérieure.  L'état n'aura pas la valeur Null lors de la première visite de la page.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Conserve l'état associé à cette page en cas de suspension de l'application ou de
        /// suppression de la page du cache de navigation.  Les valeurs doivent être conformes aux
        /// exigences en matière de sérialisation de <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">La source de l'événement ; en général <see cref="NavigationHelper"/></param>
        /// <param name="e">Données d'événement qui fournissent un dictionnaire vide à remplir à l'aide de l'
        /// état sérialisable.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region Inscription de NavigationHelper

        /// <summary>
        /// Les méthodes fournies dans cette section sont utilisées simplement pour permettre
        /// NavigationHelper pour répondre aux méthodes de navigation de la page.
        /// <para>
        /// La logique spécifique à la page doit être placée dans les gestionnaires d'événements pour le
        /// <see cref="NavigationHelper.LoadState"/>
        /// et <see cref="NavigationHelper.SaveState"/>.
        /// Le paramètre de navigation est disponible dans la méthode LoadState
        /// en plus de l'état de page conservé durant une session antérieure.
        /// </para>
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void PhrasesListView_OnItemClick(object sender, ItemClickEventArgs e)
        {
            var phrase = e.ClickedItem as Phrase;

            var uri = new Uri("ms-appx://" + phrase.Sound);
            await PlaySound(uri);
        }

        private async Task PlaySound(Uri soundUri)
        {
            try
            {
                var soundFile = await StorageFile.GetFileFromApplicationUriAsync(soundUri);

                Player.Stop();
                Player.SetSource(await soundFile.OpenReadAsync(), soundFile.ContentType);
            }
            catch (Exception)
            {
                (new MessageDialog("Erreur lors de la lecture du son")).ShowAsync();
            }
        }

        private async void ListViewHeader_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var category = (sender as FrameworkElement).Tag as Category;

            var random = new Random();
            var randomPhrase = category.Phrases[random.Next(category.Phrases.Count)];

            var uri = new Uri("ms-appx://" + randomPhrase.Sound);
            await PlaySound(uri);
        }

        private void Phrase_OnHolding(object sender, HoldingRoutedEventArgs e)
        {
            var grid = (sender as FrameworkElement);
            var phrase = grid.DataContext as Phrase;

            ToggleFavoriteFlyoutItem.Text = ViewModel.Favorites.Phrases.Contains(phrase) 
                ? "Retirer des favoris" 
                : "Ajouter aux favoris";

            ItemFlyout.ShowAt(grid);
        }
    }
}
