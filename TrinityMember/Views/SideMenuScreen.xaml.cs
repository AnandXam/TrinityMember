using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrinityMember.Views
{
    public partial class SideMenuScreen : FlyoutPage
    {
        public SideMenuScreen()
        {
           
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var homePage = typeof(LandingScreen);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));

            IsPresented = false;

            MessagingCenter.Subscribe<Home>(this, "FlyoutTapped", (sender) =>
            {
                IsPresented = true;
            });
        }
    }
}
