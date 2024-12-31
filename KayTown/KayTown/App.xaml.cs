
using KayTown.Services;
using KayTown.Views;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KayTown
{
    public partial class App : Application
    {
        public static DatabaseInit DatabaseInit { get; private set; }
        public App()
        {
            InitializeComponent();

            DatabaseInit = new DatabaseInit(Path.Combine(FileSystem.AppDataDirectory, "ChatDatas.db"));
            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
