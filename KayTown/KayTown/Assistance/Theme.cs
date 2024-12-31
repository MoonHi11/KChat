using KayTown.Interfaces;
using KayTown.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KayTown.Assistance
{
    public class Theme
    {
        public static void SetTheme()
        {
            switch (AppThemeViewModel.Theme)
            {

                case 0:
                    Application.Current.UserAppTheme = OSAppTheme.Unspecified;
                    break;
                case 1:
                    Application.Current.UserAppTheme = OSAppTheme.Light;
                    break;
                case 2:
                    Application.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
            }
            var e = DependencyService.Get<IEnvironment>();
            if (Application.Current.RequestedTheme == OSAppTheme.Dark)
            {
                e?.SetStatusBarColor(Color.Transparent, true, Color.Transparent);

            }
            else
            {
                e?.SetStatusBarColor(Color.Transparent, false, Color.Transparent);
            }

        }
    }
}
