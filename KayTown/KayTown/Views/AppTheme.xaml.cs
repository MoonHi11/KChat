using KayTown.Assistance;
using KayTown.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KayTown.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppTheme : ContentPage
    {
        bool loaded;
        public AppTheme()
        {
            InitializeComponent();

            switch (AppThemeViewModel.Theme)
            {
                case 0:
                    RadioButtonSystem.IsChecked = true;
                    break;
                case 1:
                    RadioButtonLight.IsChecked = true;
                    break;
                case 2:
                    RadioButtonDark.IsChecked = true;
                    break;
            }


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            loaded = true;
        }

        private void RadioButtonSystem_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!loaded)
                return;
            if (!e.Value)
                return;
            var valu = (sender as RadioButton)?.Value as string;

            if (string.IsNullOrWhiteSpace(valu))
                return;

            switch (valu)
            {
                case "Default":
                    AppThemeViewModel.Theme = 0;
                    break;
                case "Light":
                    AppThemeViewModel.Theme = 1;
                    break;
                case "Dark":
                    AppThemeViewModel.Theme = 2;
                    break;
            }
            Theme.SetTheme();
        }

        async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}