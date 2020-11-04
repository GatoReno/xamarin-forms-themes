using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThemesPractice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Application.Current.RequestedThemeChanged += (_, args) =>
            {
                themeText.Text = args.RequestedTheme.ToString();
            };
            //setting colors on theme changed

            //mainText.SetOnAppTheme(Label.TextColorProperty, Color.Blue, Color.Black);
            //mainText.SetAppThemeColor(Label.TextColorProperty, Color.Black, Color.Beige);
        }
        public void btnChangeTheme_Clicked(object sender, EventArgs args)
        {
            if (Application.Current.RequestedTheme.ToString() == "Dark")
            {
                Application.Current.UserAppTheme = OSAppTheme.Light;
            }
            else {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            themeText.Text = Application.Current.RequestedTheme.ToString();
        }
    }
}
