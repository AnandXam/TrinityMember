using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityMember.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrinityMember.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingScreen : ExtendedTabbedPage
    {
        public LandingScreen()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
