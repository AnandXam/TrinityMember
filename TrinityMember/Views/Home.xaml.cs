using System;
using System.Collections.Generic;
using JobcardScanner.Effects;
using TrinityMember.DataModel;
using Xamarin.Forms;

namespace TrinityMember.Views
{
    public partial class Home : ContentPage
    {
        List<FamilyMembers> householdsdmanager = new List<FamilyMembers>();
        UserData UserDetails = new UserData();
        List<string> vehicleTypes;
        bool _isPageLoaded = false;
        public Home()
        {
            InitializeComponent();
        }

        #region Page On Appearing 
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if(!_isPageLoaded)
            {
                _isPageLoaded = true;
                UserDetails = new UserData { name = "Abraham Thomas", place = "Peral Land East", houseno = "#56566", gender = "Male", address = "601 Lakeland Terrace", phoneno = "+91 6456584156",image= "https://i.pravatar.cc/150?img=8" };
                householdsdmanager = new List<FamilyMembers>()
                {
                new FamilyMembers{id=1,name="Rachel Thomas",relation="Wife",image="https://i.pravatar.cc/150?img=5",birthday="Feb 25 2022,Monday",anniversary="Jan 18 2016,Sunday"},
                new FamilyMembers{id=1,name="Julissa Thomas",relation="Sister",image="https://i.pravatar.cc/150?img=9",birthday="Aug 02 2022,Tuesday",anniversary=""},
                new FamilyMembers{id=1,name="Aby Thomas",relation="Brother",image="https://i.pravatar.cc/150?img=3",birthday="Oct 14 2022,Monday",anniversary=""},
                new FamilyMembers{id=1,name="Johny Thomas",relation="Brother",image="https://i.pravatar.cc/150?img=7",birthday="Dec 06 2022,Tuesday",anniversary=""}
                };
                vehicleTypes = new List<string>() { "Birthdays", "Wedding Anniversary" };
            }
            HoseholdsCollectionView.ItemsSource = householdsdmanager;
            BirthdayCollectionView.ItemsSource = householdsdmanager;
            weddinganiversarygrid.BindingContext = householdsdmanager[0];
            DataGrid.BindingContext = UserDetails;
            segment.Children = vehicleTypes;
        }
        #endregion

        #region Segmented Control Changed
        public async void segment_SelectedItemChanged(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem== "Birthdays")
            {
                await ViewAnimations.DisappearingAnim(weddinganiversarygrid);
                weddinganiversarygrid.IsVisible = false;
                BirthdayCollectionView.IsVisible = true;
                await ViewAnimations.AppearingAnim(BirthdayCollectionView);
                
            }
            else
            {
                await ViewAnimations.DisappearingAnim(BirthdayCollectionView);
                BirthdayCollectionView.IsVisible = false;
                weddinganiversarygrid.IsVisible = true;
                await ViewAnimations.AppearingAnim(weddinganiversarygrid);
            }
        }
        #endregion

        #region Side bar menu Clicked
        void Menu_Tapped(System.Object sender, System.EventArgs e)
        {
            MessagingCenter.Send<Home>(this, "FlyoutTapped");
        }
        #endregion
    }
}
