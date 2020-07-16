using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinModalNavigationBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationAwareContentPage : ContentPage
    {
        public NavigationAwareContentPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            localNavigationInformation.Text = "Current Page Navigation stacks \n" + GetNavigationInformation(Navigation);
            mainPageNavigationInformation.Text = "Navigation Page stacks\n" + GetNavigationInformation(Application.Current.MainPage.Navigation);

            base.OnAppearing();
        }


        private string GetNavigationInformation(INavigation navigation)
        {
            return $"Modal stack count: {navigation.ModalStack.Count}, Navigation stack count: {navigation.NavigationStack.Count}";
        }

        private void Back_OnClicked(object sender, EventArgs e)
        {
            if (Navigation.ModalStack.Count > 0)
            {
                Navigation.PopModalAsync();
            }
            else
            {
                Navigation.RemovePage(this);
            }
        }
    }
}