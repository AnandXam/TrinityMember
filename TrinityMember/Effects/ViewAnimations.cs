using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JobcardScanner.Effects
{
    public static class ViewAnimations
    {
        public static async Task FadeAnimY(View view)
        {
            await view.FadeTo(1, 200);
            await view.TranslateTo(0, 0, 200);
        }

        public static async Task DisappearingAnim(View view)
        {
            await view.FadeTo(0, 150);
            await view.TranslateTo(100, 0, 150);
        }
        public static async Task AppearingAnim(View view)
        {
            view.FadeTo(1, 150);
            await view.TranslateTo(0, 0, 200);
        }
        
    }
}


