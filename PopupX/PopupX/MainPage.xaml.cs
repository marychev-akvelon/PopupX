using System;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace PopupX
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var pr = new PopUp();
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            pr.Animation = scaleAnimation;
#pragma warning disable CS0618 // Type or member is obsolete
            await PopupNavigation.PushAsync(pr);
#pragma warning restore CS0618 // Type or member is obsolete
        }

    }
}
