using System;
using TrinityMember.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("PlayfairDisplay-Bold.ttf", Alias = "PD-B")]
[assembly: ExportFont("PlayfairDisplay-Regular.ttf", Alias = "PD-M")]
[assembly: ExportFont("PlayfairDisplay-Regular.ttf", Alias = "PD-R")]
[assembly: ExportFont("Archivo-Medium.ttf", Alias = "MS-M")]
[assembly: ExportFont("fa-regular.otf", Alias = "FA-R")]
[assembly: ExportFont("fa-solid.otf", Alias = "FA-B")]
[assembly: ExportFont("fa-regular-brands.otf", Alias = "FA-BR")]
namespace TrinityMember
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new SideMenuScreen());
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
